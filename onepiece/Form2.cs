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

        private void picMapBackground_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = mapTiles[1].Location.X;
            int y = mapTiles[1].Location.Y;
            //pirate.draw(g, x, y);
            //Pen p = new Pen(Color.Red);
            SolidBrush sb = new SolidBrush(Color.Red);
            //g.DrawEllipse(p, x, y, 10, 10);
            g.FillEllipse(sb, x, y, 10, 10);
        }
    }
}
