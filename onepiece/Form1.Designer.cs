namespace onepiece
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.txtListarPartidas = new System.Windows.Forms.TextBox();
            this.cboListarPartidas = new System.Windows.Forms.ComboBox();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.txtListarJogadores = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExibirHistorico = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.txtPosicao = new System.Windows.Forms.TextBox();
            this.cboSimbolo = new System.Windows.Forms.ComboBox();
            this.btnJogarFrente = new System.Windows.Forms.Button();
            this.btnJogarTras = new System.Windows.Forms.Button();
            this.btnPularJogada = new System.Windows.Forms.Button();
            this.btnExibirMao = new System.Windows.Forms.Button();
            this.txtExibirMao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(12, 12);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(103, 23);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // txtListarPartidas
            // 
            this.txtListarPartidas.Location = new System.Drawing.Point(12, 41);
            this.txtListarPartidas.Multiline = true;
            this.txtListarPartidas.Name = "txtListarPartidas";
            this.txtListarPartidas.ReadOnly = true;
            this.txtListarPartidas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListarPartidas.Size = new System.Drawing.Size(193, 165);
            this.txtListarPartidas.TabIndex = 1;
            // 
            // cboListarPartidas
            // 
            this.cboListarPartidas.FormattingEnabled = true;
            this.cboListarPartidas.Location = new System.Drawing.Point(121, 14);
            this.cboListarPartidas.Name = "cboListarPartidas";
            this.cboListarPartidas.Size = new System.Drawing.Size(84, 21);
            this.cboListarPartidas.TabIndex = 2;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(12, 238);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(193, 20);
            this.txtNomePartida.TabIndex = 3;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(12, 277);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(112, 20);
            this.txtSenhaPartida.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Partida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha Partida";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(130, 277);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(75, 23);
            this.btnCriarPartida.TabIndex = 7;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(229, 12);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(117, 23);
            this.btnListarJogadores.TabIndex = 8;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // txtListarJogadores
            // 
            this.txtListarJogadores.Location = new System.Drawing.Point(229, 41);
            this.txtListarJogadores.Multiline = true;
            this.txtListarJogadores.Name = "txtListarJogadores";
            this.txtListarJogadores.ReadOnly = true;
            this.txtListarJogadores.Size = new System.Drawing.Size(193, 165);
            this.txtListarJogadores.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(374, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(48, 20);
            this.txtId.TabIndex = 10;
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(229, 238);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(193, 20);
            this.txtNomeJogador.TabIndex = 11;
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(229, 277);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(94, 23);
            this.btnEntrarPartida.TabIndex = 12;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(229, 325);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(88, 20);
            this.txtIdJogador.TabIndex = 13;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(336, 325);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(86, 20);
            this.txtSenhaJogador.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(229, 374);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(75, 20);
            this.textBox6.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nome do Jogador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Id do Jogador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Senha do Jogador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cor do Jogador";
            // 
            // btnExibirHistorico
            // 
            this.btnExibirHistorico.Location = new System.Drawing.Point(12, 311);
            this.btnExibirHistorico.Name = "btnExibirHistorico";
            this.btnExibirHistorico.Size = new System.Drawing.Size(91, 23);
            this.btnExibirHistorico.TabIndex = 21;
            this.btnExibirHistorico.Text = "Exibir Histórico";
            this.btnExibirHistorico.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 340);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(193, 117);
            this.textBox1.TabIndex = 22;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(447, 15);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(193, 23);
            this.btnIniciarPartida.TabIndex = 23;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            // 
            // txtPosicao
            // 
            this.txtPosicao.Location = new System.Drawing.Point(447, 77);
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.Size = new System.Drawing.Size(84, 20);
            this.txtPosicao.TabIndex = 24;
            // 
            // cboSimbolo
            // 
            this.cboSimbolo.FormattingEnabled = true;
            this.cboSimbolo.Location = new System.Drawing.Point(556, 76);
            this.cboSimbolo.Name = "cboSimbolo";
            this.cboSimbolo.Size = new System.Drawing.Size(84, 21);
            this.cboSimbolo.TabIndex = 25;
            // 
            // btnJogarFrente
            // 
            this.btnJogarFrente.Location = new System.Drawing.Point(447, 103);
            this.btnJogarFrente.Name = "btnJogarFrente";
            this.btnJogarFrente.Size = new System.Drawing.Size(84, 48);
            this.btnJogarFrente.TabIndex = 26;
            this.btnJogarFrente.Text = "Jogar Para Frente";
            this.btnJogarFrente.UseVisualStyleBackColor = true;
            // 
            // btnJogarTras
            // 
            this.btnJogarTras.Location = new System.Drawing.Point(556, 103);
            this.btnJogarTras.Name = "btnJogarTras";
            this.btnJogarTras.Size = new System.Drawing.Size(84, 48);
            this.btnJogarTras.TabIndex = 27;
            this.btnJogarTras.Text = "Jogar Para Frente";
            this.btnJogarTras.UseVisualStyleBackColor = true;
            // 
            // btnPularJogada
            // 
            this.btnPularJogada.Location = new System.Drawing.Point(447, 172);
            this.btnPularJogada.Name = "btnPularJogada";
            this.btnPularJogada.Size = new System.Drawing.Size(193, 34);
            this.btnPularJogada.TabIndex = 28;
            this.btnPularJogada.Text = "Pular Jogada";
            this.btnPularJogada.UseVisualStyleBackColor = true;
            // 
            // btnExibirMao
            // 
            this.btnExibirMao.Location = new System.Drawing.Point(448, 233);
            this.btnExibirMao.Name = "btnExibirMao";
            this.btnExibirMao.Size = new System.Drawing.Size(192, 36);
            this.btnExibirMao.TabIndex = 29;
            this.btnExibirMao.Text = "Exibir Mão";
            this.btnExibirMao.UseVisualStyleBackColor = true;
            // 
            // txtExibirMao
            // 
            this.txtExibirMao.Location = new System.Drawing.Point(448, 275);
            this.txtExibirMao.Multiline = true;
            this.txtExibirMao.Name = "txtExibirMao";
            this.txtExibirMao.Size = new System.Drawing.Size(192, 96);
            this.txtExibirMao.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Posição";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Símbolo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1015, 469);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtExibirMao);
            this.Controls.Add(this.btnExibirMao);
            this.Controls.Add(this.btnPularJogada);
            this.Controls.Add(this.btnJogarTras);
            this.Controls.Add(this.btnJogarFrente);
            this.Controls.Add(this.cboSimbolo);
            this.Controls.Add(this.txtPosicao);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExibirHistorico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtListarJogadores);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.cboListarPartidas);
            this.Controls.Add(this.txtListarPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.Name = "Form1";
            this.Text = "One Piece Of Cartagena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.TextBox txtListarPartidas;
        private System.Windows.Forms.ComboBox cboListarPartidas;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.TextBox txtListarJogadores;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExibirHistorico;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.TextBox txtPosicao;
        private System.Windows.Forms.ComboBox cboSimbolo;
        private System.Windows.Forms.Button btnJogarFrente;
        private System.Windows.Forms.Button btnJogarTras;
        private System.Windows.Forms.Button btnPularJogada;
        private System.Windows.Forms.Button btnExibirMao;
        private System.Windows.Forms.TextBox txtExibirMao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

