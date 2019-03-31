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
        public string idPartida;
        public string idJogador;
        public string senhaJogador;
        public string corJogador;
        public string senhaPartida;

        public Form2()
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

            string listaInteira = Jogo.ListarPartidas(filtroPartida);
            string[] listaPartida = listaInteira.Split('\r');

            for (int i = 0; i < listaPartida.Length; i++)
            {
                lista.Items.Add(listaPartida[i]);
            }
            lista.SelectedIndex = 0;
            //txtListarPartidas.Text = Jogo.ListarPartidas(filtroPartida);

        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            Jogo.CriarPartida(txtNomePartida.Text, txtSenhaPartida.Text);
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            if(lista.Text != "")
            {
                string[] teste = lista.Text.Split(',');
                int id = Convert.ToInt32(teste[0]);
                txtId.Text = id.ToString();
                txtListarJogadores.Text = Jogo.ListarJogadores(id);
            }
            else
            {
                MessageBox.Show("Não há jogadores se não há partida");
            }
                
           
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (Int32.TryParse(txtId.Text, out i) && txtNomeJogador.Text != "" && txtSenhaPartida.Text != "")
            {

                string retornoEntrar = Jogo.EntrarPartida(Convert.ToInt32(txtId.Text), txtNomeJogador.Text, txtSenhaPartida.Text);
                string[] array = retornoEntrar.Split(',');

                idJogador = array[0];
                senhaJogador = array[1];
                corJogador = array[2];
                idPartida = txtId.Text;
                senhaPartida = txtSenhaPartida.Text;
                
                Form3 novoForm;
                novoForm = new Form3(this);
                novoForm.Show();
                
            }
            else
            {
                MessageBox.Show("Verificar se os dados estão preenchidos corretamente");
            }
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] teste = lista.Text.Split(',');
            txtId.Text = teste[0];
        }
    }
}
