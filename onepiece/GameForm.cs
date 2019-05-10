using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace onepiece
{
    public partial class GameForm : Form
    {
        LoginForm loginForm;
        Tabuleiro tabuleiro;
        PictureBox[] mapTiles;
        PictureBox unit;
        List<int> myPos;
  
        // Keeps track of the number of pirates in each tile
        int[] occupation;
        // Stores the colors of the players at the start of the game
        Dictionary<string, Color> colors;

        // Jail and Boat pirate count
        List<Jogador> cadeia = new List<Jogador>();
        List<Jogador> barco = new List<Jogador>();
        // Player object
        Jogador jogador;

        // Id of the match being played
        int idPartida;

        // DEV Automation variables
        bool jogoIniciado = false;
        bool jogoTerminado = false;
        int vez, positionForward;
        List<int> backwards = new List<int>();
        List<char> blueprint = new List<char>();
        string[] mao;
        // All cards in hand
        List<string> cartas = new List<string>();
        // Different types of cards
        List<string> cartasNoRep = new List<string>();
        // Symbols not to be played
        List<string> blacklist = new List<string>();
        // The card that is going to be played
        string play;
        Random random;
        
        List<string> jogadoresPartida = new List<string>();
        string[] jogadores;

        string currentPlayer;
        string players;


        /****************
         * 
         * INITIALIZATION
         * 
         ****************/

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
            // Instantiates new myselfPosPirata array
            myPos = new List<int>();

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

            // DEV Automation
            tmrVerificarVez.Interval = 1500;
            tmrVerificarVez.Enabled = false;
            random = new Random();
            positionForward = 0;
            // Clears the blueprint when a new game starts
            blueprint.Clear();
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

        /***************
         * 
         * SETUP 
         * 
         * *************/

    // Method that builds a dictionary for the players (id and color)
    private void definirJogadores()
        {
            string response = Jogo.ListarJogadores(idPartida);

            // *BRANCH: mudancas* Defining players using the 'Jogador' object
            players = response;

            //string replaced = response.Replace('', ' ');
            string[] playersSplit = response.Split('\n');
            foreach(var pl in playersSplit) {
                if(pl != "")
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

            blueprint = tabuleiro.construir(picMapBackground, mapTiles, mapBlueprint);
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
            myPos.Clear();

            //  Last input of estadoTabuleiro is empty
            for (int i = 3; i < estadoTabuleiro.Length - 1; i += 3)
            {
                int position, repeat;
                string player;
               
                position = Convert.ToInt32(estadoTabuleiro[i]);

                repeat = Convert.ToInt32(estadoTabuleiro[i + 2]);

                player = estadoTabuleiro[i + 1];

                // Verify if the game finished
                if(position == 37 && repeat == 6)
                {
                    jogoTerminado = true;
                    tmrVerificarVez.Enabled = false;
                    MessageBox.Show("O jogo terminou!");
                }

                // Populate myselfPosPirata
                if (player == loginForm.idJogador && position != 37)
                {
                    int j = 0;
                    while(j < repeat) {
                        myPos.Add(position);
                        j++;
                    } 
                }
            }

            /*
             * Defines the AUTOMATION parameters
             */

            // Player id of who should play this turn
            vez = Convert.ToInt32(estadoTabuleiro[1]);
            exibirJogadorAtual(vez);

            // Myself: Position of the pirates on the board
            if(!jogoTerminado)
            {
                positionForward = myPos.First();
            }

            drawBoardState(response, estadoTabuleiro);
        }

        private void drawBoardState(string response, string[] estadoTabuleiro) {

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
            
            // DataGridView Coordinate
            int dgvY = 0;

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
                if (position == 0) {
                    cadeia.Add(jogador);  
                } else if(position == 37) {
                    barco.Add(jogador);
                }
                else
                    drawUnit(position, color, repeat);
            }

            dgvCadeia.DataSource = null;
            dgvCadeia.DataSource = cadeia;
            dgvCadeia.Columns[2].Visible = false;
            dgvCadeia.Columns[3].Visible = false;
            dgvCadeia.Columns[4].Visible = false;
            dgvCadeia.ClearSelection();

            dgvBarco.DataSource = null;
            dgvBarco.DataSource = barco;
            dgvBarco.Columns[2].Visible = false;
            dgvBarco.Columns[3].Visible = false;
            dgvBarco.Columns[4].Visible = false;
            dgvBarco.ClearSelection();
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
            cartas.Clear();
            blacklist.Clear();

            // Update cards in hand
            string response = Jogo.ConsultarMao(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador);
            response = response.Replace("\n", "");
            mao = response.Split('\r',',');
        
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
                    cartas.Add(mao[i]);
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
        

        /******************
         * 
         * USER INTERACTION
         * 
         ******************/ 


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string iniciarPartida = Jogo.IniciarPartida(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador);
            if (iniciarPartida.Contains("ERRO")) {
                MessageBox.Show(iniciarPartida);
            }
            else {
                if(!jogoIniciado)
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
            string simbolo  = comboBoxSimbolo[0].ToString();
            Jogo.Jogar(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador, Convert.ToInt32(txtPosicao.Text), simbolo);
            updateBoardState();
        }

        private void btnMoverTras_Click(object sender, EventArgs e)
        {
            Jogo.Jogar(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador, Convert.ToInt32(txtPosicao.Text));
            updateBoardState();
        }

        /************
         * 
         * AUTOMATION
         * 
         ************/

        private void jogar()
        {
            string response;
            int rodada = 1;
            updateMao();
            while (rodada < 4 && !jogoTerminado)
            {
                updateBoardState();
                Application.DoEvents();

                /* Look back and check for good plays backwards */
                lookBack();

                if (cartas.Any() && !backwards.Any())
                {
                    // Play forward
                    strategize();
                    response = Jogo.Jogar(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador, positionForward, play);
                    rodada++;
                } 
                else if (cartas.Count >= 6)
                {
                    // Play forward
                    strategize();
                    response = Jogo.Jogar(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador, positionForward, play);
                    rodada++;
                }
                else
                {
                    // If there are no good options, move the first pirate backwards
                    if (!backwards.Any())
                    {
                        backwards.Add(myPos.Last());
                    }
                    // Play Backwards
                    response = Jogo.Jogar(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador, backwards.First());
                    // Skips the turn if playing backwards fails
                    if(response.Contains("ERRO"))
                    {
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

        /***********
         * 
         * STRATEGY
         * 
         ***********/

        private void lookBack()
        {
            backwards.Clear();

            for (int i = myPos.Count - 1; i > 0; i--)
            {
                int step = 1;
                int range = 4;
                int pos = myPos[i] - 1;

                while (step <= range && pos >= 1)
                {

                    // pos minus one to account for the index 0 of the occupation vector
                    if (occupation[pos - 1] == 1)
                    {
                        break;
                    }
                    else if (occupation[pos - 1] == 2)
                    {
                        backwards.Add(myPos[i]);
                        break;
                    }
                    else
                    {
                        pos -= 1;
                        step++;
                    }
                }
            }
        }

        private string checkFarthestPlay()
        {
            // List with the vacated tiles
            List<char> options = new List<char>();
            List<char> symbols = new List<char>{ 'T','P','C','E','G','F' };
            // Position of the pirate that is going to be played + 1
            int pos = myPos.First() + 1;
            
            // Needs to be '<=' to account for the (-1) of the occupation and blueprint indexes
            for(int i = pos; i <= occupation.Length; i++)
            {
                if(occupation[i - 1] == 0 && isFirstAppearance(symbols, blueprint[i - 1]))
                {
                    options.Add(blueprint[i - 1]);
                    symbols.Remove(blueprint[i - 1]);
                }
            }

            /* Check if there are entries left in the symbols vector, if so, add them at the end of the options vector, 
            these symbols lead directly to the boat */
            if (symbols.Any())
            {
                // Needs to be inverted to make up for the remove action
                for (int i = symbols.Count - 1; i >= 0; i--)
                {
                    options.Add(symbols[i]);
                    symbols.RemoveAt(i);
                }
            }          

            for (int i = options.Count - 1; i > 0; i--)
            {
                for(int j = 0; j < cartas.Count; j++)
                {
                    if(options[i].ToString() == cartas[j])
                    {
                        return cartas[j];
                    }
                } 
            }

            return cartas.First();

        }

        private bool isFirstAppearance(List<char> symbols, char symbol)
        {
            for(int i = 0; i < symbols.Count; i++)
            {
                if(symbol == symbols[i])
                {
                    return true;
                }
            }
            return false;
        }

        private void strategize()
        {
            if (cartas.Count > 1)
                play = checkFarthestPlay();
            else
                play = cartas.First();
        }

    }
}
