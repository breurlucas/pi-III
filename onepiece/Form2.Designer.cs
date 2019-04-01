namespace onepiece
{
    partial class Form2
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lista = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCriarPartida.Location = new System.Drawing.Point(219, 129);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(148, 28);
            this.txtSenhaPartida.TabIndex = 12;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(21, 66);
            this.txtNomePartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cmbFiltrarPartidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFiltrarPartidas.Name = "cmbFiltrarPartidas";
            this.cmbFiltrarPartidas.Size = new System.Drawing.Size(712, 34);
            this.cmbFiltrarPartidas.TabIndex = 10;
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnListarPartidas.Location = new System.Drawing.Point(16, 42);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(333, 49);
            this.btnListarPartidas.TabIndex = 8;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomePartida);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSenhaPartida);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCriarPartida);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(16, 426);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(341, 188);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Partida";
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnListarJogadores.Location = new System.Drawing.Point(459, 42);
            this.btnListarJogadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(237, 49);
            this.btnListarJogadores.TabIndex = 17;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // txtListarJogadores
            // 
            this.txtListarJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtListarJogadores.Location = new System.Drawing.Point(391, 106);
            this.txtListarJogadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtListarJogadores.Multiline = true;
            this.txtListarJogadores.Name = "txtListarJogadores";
            this.txtListarJogadores.ReadOnly = true;
            this.txtListarJogadores.Size = new System.Drawing.Size(304, 304);
            this.txtListarJogadores.TabIndex = 18;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(391, 66);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(63, 22);
            this.txtId.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(404, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEntrarPartida);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNomeJogador);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(391, 426);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(305, 188);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jogador";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrarPartida.Location = new System.Drawing.Point(19, 129);
            this.btnEntrarPartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(257, 38);
            this.btnEntrarPartida.TabIndex = 19;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nome do Jogador";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(19, 66);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(256, 30);
            this.txtNomeJogador.TabIndex = 12;
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 25;
            this.lista.Location = new System.Drawing.Point(16, 106);
            this.lista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(333, 304);
            this.lista.TabIndex = 22;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 629);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtListarJogadores);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbFiltrarPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.ListBox lista;
    }
}