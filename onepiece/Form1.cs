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
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            
            //string filtroPartidas = "T";
            /*
            if (cboListarPartidas = "Todas")
            {
                txtListarPartidas.Text = Jogo.ListarPartidas("T"); 
            }
            else if (cboListarPartidas = "Aberta")
            {
                txtListarPartidas.Text = Jogo.ListarPartidas("A"); 
            }
            else if (cboListarPartidas = "Jogando")
            {
                txtListarPartidas.Text = Jogo.ListarPartidas("J"); 
            }
            else
            {
                txtListarPartidas.Text = Jogo.ListarPartidas("E"); 
            }
            */

            txtListarPartidas.Text = Jogo.ListarPartidas("T");            

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
            if (txtNomeJogador.Text != "")
                txtIdJogador.Text = Jogo.EntrarPartida(Convert.ToInt32(txtIdJogador.Text), txtNomeJogador.Text, txtSenhaJogador.Text);
            else
                MessageBox.Show("Nome inválido :/");
        }
    }
}
