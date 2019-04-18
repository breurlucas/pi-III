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
    public partial class Form4 : Form
    {

        public string idPartida;
        public string idJogador;
        public string senhaJogador;
        public string corJogador;
        public string senhaPartida;

        Form2 formDois;
        public Form4(Form2 form2)
        {
            InitializeComponent();
            formDois = form2;

            senhaPartida = form2.senhaPartida;
            lblIdPartida.Text = form2.idPartida;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string[] tes = lblIdPartida.Text.Split('\n');
            lblIdPartida.Text = tes[1].ToString();
            idPartida = lblIdPartida.Text;
            if (txtSenhaJogador.Text != "")
            {
                idJogador = txtNome.Text;
                senhaJogador = txtSenhaJogador.Text;

                string jogadores = Jogo.ListarJogadores(Convert.ToInt32(lblIdPartida.Text));
                string[] arrayJog = jogadores.Split('\n');
                string[] arrayColors = jogadores.Split('\r');
                string[] arrayJ = jogadores.Split('\r');
                
                int tamanhoArrayCores = arrayColors.Length;
                for (int i =0; i<tamanhoArrayCores; i++)
                {
                        string[] newArray = arrayJ[i].Split(',');
                        string teste = newArray[0].Replace("\n", "");
                        if (txtNome.Text == teste)
                        {
                            corJogador = newArray[2];
                        }
                }
                Form3 novoForm;
                novoForm = new Form3(this);
                novoForm.Show();
                this.Close();
            }
            else
            {
                string retornoEntrar = Jogo.EntrarPartida(Convert.ToInt32(lblIdPartida.Text), txtNomeJogador.Text, senhaPartida);
                string[] array = retornoEntrar.Split(',');

                idJogador = array[0];
                senhaJogador = array[1];
                corJogador = array[2];
                
                Form3 novoForm;
                novoForm = new Form3(this);
                novoForm.Show();
                this.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
