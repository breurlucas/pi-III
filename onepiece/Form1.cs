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

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

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

        private void btnNovoForm_Click(object sender, EventArgs e)
        {
            Form2 novoForm;
            novoForm = new Form2();
            novoForm.ShowDialog();
        }
    }
}
