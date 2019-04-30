namespace onepiece
{
    partial class LobbyForm
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
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.cmbFiltrarPartidas = new System.Windows.Forms.ComboBox();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.txtListarJogadores = new System.Windows.Forms.TextBox();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.btnAssistir = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCriarPartida.Location = new System.Drawing.Point(179, 129);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(100, 38);
            this.btnCriarPartida.TabIndex = 15;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Senha Partida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome Partida";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(21, 138);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(148, 28);
            this.txtSenhaPartida.TabIndex = 12;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(21, 66);
            this.txtNomePartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(256, 28);
            this.txtNomePartida.TabIndex = 11;
            // 
            // cmbFiltrarPartidas
            // 
            this.cmbFiltrarPartidas.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFiltrarPartidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFiltrarPartidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFiltrarPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cmbFiltrarPartidas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbFiltrarPartidas.FormattingEnabled = true;
            this.cmbFiltrarPartidas.ItemHeight = 26;
            this.cmbFiltrarPartidas.Location = new System.Drawing.Point(0, 0);
            this.cmbFiltrarPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFiltrarPartidas.Name = "cmbFiltrarPartidas";
            this.cmbFiltrarPartidas.Size = new System.Drawing.Size(771, 34);
            this.cmbFiltrarPartidas.TabIndex = 10;
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.BackColor = System.Drawing.Color.Transparent;
            this.btnListarPartidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarPartidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnListarPartidas.Location = new System.Drawing.Point(16, 42);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(333, 49);
            this.btnListarPartidas.TabIndex = 8;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = false;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtNomePartida);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSenhaPartida);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCriarPartida);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(75, 409);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(296, 185);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Partida";
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.BackColor = System.Drawing.Color.Transparent;
            this.btnListarJogadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarJogadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnListarJogadores.Location = new System.Drawing.Point(459, 42);
            this.btnListarJogadores.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(237, 49);
            this.btnListarJogadores.TabIndex = 17;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = false;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // txtListarJogadores
            // 
            this.txtListarJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtListarJogadores.Location = new System.Drawing.Point(391, 204);
            this.txtListarJogadores.Margin = new System.Windows.Forms.Padding(4);
            this.txtListarJogadores.Multiline = true;
            this.txtListarJogadores.Name = "txtListarJogadores";
            this.txtListarJogadores.ReadOnly = true;
            this.txtListarJogadores.Size = new System.Drawing.Size(268, 176);
            this.txtListarJogadores.TabIndex = 18;
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(387, 66);
            this.txtIdPartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(63, 22);
            this.txtIdPartida.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(387, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Id:";
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Transparent;
            this.btnJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnJogar.Location = new System.Drawing.Point(391, 409);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(4);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(257, 38);
            this.btnJogar.TabIndex = 19;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 25;
            this.lista.Location = new System.Drawing.Point(96, 204);
            this.lista.Margin = new System.Windows.Forms.Padding(4);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(273, 154);
            this.lista.TabIndex = 22;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // btnAssistir
            // 
            this.btnAssistir.BackColor = System.Drawing.Color.Transparent;
            this.btnAssistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAssistir.Location = new System.Drawing.Point(391, 468);
            this.btnAssistir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssistir.Name = "btnAssistir";
            this.btnAssistir.Size = new System.Drawing.Size(257, 38);
            this.btnAssistir.TabIndex = 23;
            this.btnAssistir.Text = "Assistir";
            this.btnAssistir.UseVisualStyleBackColor = false;
            this.btnAssistir.Click += new System.EventHandler(this.btnAssistir_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(648, 526);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(0, 17);
            this.lblVersao.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(595, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Versão";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::onepiece.Properties.Resources.backgroundLoginForm;
            this.ClientSize = new System.Drawing.Size(771, 732);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnAssistir);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.txtListarJogadores);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbFiltrarPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LobbyForm";
            this.Text = "One Piece – Lobby";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.ComboBox cmbFiltrarPartidas;
        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.TextBox txtListarJogadores;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnAssistir;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label label4;
    }
}