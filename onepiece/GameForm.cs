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
        Tabuleiro tabuleiro;
        PictureBox[] mapTiles;
        PictureBox tile;
        PictureBox unit;
        Pirate pirate;
        // Keeps track of the number of pirates in each tile
        int[] occupation;
        // Stores the players (id and color) at the start of the game
        Dictionary<string, Color> colors;
        int idPartida;

        int indexTEMP;
     
        LoginForm loginForm;

        // Initializes the game form
        public GameForm(LoginForm form)
        {
            loginForm = form;
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            //  Instancia novo tabuleiro
            tabuleiro = new Tabuleiro();

            // Takes over the variables from the Login Form
            idPartida = Convert.ToInt32(loginForm.idPartida);
            txtIdJogador.Text = loginForm.idJogador;
            txtSenhaJogador.Text = loginForm.senhaJogador;
            txtCorJogador.Text = loginForm.corJogador;

            cboSimbolo.Items.Add("");
            cboSimbolo.Items.Add("Esqueleto");
            cboSimbolo.Items.Add("Chave");
            cboSimbolo.Items.Add("Garrafa");
            cboSimbolo.Items.Add("Pistola");
            cboSimbolo.Items.Add("Tricórnio");
            cboSimbolo.Items.Add("Faca");

            // Automation
            indexTEMP = 0;

            tmrJogarFrente.Enabled = true;
            tmrJogarFrente.Interval = 4000;
        }
        
        /* DEV Initializes in spectator mode */
        public GameForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            //  Instancia novo tabuleiro
            idPartida = 139;
            tabuleiro = new Tabuleiro();
            exibirTabuleiro();
        }



        // Method that builds a dictionary for the players (id and color)
        private void definirJogadores()
        {
            string req = Jogo.ListarJogadores(idPartida);
            req = req.Replace("\n", "");
            string[] players = req.Split('\r', ',');

            string p1 = "player id 1";
            string p2 = "player id 2";
            string p3 = "player id 3";
            string p4 = "player id 4";
            string p5 = "player id 5";

            for (int i = 0; i < players.Length - 1; i += 3)
            {
                switch (i)
                {
                    case 0:
                        p1 = players[i];
                        break;
                    case 3:
                        p2 = players[i];
                        break;
                    case 6:
                        p3 = players[i];
                        break;
                    case 9:
                        p4 = players[i];
                        break;
                    case 12:
                        p5 = players[i];
                        break;
                }
            }

            // Colors are always distributed in the same order
            colors = new Dictionary<string, Color>
                {
                    { p1, Color.Red },
                    { p2, Color.DarkGreen },
                    { p3, Color.Yellow },
                    { p4, Color.Blue },
                    { p5, Color.Brown },
                };
        }

        private void exibirTabuleiro()
        {


            //  Constructing the map tiles vector. Consists of the 36 different pictureboxes the tiles are drawn into
            mapTiles = new PictureBox[36];

            /*  Tile placement as children from the Map Background. Tile background also turns transparent using this method (instead of inheriting
                the parent control background). */
            double startingWidthTiles = 0.053;
            double spacingTiles = 0.086;
            double widthPercentage = startingWidthTiles;
            double heightPercentage;
            for (int i = 0; i < mapTiles.Length; i++)
            {
                tile = new PictureBox();
                tile.Size = new Size(35, 35);
                tile.BackColor = Color.Transparent;
                picMapBackground.Controls.Add(tile);
                tile.Tag = "tile";
                tile.BringToFront();
                mapTiles[i] = tile;

                if (i < 11)
                    heightPercentage = 0.79;

                else if (i > 11 && i < 23)
                    heightPercentage = 0.47;

                else
                    heightPercentage = 0.15;

                if (i == 11)
                {
                    widthPercentage = startingWidthTiles + 10 * spacingTiles;
                    mapTiles[i].Location = new Point(Convert.ToInt32(picMapBackground.Width * widthPercentage),
                        Convert.ToInt32(picMapBackground.Height * 0.63));

                }
                else if (i == 23)
                {
                    widthPercentage = startingWidthTiles;
                    mapTiles[i].Location = new Point(Convert.ToInt32(picMapBackground.Width * startingWidthTiles),
                        Convert.ToInt32(picMapBackground.Height * 0.31));
                }
                else
                {
                    mapTiles[i].Location = new Point(Convert.ToInt32(picMapBackground.Width * widthPercentage),
                            Convert.ToInt32(picMapBackground.Height * heightPercentage));

                    if (i > 11 && i < 23)
                        //  Starts from the right
                        widthPercentage -= spacingTiles;
                    else
                        widthPercentage += spacingTiles;
                }
            }

            //  Requests the server the blueprint of the map
            string mapBlueprint = Jogo.ExibirTabuleiro(idPartida);
            //  Builds the map using tiles based on the blueprint requested from the server
            tabuleiro.construir(mapTiles, mapBlueprint);
        }

        private void UpdateMap() {

            //  Clear units
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

            string req = Jogo.VerificarVez(idPartida);
            txtVerificarVez.Text = req;

            //  Replace the 'next line' characters from the string with blanks
            req = req.Replace("\n", "");

            /*  Split the string at the '\r' and ',' characters so that we're left with an array of strings
                Every three items make up a line POSITION / PLAYER / NR PIRATES
                The first line defines whose turn it is and how many plays he has left.
                The other lines define the positions of the pirates. */
            string[] estadoTabuleiro = req.Split('\r', ',');

            //  Instatiates new occupation array
            occupation = new int[36];

            //  Last input of estadoTabuleiro is empty
            for (int i = 3; i < estadoTabuleiro.Length - 1; i += 3)
            {
                int position, repeat;
                string player;
                Color color;

                position = Convert.ToInt32(estadoTabuleiro[i]);

                repeat = Convert.ToInt32(estadoTabuleiro[i + 2]);

                //player = Form4.idJogador;
                player = estadoTabuleiro[i + 1];
                color = colors[player];
                //color = Color.FromName(ConvertColor(txtCorJogador.Text));

                if (position != 0)
                    drawUnit(position, color, repeat);
            }
            definirJogadores();
            exibirTabuleiro();

        }

        private string ConvertColor(string color)
        {
            switch (color.Substring(0, 4))
            {
                case "Amar":
                    return "Yellow";
                case "Verm":
                    return "Red";
                case "Azul":
                    return "Blue";
                case "Verd":
                    return "Green";
                case "Marr":
                    return "Brown";
                default:
                    return "Pink";
            }
        }

        private void drawUnit(int position, Color color, int repeat)
        {
            int x, y;
            x = mapTiles[position - 1].Location.X;
            y = mapTiles[position - 1].Location.Y;

            //  x and y offsets based on pic tiles size
            switch (occupation[position])
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
                occupation[position] += 1;
                drawUnit(position, color, 0);
            }
            else if (repeat == 3)
            {
                occupation[position] += 1;
                drawUnit(position, color, 2);
            }
            else
            {
                occupation[position] += 1;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string iniciarPartida = Jogo.IniciarPartida(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador);
            if (iniciarPartida.Contains("Erro")){
                MessageBox.Show(iniciarPartida);
            }
            else
            {
                definirJogadores();
                exibirTabuleiro();
            }
        }

        private void btnExibirMao_Click(object sender, EventArgs e)
        {
            txtMao.Text = Jogo.ConsultarMao(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador);
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            txtVerificarVez.Text = Jogo.VerificarVez(idPartida);
            if (!txtVerificarVez.Text.Contains("Erro")) { 
                definirJogadores();
                exibirTabuleiro();
                UpdateMap();
            }
            
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            txtHistorico.Text = Jogo.ExibirHistorico(Convert.ToInt32(loginForm.idPartida));
        }

        private void btnPularVez_Click(object sender, EventArgs e)
        {
            Jogo.Jogar(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador);
            UpdateMap();
        }

        private void btnMoverFrente_Click(object sender, EventArgs e)
        {
            string comboBoxSimbolo = cboSimbolo.Text;
            string simbolo  = comboBoxSimbolo[0].ToString();
            Jogo.Jogar(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador, Convert.ToInt32(txtPosicao.Text), simbolo);
            UpdateMap();
        }

        private void btnMoverTras_Click(object sender, EventArgs e)
        {
            Jogo.Jogar(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador, Convert.ToInt32(txtPosicao.Text));
            UpdateMap();
        }

        private void tmrJogarFrente_Tick(object sender, EventArgs e)
        {
            string vezAtual = Jogo.VerificarVez(Convert.ToInt32(loginForm.idPartida));
            if (!vezAtual.Contains("Erro"))
            {
                        string[] atualVez = vezAtual.Split(',');
                        string vez = atualVez[1];

                        string[] rodada = atualVez[2].Split('\r');
                        int rodadaAtual = Convert.ToInt32(rodada[0]);

            
                        string carta = Jogo.ConsultarMao(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador);
                        string[] mao = carta.Split(',');
            
                        if (vez == loginForm.idJogador && rodadaAtual < 4 )
                        {
                
                            string testando = Jogo.Jogar(Convert.ToInt32(loginForm.idJogador), loginForm.senhaJogador, 0, mao[0].ToString());
               
                        }
                        definirJogadores();
                        exibirTabuleiro();
                        UpdateMap();
            
                        indexTEMP++;

            }
        }
    }
}
