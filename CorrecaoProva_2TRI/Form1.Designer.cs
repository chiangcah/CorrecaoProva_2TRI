namespace CorrecaoProva_2TRI
{
    partial class Form1
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
            this.lblRodada = new System.Windows.Forms.Label();
            this.lblVitorias = new System.Windows.Forms.Label();
            this.lblEmpates = new System.Windows.Forms.Label();
            this.lblDerrotas = new System.Windows.Forms.Label();
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.lblJogadaSelecionada = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.btnDesselecionar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRodada
            // 
            this.lblRodada.AutoSize = true;
            this.lblRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRodada.Location = new System.Drawing.Point(24, 9);
            this.lblRodada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRodada.Name = "lblRodada";
            this.lblRodada.Size = new System.Drawing.Size(71, 16);
            this.lblRodada.TabIndex = 0;
            this.lblRodada.Text = "Rodada: 1";
            // 
            // lblVitorias
            // 
            this.lblVitorias.AutoSize = true;
            this.lblVitorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitorias.Location = new System.Drawing.Point(123, 9);
            this.lblVitorias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVitorias.Name = "lblVitorias";
            this.lblVitorias.Size = new System.Drawing.Size(66, 16);
            this.lblVitorias.TabIndex = 1;
            this.lblVitorias.Text = "Vitórias: 0";
            // 
            // lblEmpates
            // 
            this.lblEmpates.AutoSize = true;
            this.lblEmpates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpates.Location = new System.Drawing.Point(211, 9);
            this.lblEmpates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpates.Name = "lblEmpates";
            this.lblEmpates.Size = new System.Drawing.Size(75, 16);
            this.lblEmpates.TabIndex = 2;
            this.lblEmpates.Text = "Empates: 0";
            // 
            // lblDerrotas
            // 
            this.lblDerrotas.AutoSize = true;
            this.lblDerrotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerrotas.Location = new System.Drawing.Point(309, 9);
            this.lblDerrotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDerrotas.Name = "lblDerrotas";
            this.lblDerrotas.Size = new System.Drawing.Size(73, 16);
            this.lblDerrotas.TabIndex = 3;
            this.lblDerrotas.Text = "Derrotas: 0";
            // 
            // btnPedra
            // 
            this.btnPedra.Location = new System.Drawing.Point(52, 52);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(75, 26);
            this.btnPedra.TabIndex = 4;
            this.btnPedra.Text = "Pedra";
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.Location = new System.Drawing.Point(168, 52);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(75, 26);
            this.btnPapel.TabIndex = 5;
            this.btnPapel.Text = "Papel";
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnTesoura
            // 
            this.btnTesoura.Location = new System.Drawing.Point(276, 52);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(75, 26);
            this.btnTesoura.TabIndex = 6;
            this.btnTesoura.Text = "Tesoura";
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // lblJogadaSelecionada
            // 
            this.lblJogadaSelecionada.AutoSize = true;
            this.lblJogadaSelecionada.Location = new System.Drawing.Point(113, 119);
            this.lblJogadaSelecionada.Name = "lblJogadaSelecionada";
            this.lblJogadaSelecionada.Size = new System.Drawing.Size(190, 16);
            this.lblJogadaSelecionada.TabIndex = 7;
            this.lblJogadaSelecionada.Text = "Nenhuma jogada selecionada";
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(12, 178);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(122, 27);
            this.btnJogar.TabIndex = 8;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // rtbResultado
            // 
            this.rtbResultado.Location = new System.Drawing.Point(28, 224);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(355, 184);
            this.rtbResultado.TabIndex = 9;
            this.rtbResultado.Text = "";
            // 
            // btnDesselecionar
            // 
            this.btnDesselecionar.Location = new System.Drawing.Point(148, 178);
            this.btnDesselecionar.Name = "btnDesselecionar";
            this.btnDesselecionar.Size = new System.Drawing.Size(122, 27);
            this.btnDesselecionar.TabIndex = 10;
            this.btnDesselecionar.Text = "Desselecionar";
            this.btnDesselecionar.UseVisualStyleBackColor = true;
            this.btnDesselecionar.Click += new System.EventHandler(this.btnDesselecionar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(276, 178);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(122, 27);
            this.btnReiniciar.TabIndex = 11;
            this.btnReiniciar.Text = "Reiniciar Jogo";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(410, 429);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnDesselecionar);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblJogadaSelecionada);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.lblDerrotas);
            this.Controls.Add(this.lblEmpates);
            this.Controls.Add(this.lblVitorias);
            this.Controls.Add(this.lblRodada);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Pedra, Papel e Tesoura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRodada;
        private System.Windows.Forms.Label lblVitorias;
        private System.Windows.Forms.Label lblEmpates;
        private System.Windows.Forms.Label lblDerrotas;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.Label lblJogadaSelecionada;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Button btnDesselecionar;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

