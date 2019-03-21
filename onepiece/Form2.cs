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

        public Form2()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            // Instancia novo tabuleiro
            tabuleiro = new Tabuleiro();

            // Constructing the map tiles vector. Consists of the 36 different pictureboxes the tiles are drawn into
            mapTiles = new PictureBox[]
            {
                picTile1, picTile2, picTile3, picTile4, picTile5, picTile6, picTile7, picTile8, picTile9,
                picTile10, picTile11, picTile12, picTile13, picTile14, picTile15, picTile16, picTile17,
                picTile18, picTile19, picTile20, picTile21, picTile22, picTile23, picTile24, picTile25,
                picTile26, picTile27, picTile28, picTile29, picTile30, picTile31, picTile32, picTile33,
                picTile34, picTile35, picTile36
            };
        }

        private void btnExibirTabuleiro_Click(object sender, EventArgs e)
        {
            // Requests the server the blueprint of the map
            string mapBlueprint = Jogo.ExibirTabuleiro(2);
            // Builds the map using tiles based on the blueprint requested from the server
            tabuleiro.construir(mapTiles, mapBlueprint);

            // Tile placement as children from the Map Background. Tile background also turns transparent using this method (instead of inheriting
            // the parent control background).
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
                    mapTiles[i].Location = new Point(Convert.ToInt32(picMapBackground.Width * (spacingTiles * 10 + startingWidthTiles)), Convert.ToInt32(picMapBackground.Height * 0.63));
                    widthPercentage = startingWidthTiles;
                }
                else if (i == 23)
                {
                    mapTiles[i].Location = new Point(Convert.ToInt32(picMapBackground.Width * startingWidthTiles), Convert.ToInt32(picMapBackground.Height * 0.31));
                    widthPercentage = startingWidthTiles;
                }
                else
                {
                    mapTiles[i].Location = new Point(Convert.ToInt32(picMapBackground.Width * widthPercentage), Convert.ToInt32(picMapBackground.Height * heightPercentage));
                    widthPercentage += spacingTiles;
                }
            }
        }

        private void btnEstadoTabuleiro_Click(object sender, EventArgs e)
        {
            //string req = Jogo.VerificarVez(2);

            //// Replace the 'next line' characters from the string with blanks
            //req = req.Replace("\n", "");
            //// Split the string at the '\r' characters so that we're left with an array of strings
            //// Every three items make up a line POSITION / PLAYER / NR PIRATES
            //// The first line defines whose turn it is and how many plays he has left.
            //// The other lines define the positions of the pirates.
            //string[] estadoTabuleiro = req.Split('\r',',');

            //string[] mockInput = { "1", "1", "3", "4", "1", "1", "8", "1", "1" };

            // Position input is sent to the mapTiles[]

            // Number of pirates and color depending on player

            int x = mapTiles[0].Location.X - 15;
            int y = mapTiles[0].Location.Y + 30;
            for (int i = 0; i < 3; i++)
            {
                drawUnit(x, y);
                x += 20;
            }

            x = mapTiles[1].Location.X - 15;
            y = mapTiles[1].Location.Y + 30;
            for (int i = 0; i < 2; i++)
            {
                drawUnit(x, y);
                x += 20;
            }

            x = mapTiles[2].Location.X - 15;
            y = mapTiles[2].Location.Y + 30;
            drawUnit(x, y);

        }

        private void drawUnit(int x, int y)
        {
            unit = new PictureBox();
            unit.Size = new Size(15, 15);
            unit.BackColor = Color.DarkRed;
            unit.Location = new Point(x, y);
            picMapBackground.Controls.Add(unit);
            unit.BringToFront();
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
