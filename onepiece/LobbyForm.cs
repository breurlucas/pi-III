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
    public partial class LobbyForm : Form
    {

        public string idPartida;
        public string senhaPartida;

        public LobbyForm()
        {
            InitializeComponent();

            cmbFiltrarPartidas.Items.Add("Todas");
            cmbFiltrarPartidas.Items.Add("Aberta");
            cmbFiltrarPartidas.Items.Add("Jogando");
            cmbFiltrarPartidas.Items.Add("Encerrada");
            cmbFiltrarPartidas.SelectedIndex = 0;

            lblVersao.Text = Jogo.Versao;

            dgvPartida.DataSource = Partida.Listar();
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string comboBoxFiltro = cmbFiltrarPartidas.Text;
            string filtroPartida = comboBoxFiltro[0].ToString();

            dgvPartida.DataSource = Partida.Listar(filtroPartida);
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string idNovaPartida = Jogo.CriarPartida(txtNomePartida.Text, txtSenhaPartida.Text);
            if (idNovaPartida.Contains("ERRO"))
            {
                MessageBox.Show(idNovaPartida);
            }
            else
            {
                string comboBoxFiltro = cmbFiltrarPartidas.Text;
                string filtroPartida = comboBoxFiltro[0].ToString();

                dgvPartida.DataSource = Partida.Listar(filtroPartida);
                txtIdPartida.Text = idNovaPartida;
            }
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            if (txtIdPartida.Text != "")
            {
                dgvJogadores.DataSource = Jogador.Listar(txtIdPartida.Text);
            }
            else
            {
                MessageBox.Show("Não há jogadores se não há partida");
            }
        }

        private void dgvPartida_Click(object sender, EventArgs e)
        {
            Partida p = (Partida)dgvPartida.SelectedRows[0].DataBoundItem;
            dgvJogadores.DataSource = Jogador.Listar(p.id);
            dgvJogadores.Columns[0].Visible = false;
            dgvJogadores.Columns[1].Visible = false;
            dgvJogadores.Columns[2].Visible = false;
            dgvJogadores.Columns[3].HeaderText = "Nome";
            txtIdPartida.Text = p.id;
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (Int32.TryParse(txtIdPartida.Text, out i)&& txtSenhaPartida.Text != "")
            {

                idPartida = txtIdPartida.Text;
                senhaPartida = txtSenhaPartida.Text;
                LoginForm dialogLogin;
                dialogLogin = new LoginForm(this);
                dialogLogin.Show();
                
            }
            else
            {
                MessageBox.Show("Verificar se os dados estão preenchidos corretamente");
            }
        }

        /* DEV Initializes in spectator mode */
        private void btnAssistir_Click(object sender, EventArgs e)
        {

            GameForm novoForm;
            novoForm = new GameForm();
            novoForm.Show();
        }
    }
}
