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

            // Does not allow resizing or maximizing of the form
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
            if (txtIdPartida.Text != "")
                txtListarJogadores.Text = Jogo.ListarJogadores(Convert.ToInt32(txtIdPartida.Text));
            else
                MessageBox.Show("Preencha o id da partida.");
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            if (txtIdPartida.Text != "" && txtNomeJogador.Text != "" && txtSenhaPartida.Text != "")
            {
                string x = Jogo.EntrarPartida(Convert.ToInt32(txtIdPartida.Text), txtNomeJogador.Text, txtSenhaPartida.Text);
                string[] player = x.Split('\r', ',');
                txtIdJogador.Text = player[0];
                txtSenhaJogador.Text = player[1];
            }
            else
            {
                MessageBox.Show("Para entrar no jogo preencha o id da partida, a senha da partida e o nome do jogador.");
            }
        }

        private void btnExibirHistorico_Click(object sender, EventArgs e)
        {
            txtHistorico.Text = Jogo.ExibirHistorico(Convert.ToInt32(txtIdPartida.Text));
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            Jogo.IniciarPartida(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text);
        }

        private void btnEntrarJogo_Click(object sender, EventArgs e)
        {
            Form2 novoForm;
            novoForm = new Form2();
            novoForm.ShowDialog();
        }
    }
}
