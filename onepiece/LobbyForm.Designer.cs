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
            this.btnCriarPartida.Location = new System.Drawing.Point(134, 105);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(75, 31);
            this.btnCriarPartida.TabIndex = 15;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Senha Partida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome Partida";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(16, 112);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(112, 24);
            this.txtSenhaPartida.TabIndex = 12;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(16, 54);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(193, 24);
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
            this.cmbFiltrarPartidas.ItemHeight = 20;
            this.cmbFiltrarPartidas.Location = new System.Drawing.Point(0, 0);
            this.cmbFiltrarPartidas.Name = "cmbFiltrarPartidas";
            this.cmbFiltrarPartidas.Size = new System.Drawing.Size(602, 28);
            this.cmbFiltrarPartidas.TabIndex = 10;
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.BackColor = System.Drawing.Color.Transparent;
            this.btnListarPartidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarPartidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnListarPartidas.Location = new System.Drawing.Point(12, 34);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(250, 40);
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
            this.groupBox1.Location = new System.Drawing.Point(63, 491);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 150);
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
            this.btnListarJogadores.Location = new System.Drawing.Point(356, 34);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(178, 40);
            this.btnListarJogadores.TabIndex = 17;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = false;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(294, 54);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(48, 20);
            this.txtIdPartida.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(299, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Id:";
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Transparent;
            this.btnJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnJogar.Location = new System.Drawing.Point(303, 507);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(193, 31);
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
            this.btnAssistir.Location = new System.Drawing.Point(303, 555);
            this.btnAssistir.Name = "btnAssistir";
            this.btnAssistir.Size = new System.Drawing.Size(193, 31);
            this.btnAssistir.TabIndex = 23;
            this.btnAssistir.Text = "Assistir";
            this.btnAssistir.UseVisualStyleBackColor = false;
            this.btnAssistir.Click += new System.EventHandler(this.btnAssistir_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(496, 599);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(0, 13);
            this.lblVersao.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(456, 599);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Versão";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPartida
            // 
            this.dgvPartida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPartida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPartida.Location = new System.Drawing.Point(63, 153);
            this.dgvPartida.MultiSelect = false;
            this.dgvPartida.Name = "dgvPartida";
            this.dgvPartida.ReadOnly = true;
            this.dgvPartida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartida.Size = new System.Drawing.Size(433, 163);
            this.dgvPartida.TabIndex = 26;
            this.dgvPartida.Click += new System.EventHandler(this.dgvPartida_Click);
            // 
            // dgvJogadores
            // 
            this.dgvJogadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogadores.Location = new System.Drawing.Point(63, 322);
            this.dgvJogadores.Name = "dgvJogadores";
            this.dgvJogadores.Size = new System.Drawing.Size(433, 163);
            this.dgvJogadores.TabIndex = 27;
            // 
            // LobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::onepiece.Properties.Resources.backgroundLoginForm;
            this.ClientSize = new System.Drawing.Size(602, 703);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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