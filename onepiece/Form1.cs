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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            // Initialize match filter combobox
            cmbFiltrarPartidas.Items.Add("Todas");
            cmbFiltrarPartidas.Items.Add("Aberta");
            cmbFiltrarPartidas.Items.Add("Jogando");
            cmbFiltrarPartidas.Items.Add("Encerrada");
            cmbFiltrarPartidas.SelectedIndex = 0;


            // Making the tiles invisible the map construction request is made
            //for (int i = 0; i < mapTiles.Length; i++)
            //{
            //    mapTiles[i].Visible = false;
            //}
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            char filtroPartidas = cmbFiltrarPartidas.SelectedItem.ToString()[0];
            txtListarPartidas.Text = Jogo.ListarPartidas(filtroPartidas.ToString());
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            Jogo.CriarPartida(txtNomePartida.Text, txtSenhaPartida.Text);
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {       
            if (txtId.Text != "")
                txtListarJogadores.Text = Jogo.ListarJogadores(Convert.ToInt32(txtId.Text));
            else
                MessageBox.Show("Id inválido! :(");
        }

        private void btnExibirTabuleiro_Click(object sender, EventArgs e)
        {
            // Declare the tiles vector
            PictureBox[] mapTiles =
            {
                picTile1, picTile2, picTile3, picTile4, picTile5, picTile6, picTile7, picTile8, picTile9,
                picTile10, picTile11, picTile12, picTile13, picTile14, picTile15, picTile16, picTile17,
                picTile18, picTile19, picTile20, picTile21, picTile22, picTile23, picTile24, picTile25,
                picTile26, picTile27, picTile28, picTile29, picTile30, picTile31, picTile32, picTile33,
                picTile34, picTile35, picTile36
            };

            string tabuleiro = Jogo.ExibirTabuleiro(Convert.ToInt32(txtId.Text));
            txtExibirTabuleiro.Text = tabuleiro;
       
            tabuleiro = tabuleiro.Replace("\n","");
            string[] mapTilesCode = tabuleiro.Split('\r');

            // Make the tiles transparent

            //picMapBackground.Controls.Add(picTile1);
            //picTile1.Location = new Point(Convert.ToInt32(picMapBackground.Width * 0.15), Convert.ToInt32(picMapBackground.Height * 0.78));
            //picTile1.BackColor = Color.Transparent;

            char tile;
            for (int i = 1; i < 37; i++) {

                if (i < 10)
                    tile = mapTilesCode[i][2];
                else
                    tile = mapTilesCode[i][3];

                switch (tile) { 
   
                case 'E':
                        mapTiles[i-1].Image = Properties.Resources.cardSkull;
                        break;
                case 'T':
                        mapTiles[i-1].Image = Properties.Resources.piratehat;
                        break;
                case 'P':
                        mapTiles[i-1].Image = Properties.Resources.cardPistol;
                        break;
                case 'C':
                        mapTiles[i-1].Image = Properties.Resources.cardKey;
                        break;
                case 'G':
                        mapTiles[i-1].Image = Properties.Resources.cardBottle;
                        break;
                case 'F':
                        mapTiles[i-1].Image = Properties.Resources.cardKnife;
                        break;

                }

                mapTiles[i-1].SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
