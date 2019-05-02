namespace onepiece
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.txtVerificarVez = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.txtCorJogador = new System.Windows.Forms.TextBox();
            this.txtPosicao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSimbolo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPularVez = new System.Windows.Forms.Button();
            this.btnMoverTras = new System.Windows.Forms.Button();
            this.btnMoverFrente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExibirMao = new System.Windows.Forms.Button();
            this.txtMao = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.btnVerificarVez = new System.Windows.Forms.Button();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCadeia = new System.Windows.Forms.DataGridView();
            this.dgvBarco = new System.Windows.Forms.DataGridView();
            this.picMapBackground = new System.Windows.Forms.PictureBox();
            this.tmrVerificarVez = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadeia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMapBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVerificarVez
            // 
            this.txtVerificarVez.BackColor = System.Drawing.Color.Wheat;
            this.txtVerificarVez.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVerificarVez.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerificarVez.Location = new System.Drawing.Point(0, 74);
            this.txtVerificarVez.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVerificarVez.Multiline = true;
            this.txtVerificarVez.Name = "txtVerificarVez";
            this.txtVerificarVez.ReadOnly = true;
            this.txtVerificarVez.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVerificarVez.Size = new System.Drawing.Size(287, 140);
            this.txtVerificarVez.TabIndex = 95;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIdJogador);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSenhaJogador);
            this.groupBox1.Controls.Add(this.txtCorJogador);
            this.groupBox1.Font = new System.Drawing.Font("Primitive", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox1.Location = new System.Drawing.Point(16, 543);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(240, 305);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jogador";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciar.BackgroundImage")));
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIniciar.Font = new System.Drawing.Font("Primitive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Black;
            this.btnIniciar.Location = new System.Drawing.Point(8, 263);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(200, 34);
            this.btnIniciar.TabIndex = 97;
            this.btnIniciar.Text = "Iniciar Partida";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Primitive", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 27);
            this.label5.TabIndex = 100;
            this.label5.Text = "Id do Jogador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Primitive", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 27);
            this.label7.TabIndex = 102;
            this.label7.Text = "Cor do Jogador";
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.BackColor = System.Drawing.Color.Wheat;
            this.txtIdJogador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdJogador.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdJogador.Location = new System.Drawing.Point(13, 74);
            this.txtIdJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(139, 27);
            this.txtIdJogador.TabIndex = 97;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Primitive", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 27);
            this.label6.TabIndex = 101;
            this.label6.Text = "Senha do Jogador";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.BackColor = System.Drawing.Color.Wheat;
            this.txtSenhaJogador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaJogador.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaJogador.Location = new System.Drawing.Point(13, 143);
            this.txtSenhaJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(139, 27);
            this.txtSenhaJogador.TabIndex = 98;
            // 
            // txtCorJogador
            // 
            this.txtCorJogador.BackColor = System.Drawing.Color.Wheat;
            this.txtCorJogador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorJogador.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorJogador.Location = new System.Drawing.Point(13, 212);
            this.txtCorJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorJogador.Name = "txtCorJogador";
            this.txtCorJogador.ReadOnly = true;
            this.txtCorJogador.Size = new System.Drawing.Size(139, 27);
            this.txtCorJogador.TabIndex = 99;
            // 
            // txtPosicao
            // 
            this.txtPosicao.BackColor = System.Drawing.Color.Wheat;
            this.txtPosicao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPosicao.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosicao.Location = new System.Drawing.Point(8, 74);
            this.txtPosicao.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.Size = new System.Drawing.Size(144, 27);
            this.txtPosicao.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Primitive", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 104;
            this.label1.Text = "Posição ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Primitive", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 27);
            this.label2.TabIndex = 105;
            this.label2.Text = "Símbolo";
            // 
            // cboSimbolo
            // 
            this.cboSimbolo.BackColor = System.Drawing.Color.Wheat;
            this.cboSimbolo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSimbolo.FormattingEnabled = true;
            this.cboSimbolo.Location = new System.Drawing.Point(160, 71);
            this.cboSimbolo.Margin = new System.Windows.Forms.Padding(4);
            this.cboSimbolo.Name = "cboSimbolo";
            this.cboSimbolo.Size = new System.Drawing.Size(144, 34);
            this.cboSimbolo.TabIndex = 106;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPosicao);
            this.groupBox2.Controls.Add(this.btnPularVez);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnMoverTras);
            this.groupBox2.Controls.Add(this.cboSimbolo);
            this.groupBox2.Controls.Add(this.btnMoverFrente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Primitive", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox2.Location = new System.Drawing.Point(264, 543);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(317, 263);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jogada";
            // 
            // btnPularVez
            // 
            this.btnPularVez.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPularVez.BackgroundImage")));
            this.btnPularVez.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPularVez.Font = new System.Drawing.Font("Primitive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPularVez.ForeColor = System.Drawing.Color.Black;
            this.btnPularVez.Location = new System.Drawing.Point(60, 204);
            this.btnPularVez.Margin = new System.Windows.Forms.Padding(4);
            this.btnPularVez.Name = "btnPularVez";
            this.btnPularVez.Size = new System.Drawing.Size(200, 34);
            this.btnPularVez.TabIndex = 109;
            this.btnPularVez.Text = "Pular Vez";
            this.btnPularVez.UseVisualStyleBackColor = true;
            this.btnPularVez.Click += new System.EventHandler(this.btnPularVez_Click);
            // 
            // btnMoverTras
            // 
            this.btnMoverTras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoverTras.BackgroundImage")));
            this.btnMoverTras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMoverTras.Font = new System.Drawing.Font("Primitive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverTras.ForeColor = System.Drawing.Color.Black;
            this.btnMoverTras.Location = new System.Drawing.Point(160, 135);
            this.btnMoverTras.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoverTras.Name = "btnMoverTras";
            this.btnMoverTras.Size = new System.Drawing.Size(144, 34);
            this.btnMoverTras.TabIndex = 108;
            this.btnMoverTras.Text = "Para trás";
            this.btnMoverTras.UseVisualStyleBackColor = true;
            this.btnMoverTras.Click += new System.EventHandler(this.btnMoverTras_Click);
            // 
            // btnMoverFrente
            // 
            this.btnMoverFrente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoverFrente.BackgroundImage")));
            this.btnMoverFrente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMoverFrente.Font = new System.Drawing.Font("Primitive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverFrente.ForeColor = System.Drawing.Color.Black;
            this.btnMoverFrente.Location = new System.Drawing.Point(8, 135);
            this.btnMoverFrente.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoverFrente.Name = "btnMoverFrente";
            this.btnMoverFrente.Size = new System.Drawing.Size(144, 34);
            this.btnMoverFrente.TabIndex = 107;
            this.btnMoverFrente.Text = "Para frente";
            this.btnMoverFrente.UseVisualStyleBackColor = true;
            this.btnMoverFrente.Click += new System.EventHandler(this.btnMoverFrente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExibirMao);
            this.groupBox3.Controls.Add(this.txtMao);
            this.groupBox3.Font = new System.Drawing.Font("Primitive", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox3.Location = new System.Drawing.Point(589, 543);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(287, 263);
            this.groupBox3.TabIndex = 111;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cartas";
            // 
            // btnExibirMao
            // 
            this.btnExibirMao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExibirMao.BackgroundImage")));
            this.btnExibirMao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExibirMao.Font = new System.Drawing.Font("Primitive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirMao.ForeColor = System.Drawing.Color.Black;
            this.btnExibirMao.Location = new System.Drawing.Point(8, 222);
            this.btnExibirMao.Margin = new System.Windows.Forms.Padding(4);
            this.btnExibirMao.Name = "btnExibirMao";
            this.btnExibirMao.Size = new System.Drawing.Size(271, 34);
            this.btnExibirMao.TabIndex = 110;
            this.btnExibirMao.Text = "Exibir Mão";
            this.btnExibirMao.UseVisualStyleBackColor = true;
            this.btnExibirMao.Click += new System.EventHandler(this.btnExibirMao_Click);
            // 
            // txtMao
            // 
            this.txtMao.BackColor = System.Drawing.Color.Wheat;
            this.txtMao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMao.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMao.Location = new System.Drawing.Point(1, 74);
            this.txtMao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMao.Multiline = true;
            this.txtMao.Name = "txtMao";
            this.txtMao.ReadOnly = true;
            this.txtMao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMao.Size = new System.Drawing.Size(286, 144);
            this.txtMao.TabIndex = 112;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblCurrentPlayer);
            this.groupBox4.Controls.Add(this.btnVerificarVez);
            this.groupBox4.Controls.Add(this.txtVerificarVez);
            this.groupBox4.Font = new System.Drawing.Font("Primitive", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox4.Location = new System.Drawing.Point(884, 543);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(287, 263);
            this.groupBox4.TabIndex = 112;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vez";
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(96, 31);
            this.lblCurrentPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(0, 27);
            this.lblCurrentPlayer.TabIndex = 114;
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerificarVez.BackgroundImage")));
            this.btnVerificarVez.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVerificarVez.Font = new System.Drawing.Font("Primitive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarVez.ForeColor = System.Drawing.Color.Black;
            this.btnVerificarVez.Location = new System.Drawing.Point(8, 222);
            this.btnVerificarVez.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(271, 34);
            this.btnVerificarVez.TabIndex = 113;
            this.btnVerificarVez.Text = "Verificar Vez";
            this.btnVerificarVez.UseVisualStyleBackColor = true;
            this.btnVerificarVez.Click += new System.EventHandler(this.btnVerificarVez_Click);
            // 
            // txtHistorico
            // 
            this.txtHistorico.BackColor = System.Drawing.Color.Wheat;
            this.txtHistorico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHistorico.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistorico.Location = new System.Drawing.Point(0, 31);
            this.txtHistorico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ReadOnly = true;
            this.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistorico.Size = new System.Drawing.Size(320, 182);
            this.txtHistorico.TabIndex = 114;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnHistorico);
            this.groupBox5.Controls.Add(this.txtHistorico);
            this.groupBox5.Font = new System.Drawing.Font("Primitive", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox5.Location = new System.Drawing.Point(1179, 543);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(320, 263);
            this.groupBox5.TabIndex = 115;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Histórico";
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHistorico.BackgroundImage")));
            this.btnHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHistorico.Font = new System.Drawing.Font("Primitive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.Black;
            this.btnHistorico.Location = new System.Drawing.Point(8, 222);
            this.btnHistorico.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(271, 34);
            this.btnHistorico.TabIndex = 114;
            this.btnHistorico.Text = "Exibir Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Primitive", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(11, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 27);
            this.label3.TabIndex = 116;
            this.label3.Text = "Cadeia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Primitive", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(1459, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 117;
            this.label4.Text = "Barco";
            // 
            // dgvCadeia
            // 
            this.dgvCadeia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCadeia.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvCadeia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCadeia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadeia.ColumnHeadersVisible = false;
            this.dgvCadeia.Enabled = false;
            this.dgvCadeia.Location = new System.Drawing.Point(-1, 34);
            this.dgvCadeia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCadeia.MultiSelect = false;
            this.dgvCadeia.Name = "dgvCadeia";
            this.dgvCadeia.ReadOnly = true;
            this.dgvCadeia.RowHeadersVisible = false;
            this.dgvCadeia.RowTemplate.Height = 24;
            this.dgvCadeia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCadeia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadeia.Size = new System.Drawing.Size(197, 455);
            this.dgvCadeia.TabIndex = 118;
            // 
            // dgvBarco
            // 
            this.dgvBarco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarco.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvBarco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBarco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarco.ColumnHeadersVisible = false;
            this.dgvBarco.Enabled = false;
            this.dgvBarco.Location = new System.Drawing.Point(1459, 34);
            this.dgvBarco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBarco.MultiSelect = false;
            this.dgvBarco.Name = "dgvBarco";
            this.dgvBarco.ReadOnly = true;
            this.dgvBarco.RowHeadersVisible = false;
            this.dgvBarco.RowTemplate.Height = 24;
            this.dgvBarco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBarco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarco.Size = new System.Drawing.Size(197, 455);
            this.dgvBarco.TabIndex = 120;
            // 
            // picMapBackground
            // 
            this.picMapBackground.BackColor = System.Drawing.Color.Transparent;
            this.picMapBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picMapBackground.Image = ((System.Drawing.Image)(resources.GetObject("picMapBackground.Image")));
            this.picMapBackground.Location = new System.Drawing.Point(199, 0);
            this.picMapBackground.Margin = new System.Windows.Forms.Padding(0);
            this.picMapBackground.Name = "picMapBackground";
            this.picMapBackground.Size = new System.Drawing.Size(1257, 490);
            this.picMapBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMapBackground.TabIndex = 0;
            this.picMapBackground.TabStop = false;
            // 
            // tmrVerificarVez
            // 
            this.tmrVerificarVez.Tick += new System.EventHandler(this.tmrVerificarVez_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1657, 853);
            this.Controls.Add(this.dgvBarco);
            this.Controls.Add(this.dgvCadeia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picMapBackground);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameForm";
            this.Text = "One Piece – Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadeia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMapBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVerificarVez;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.TextBox txtCorJogador;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtPosicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSimbolo;
        private System.Windows.Forms.Button btnMoverFrente;
        private System.Windows.Forms.Button btnMoverTras;
        private System.Windows.Forms.Button btnPularVez;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExibirMao;
        private System.Windows.Forms.TextBox txtMao;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnVerificarVez;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.PictureBox picMapBackground;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCadeia;
        private System.Windows.Forms.DataGridView dgvBarco;
        private System.Windows.Forms.Timer tmrVerificarVez;
        private System.Windows.Forms.Label lblCurrentPlayer;
    }
}