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
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnAssistir = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPartida = new System.Windows.Forms.DataGridView();
            this.dgvJogadores = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogadores)).BeginInit();
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
            this.cmbFiltrarPartidas.Size = new System.Drawing.Size(985, 34);
            this.cmbFiltrarPartidas.TabIndex = 10;
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.BackColor = System.Drawing.Color.Transparent;
            this.btnListarPartidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarPartidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnListarPartidas.Location = new System.Drawing.Point(44, 101);
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
            this.groupBox1.Location = new System.Drawing.Point(44, 339);
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
            this.btnListarJogadores.Location = new System.Drawing.Point(696, 102);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(237, 49);
            this.btnListarJogadores.TabIndex = 17;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = false;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(607, 128);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(63, 22);
            this.txtIdPartida.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(567, 125);
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
            this.btnJogar.Location = new System.Drawing.Point(500, 339);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(257, 38);
            this.btnJogar.TabIndex = 19;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnAssistir
            // 
            this.btnAssistir.BackColor = System.Drawing.Color.Transparent;
            this.btnAssistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAssistir.Location = new System.Drawing.Point(500, 395);
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
            this.lblVersao.Location = new System.Drawing.Point(931, 540);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(0, 17);
            this.lblVersao.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(891, 540);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Versão";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPartida
            // 
            this.dgvPartida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartida.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvPartida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPartida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPartida.Location = new System.Drawing.Point(44, 157);
            this.dgvPartida.MultiSelect = false;
            this.dgvPartida.Name = "dgvPartida";
            this.dgvPartida.ReadOnly = true;
            this.dgvPartida.RowHeadersVisible = false;
            this.dgvPartida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPartida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartida.Size = new System.Drawing.Size(433, 163);
            this.dgvPartida.TabIndex = 26;
            this.dgvPartida.Click += new System.EventHandler(this.dgvPartida_Click);
            // 
            // dgvJogadores
            // 
            this.dgvJogadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJogadores.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogadores.Location = new System.Drawing.Point(500, 157);
            this.dgvJogadores.MultiSelect = false;
            this.dgvJogadores.Name = "dgvJogadores";
            this.dgvJogadores.ReadOnly = true;
            this.dgvJogadores.RowHeadersVisible = false;
            this.dgvJogadores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvJogadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJogadores.Size = new System.Drawing.Size(433, 163);
            this.dgvJogadores.TabIndex = 27;
            // 
            // LobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = global::onepiece.Properties.Resources.backgroundLobbyForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(985, 586);
            this.Controls.Add(this.dgvJogadores);
            this.Controls.Add(this.dgvPartida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnAssistir);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbFiltrarPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LobbyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Piece – Lobby";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogadores)).EndInit();
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
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnAssistir;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPartida;
        private System.Windows.Forms.DataGridView dgvJogadores;
    }
}