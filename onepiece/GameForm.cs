using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CartagenaServer;

namespace onepiece
{
    public partial class GameForm : Form
    {
        LoginForm loginForm;
        Tabuleiro tabuleiro;
        Strategy strategy;
        Jogador jogador;
        PictureBox[] mapTiles;
        PictureBox unit;

        // Keeps track of the number of pirates on each tile
        int[] occupation;
        // Stores the colors of the players at the start of the game
        Dictionary<string, Color> colors;
        // Jail and Boat pirate count
        List<Jogador> cadeia = new List<Jogador>();
        List<Jogador> barco = new List<Jogador>();

        // Id of the match being played
        int idPartida;
        // All cards in hand, strings
        string[] mao;

        // DEV Automation variables
        bool jogoIniciado = false;
        bool jogoTerminado = false;
        int vez;
    
        List<string> jogadoresPartida = new List<string>();
        string[] jogadores;
        string currentPlayer;
        string players;


        /************************************************************************************************
         * 
         *                                      INITIALIZATION 
         * 
         * **********************************************************************************************/

        public GameForm(LoginForm form)
        {
            // Defines the form from which login data will be retrieved
            loginForm = form;
            InitializeComponent();

            // Prevents the form from being resized or maximized
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            // New map object instantiation
            tabuleiro = new Tabuleiro();
            

            idPartida = Convert.ToInt32(loginForm.idPartida);
            txtIdJogador.Text = loginForm.idJogador;
            txtSenhaJogador.Text = loginForm.senhaJogador;
            txtCorJogador.Text = loginForm.corJogador;

            players = Jogo.ListarJogadores(idPartida);

            // Setup of the icons combobox
            cboSimbolo.Items.Add("");
            cboSimbolo.Items.Add("Esqueleto");
            cboSimbolo.Items.Add("Chave");
            cboSimbolo.Items.Add("Garrafa");
            cboSimbolo.Items.Add("Pistola");
            cboSimbolo.Items.Add("Tricórnio");
            cboSimbolo.Items.Add("Faca");

            /* 
             * Automation 
             */

            tmrVerificarVez.Interval = 1500;
            tmrVerificarVez.Enabled = false;

            /* 
             * Strategy 
             */

            strategy = new Strategy(); 

        }

        /* DEVELOPMENT Initializes in spectator mode */
        public GameForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            // Id needs to be defined manually
            idPartida = 32;
            tabuleiro = new Tabuleiro();
            definirJogadores();
            exibirTabuleiro();
        }

        /************************************************************************************************
         * 
         *                                      SETUP 
         * 
         * **********************************************************************************************/

        // Method that builds a dictionary for the players (id and color)
        private void definirJogadores()
        {
            string response = Jogo.ListarJogadores(idPartida);

            // Defining players using the 'Jogador' object
            players = response;

            //string replaced = response.Replace('', ' ');
            string[] playersSplit = response.Split('\n');
            foreach (var pl in playersSplit)
            {
                if (pl != "")
                {
                    string[] current = pl.Split(',');
                    string id = current[0];
                    string nome = current[1];
                    jogadoresPartida.Add(id);
                    jogadoresPartida.Add(nome);
                }
            }
            // You can convert it back to an array if you would like to
            jogadores = jogadoresPartida.ToArray();
            colors = Jogador.definirCores(response);
        }

        // Method that constructs the game board
        private void exibirTabuleiro()
        {
            //  Constructing the map tiles vector. Consists of the 36 different pictureboxes the tiles are drawn into
            mapTiles = new PictureBox[36];

            //  Requests the server the blueprint of the map
            string mapBlueprint = Jogo.ExibirTabuleiro(idPartida);

            /*  Builds the map using tiles based on the blueprint requested from the server.
                Returns a char list of all the symbols and their order in the map. Stores it in the blueprint list
                to be used in the strategy section. */

           strategy.blueprint = tabuleiro.construir(picMapBackground, mapTiles, mapBlueprint);
        }

        private void updateBoardState()
        {
            string response = Jogo.VerificarVez(idPartida);

            // Updates the textbox with the current board state
            txtVerificarVez.Text = response;

            //  Replace the 'next line' characters from the string with blanks
            response = response.Replace("\n", "");

            /*  Split the string at the '\r' and ',' characters so that we're left with an array of strings
                Every three items make up a line POSITION / PLAYER / NR PIRATES
                The first line defines whose turn it is and how many plays he has left.
                The other lines define the positions of the pirates. */
            string[] estadoTabuleiro = response.Split('\r', ',');

            // Clear the myselfPosPiratas array
            strategy.myPos.Clear();

            //  Last input of estadoTabuleiro is empty
            for (int i = 3; i < estadoTabuleiro.Length - 1; i += 3)
            {
                int position, repeat;
                string player;

                position = Convert.ToInt32(estadoTabuleiro[i]);

                repeat = Convert.ToInt32(estadoTabuleiro[i + 2]);

                player = estadoTabuleiro[i + 1];

                // Verify if the game finished
                if (position == 37 && repeat == 6)
                {
                    jogoTerminado = true;
                    tmrVerificarVez.Enabled = false;
                    MessageBox.Show("O jogo terminou!");
                }

                // Populate myPos
                if (player == loginForm.idJogador && position != 37)
                {
                    int j = 0;
                    while (j < repeat)
                    {
                        strategy.myPos.Add(position);
                        j++;
                    }
                }
            }

            // Player id of who should play this turn
            vez = Convert.ToInt32(estadoTabuleiro[1]);
            exibirJogadorAtual(vez);
            
            // Draws board state
            drawBoardState(response, estadoTabuleiro);
        }

        private void drawBoardState(string response, string[] estadoTabuleiro)
        {

            // Clear jail and boat
            cadeia.Clear();
            barco.Clear();

            // Clear units
            IList<PictureBox> pbs = new List<PictureBox>();

            foreach (var pb in picMapBackground.Controls.OfType<PictureBox>())
            {
                if ((string)pb.Tag == "pirate")
                    pbs.Add(pb);
            }

            for (int i = pbs.Count - 1; i >= 0; i--)
            {
                picMapBackground.Controls.Remove(pbs[i]);
            }

            // Instatiates new occupation array
            occupation = new int[36];

            //  Last input of estadoTabuleiro is empty
            for (int i = 3; i < estadoTabuleiro.Length - 1; i += 3)
            {
                int position, repeat;
                string player;
                Color color;

                position = Convert.ToInt32(estadoTabuleiro[i]);

                repeat = Convert.ToInt32(estadoTabuleiro[i + 2]);

                player = estadoTabuleiro[i + 1];
                color = colors[player];

                jogador = new Jogador(color, repeat);

                // 0 is the Jail and 37 is the boat
                if (position == 0)
                {
                    cadeia.Add(jogador);
                }
                else if (position == 37)
                {
                    barco.Add(jogador);
                }
                else
                    drawUnit(position, color, repeat);
            }

            dgvCadeia.DataSource = null;
            dgvCadeia.DataSource = cadeia;
            dgvCadeia.ClearSelection();

            dgvBarco.DataSource = null;
            dgvBarco.DataSource = barco;
            dgvBarco.ClearSelection();

            // Fill in the strategy occupation vector
            strategy.occupation = occupation;
        }

        private void drawUnit(int position, Color color, int repeat)
        {
            int x, y;
            x = mapTiles[position - 1].Location.X;
            y = mapTiles[position - 1].Location.Y;

            //  x and y offsets based on pic tiles size
            switch (occupation[position - 1])
            {
                case 0:
                    x -= 15;
                    break;
                case 1:
                    x += 5;
                    break;
                case 2:
                    x += 25;
                    break;
            }

            y += 30;

            unit = new PictureBox();
            unit.Size = new Size(15, 15);
            unit.BackColor = color;
            unit.Location = new Point(x, y);
            picMapBackground.Controls.Add(unit);
            unit.Tag = "pirate";
            unit.BringToFront();

            //  Checks for number of pirates
            if (repeat == 2)
            {
                occupation[position - 1] += 1;
                drawUnit(position, color, 0);
            }
            else if (repeat == 3)
            {
                occupation[position - 1] += 1;
                drawUnit(position, color, 2);
            }
            else
            {
                occupation[position - 1] += 1;
            }
        }

        private void exibirJogadorAtual(int vez)
        {
            // Colocando nome do jogador atual no lblCurrentPlayer
            for (int i = 0; i < jogadores.Length; i++)
            {
                if (vez.ToString() == jogadores[i])
                {
                    lblCurrentPlayer.Text = jogadores[i + 1];
                }
            }
        }

        private void updateMao()
        {
            // Clear cards
            strategy.cartas.Clear();

            // Update cards in hand
            string response = Jogo.ConsultarMao(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador);
            response = response.Replace("\n", "");
            mao = response.Split('\r', ',');

            lblSkull.Text = "0";
            lblTricorn.Text = "0";
            lblPistol.Text = "0";
            lblKey.Text = "0";
            lblBottle.Text = "0";
            lblKnife.Text = "0";

            for (int i = 0; i < mao.Length - 1; i += 2)
            {
                // Populate the cards list
                for (int j = 0; j < Convert.ToInt32(mao[i + 1]); j++)
                {
                    strategy.cartas.Add(mao[i]);
                }

                switch (mao[i])
                {
                    case "E":
                        lblSkull.Text = mao[i + 1];
                        break;
                    case "T":
                        lblTricorn.Text = mao[i + 1];
                        break;
                    case "P":
                        lblPistol.Text = mao[i + 1];
                        break;
                    case "C":
                        lblKey.Text = mao[i + 1];
                        break;
                    case "G":
                        lblBottle.Text = mao[i + 1];
                        break;
                    case "F":
                        lblKnife.Text = mao[i + 1];
                        break;
                    default:
                        lblSkull.Text = "0";
                        lblTricorn.Text = "0";
                        lblPistol.Text = "0";
                        lblKey.Text = "0";
                        lblBottle.Text = "0";
                        lblKnife.Text = "0";
                        break;
                }
            }
        }


        /************************************************************************************************
         * 
         *                                      USER INTERACTION 
         * 
         * **********************************************************************************************/


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string iniciarPartida = Jogo.IniciarPartida(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador);
            if (iniciarPartida.Contains("ERRO"))
            {
                MessageBox.Show(iniciarPartida);
            }
            else
            {
                if (!jogoIniciado)
                {
                    definirJogadores();
                    exibirTabuleiro();
                    updateMao();
                    jogoIniciado = true;
                    tmrVerificarVez.Enabled = true;
                }
            }
        }

        private void btnExibirMao_Click(object sender, EventArgs e)
        {
            updateMao();
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            // If another player started the game, the game state will be set to true
            if (!jogoIniciado)
            {
                jogoIniciado = true;
                tmrVerificarVez.Enabled = true;
                if (!txtVerificarVez.Text.Contains("ERRO"))
                {
                    definirJogadores();
                    exibirTabuleiro();
                    updateMao();
                    updateBoardState();
                }
            }
            else
            {
                updateBoardState();
            }

        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            txtHistorico.Text = Jogo.ExibirHistorico(Convert.ToInt32(loginForm.idPartida));
        }

        private void btnPularVez_Click(object sender, EventArgs e)
        {
            Jogo.Jogar(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador);
        }

        private void btnMoverFrente_Click(object sender, EventArgs e)
        {
            string comboBoxSimbolo = cboSimbolo.Text;
            string simbolo = comboBoxSimbolo[0].ToString();
            Jogo.Jogar(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador, Convert.ToInt32(txtPosicao.Text), simbolo);
            updateBoardState();
        }

        private void btnMoverTras_Click(object sender, EventArgs e)
        {
            Jogo.Jogar(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador, Convert.ToInt32(txtPosicao.Text));
            updateBoardState();
        }

        /************************************************************************************************
         * 
         *                                      AUTOMATION 
         * 
         * **********************************************************************************************/

        private void jogar()
        {
            string response;
            int rodada = 1;
            int pos = 0;

            updateMao();

            while (rodada < 4 && !jogoTerminado)
            {
                updateBoardState();
                Application.DoEvents();

                if(strategy.twoTurnPlay > 2)
                    strategy.twoTurnPlay = 0;

                if (strategy.twoTurnPlay == 0)
                {
                    strategy.definePlay(rodada);
                    pos = strategy.myPos.First();
                }
                else if(strategy.twoTurnPlay == 1)
                {
                    strategy.play = strategy.firstCard;
                    pos = strategy.myPos.First();
                    strategy.twoTurnPlay++;
                }
                else
                {
                    strategy.play = strategy.secondCard;
                    pos = strategy.posNextPlay;
                    strategy.twoTurnPlay++;
                }

                if (strategy.forward)
                {
                    // Play forward
                    response = Jogo.Jogar(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador, pos, strategy.play);
                    rodada++;                
                }
                else {
                    // Play backwards
                    response = Jogo.Jogar(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador, strategy.backwards.First());
                   
                    if (response.Contains("ERRO"))
                    {
                        // Skip turn
                        Jogo.Jogar(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador);
                    }
                    rodada++;
                }

                updateMao();
            }

            tmrVerificarVez.Enabled = true;
        }

        private void tmrVerificarVez_Tick(object sender, EventArgs e)
        {
            // Only plays if the game has started
            if (jogoIniciado)
            {
                updateBoardState();

                if (vez == Convert.ToInt32(loginForm.idJogador))
                {
                    tmrVerificarVez.Enabled = false;
                    jogar();
                }
            }
        }

    }
}

        
