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
    public partial class LoginForm : Form
    {

        public string idPartida;
        public string idJogador;
        public string senhaJogador;
        public string corJogador;
        public string senhaPartida;

        LobbyForm lobbyForm;
        public LoginForm(LobbyForm form)
        {
            InitializeComponent();
            lobbyForm = form;

            senhaPartida = lobbyForm.senhaPartida;
            lblIdPartida.Text = lobbyForm.idPartida;

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string[] idPartidaAtual = lblIdPartida.Text.Split('\n');
            lblIdPartida.Text = idPartidaAtual[0].ToString();
            idPartida = lblIdPartida.Text;
            if (txtSenhaJogador.Text != "")
            {
                idJogador = txtNome.Text;
                senhaJogador = txtSenhaJogador.Text;

                string jogadores = Jogo.ListarJogadores(Convert.ToInt32(lblIdPartida.Text));
                if (jogadores.Contains("ERRO"))
                {
                    MessageBox.Show(jogadores);
                }
                else
                {
                
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
                GameForm novoForm;
                novoForm = new GameForm(this);
                novoForm.Show();
                this.Close();
                }
            }
            else
            {
                string retornoEntrar = Jogo.EntrarPartida(Convert.ToInt32(lblIdPartida.Text), txtNomeJogador.Text, senhaPartida);
                if (retornoEntrar.Contains("ERRO"))
                {
                    MessageBox.Show(retornoEntrar);
                }
                else
                {
                    string[] array = retornoEntrar.Split(',');

                    idJogador = array[0];
                    senhaJogador = array[1];
                    corJogador = array[2];

                    GameForm novoForm;
                    novoForm = new GameForm(this);
                    novoForm.Show();
                    this.Close();
                }

            }
        }
       
    }
}
