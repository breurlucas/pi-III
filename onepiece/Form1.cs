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
        Tabuleiro tabuleiro;

        public Form1()
        {
            InitializeComponent();

            // Instancia novo tabuleiro
            tabuleiro = new Tabuleiro();

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
            // Declaring the map tiles vector. Consists of the 36 different pictureboxes the tiles are drawn into
            PictureBox[] mapTiles =
            {
                picTile1, picTile2, picTile3, picTile4, picTile5, picTile6, picTile7, picTile8, picTile9,
                picTile10, picTile11, picTile12, picTile13, picTile14, picTile15, picTile16, picTile17,
                picTile18, picTile19, picTile20, picTile21, picTile22, picTile23, picTile24, picTile25,
                picTile26, picTile27, picTile28, picTile29, picTile30, picTile31, picTile32, picTile33,
                picTile34, picTile35, picTile36
            };

            if (txtId.Text != "")
            {
                // Requests the server the blueprint of the map
                string mapBlueprint = Jogo.ExibirTabuleiro(Convert.ToInt32(txtId.Text));
                // Shows the map blueprint as text
                txtExibirTabuleiro.Text = mapBlueprint;
                // Builds the map using tiles based on the blueprint requested from the server
                tabuleiro.construir(mapTiles, mapBlueprint);
            }
            else
            {
                MessageBox.Show("Id inválido! :(");
            }
        }
    }
}
