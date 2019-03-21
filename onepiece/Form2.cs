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
    public partial class Form2 : Form
    {
        Tabuleiro tabuleiro;
        PictureBox[] mapTiles;
        PictureBox unit;
        Pirate pirate;
        int[] occupation;
        Dictionary<string, Color> colors;

        public Form2()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            //  Instancia novo tabuleiro
            tabuleiro = new Tabuleiro();

            //  Constructing the map tiles vector. Consists of the 36 different pictureboxes the tiles are drawn into
            mapTiles = new PictureBox[]
            {
                picTile1, picTile2, picTile3, picTile4, picTile5, picTile6, picTile7, picTile8, picTile9,
                picTile10, picTile11, picTile12, picTile13, picTile14, picTile15, picTile16, picTile17,
                picTile18, picTile19, picTile20, picTile21, picTile22, picTile23, picTile24, picTile25,
                picTile26, picTile27, picTile28, picTile29, picTile30, picTile31, picTile32, picTile33,
                picTile34, picTile35, picTile36
            };

            //  Shows the map as soon as the form opens
            exibirTabuleiro();
            // Assigns a color to each player
            definirJogadores();
        }

        private void exibirTabuleiro()
        {
            //  Requests the server the blueprint of the map
            string mapBlueprint = Jogo.ExibirTabuleiro(5);
            //  Builds the map using tiles based on the blueprint requested from the server
            tabuleiro.construir(mapTiles, mapBlueprint);

            /*  Tile placement as children from the Map Background. Tile background also turns transparent using this method (instead of inheriting
                the parent control background). */
            double startingWidthTiles = 0.053;
            double spacingTiles = 0.086;
            double widthPercentage = startingWidthTiles;
            double heightPercentage;
            for(int i = 0; i < mapTiles.Length; i++)
            {
                picMapBackground.Controls.Add(mapTiles[i]);
                mapTiles[i].BackColor = Color.Transparent;

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
        }

        private void definirJogadores()
        {
            //  Builds dictionary for the player colors

            string req = Jogo.ListarJogadores(5);
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
        
            colors = new Dictionary<string, Color>
                {
                    { p1, Color.DarkRed },
                    { p2, Color.DarkGreen },
                    { p3, Color.LightGoldenrodYellow },
                    { p4, Color.DarkBlue },
                    { p5, Color.SaddleBrown },
                };
        }

        private void btnUpdateMap_Click(object sender, EventArgs e)
        {
            string req = Jogo.VerificarVez(5);
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

                player = estadoTabuleiro[i + 1];
                color = colors[player];

                if (position != 0)
                    drawUnit(position, color, repeat);
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

        //private void picMapBackground_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    int x = mapTiles[1].Location.X + 20;
        //    int y = mapTiles[1].Location.Y;
        //    //pirate.draw(g, x, y);
        //    //Pen p = new Pen(Color.Red);
        //    SolidBrush sb = new SolidBrush(Color.Red);
        //    //g.DrawEllipse(p, x, y, 10, 10);
        //    g.FillEllipse(sb, x, y, 15, 15);
        //}
    }
}
