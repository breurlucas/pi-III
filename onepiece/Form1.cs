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

            cmbFiltrarPartidas.Items.Add("Todas");
            cmbFiltrarPartidas.Items.Add("Aberta");
            cmbFiltrarPartidas.Items.Add("Jogando");
            cmbFiltrarPartidas.Items.Add("Encerrada");
            cmbFiltrarPartidas.SelectedIndex = 0;
            
        }
       
        private void btnListarPartidas_Click(object sender, EventArgs e)
        {

            string comboBoxFiltro = cmbFiltrarPartidas.Text;
            string filtroPartida = comboBoxFiltro[0].ToString();

            txtListarPartidas.Text = Jogo.ListarPartidas(filtroPartida);            

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

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(Int32.TryParse(txtId.Text, out i) && txtNomeJogador.Text != "" && txtSenhaPartida.Text != "")
            {
                Jogo.EntrarPartida(Convert.ToInt32(txtId.Text), txtNomeJogador.Text, txtSenhaPartida.Text);
            }
            else
            {
                MessageBox.Show("Verificar se os dados estão preenchidos corretamente");
            }
            
        }

        private void btnExibirHistorico_Click(object sender, EventArgs e)
        {
            txtHistorico.Text = Jogo.ExibirHistorico(Convert.ToInt32(txtId.Text));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenhaPartida_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomePartida_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbFiltrarPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtListarPartidas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
