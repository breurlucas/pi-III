﻿using System;
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

            //wipes the list clear before loading new games
            lista.Items.Clear();
            for (int i = 0; i < listaPartida.Length; i++)
            {
                lista.Items.Add(listaPartida[i]);
            }
            lista.SelectedIndex = 0;
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

                string listaInteira = Jogo.ListarPartidas(filtroPartida);
                string[] listaPartida = listaInteira.Split('\r');

                //wipes the list clear before loading new games
                lista.Items.Clear();
                for (int i = 0; i < listaPartida.Length; i++)
                {
                    lista.Items.Add(listaPartida[i]);
                }
                lista.SelectedIndex = 0;
                txtId.Text = idNovaPartida;
            }
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            string[] idSelected = lista.Text.Split(',');
            if(idSelected[0] != "")
            {
                int id = Convert.ToInt32(idSelected[0]);
            }
               
            if (txtId.Text != "")
            {
                //txtId.Text = id.ToString();
                txtListarJogadores.Text = Jogo.ListarJogadores(Convert.ToInt32(txtId.Text));
            }
            else
            {
                MessageBox.Show("Não há jogadores se não há partida");
            }
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (Int32.TryParse(txtId.Text, out i)&& txtSenhaPartida.Text != "")
            {

                idPartida = txtId.Text;
                senhaPartida = txtSenhaPartida.Text;
                Form4 dialogLogin;
                dialogLogin = new Form4(this);
                dialogLogin.Show();
                
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
