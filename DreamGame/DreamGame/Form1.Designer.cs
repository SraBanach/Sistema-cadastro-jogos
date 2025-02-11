namespace DreamGame
{
    partial class DreamGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxTamanho = new System.Windows.Forms.TextBox();
            this.textBoxDesenvolvedor = new System.Windows.Forms.TextBox();
            this.maskedTextBoxValor = new System.Windows.Forms.MaskedTextBox();
            this.labelavaliacao = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxAvaliacao = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de jogos";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(363, 399);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxAvaliacao);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.comboBoxGenero);
            this.groupBox1.Controls.Add(this.labelavaliacao);
            this.groupBox1.Controls.Add(this.maskedTextBoxValor);
            this.groupBox1.Controls.Add(this.textBoxDesenvolvedor);
            this.groupBox1.Controls.Add(this.textBoxTamanho);
            this.groupBox1.Controls.Add(this.textBoxTitulo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelTitulo);
            this.groupBox1.Location = new System.Drawing.Point(41, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 318);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(39, 27);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Titulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tamanho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gênero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Desenvolvedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Valor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Descrição";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(33, 43);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(181, 20);
            this.textBoxTitulo.TabIndex = 9;
            // 
            // textBoxTamanho
            // 
            this.textBoxTamanho.Location = new System.Drawing.Point(259, 43);
            this.textBoxTamanho.Multiline = true;
            this.textBoxTamanho.Name = "textBoxTamanho";
            this.textBoxTamanho.Size = new System.Drawing.Size(100, 20);
            this.textBoxTamanho.TabIndex = 11;
            // 
            // textBoxDesenvolvedor
            // 
            this.textBoxDesenvolvedor.Location = new System.Drawing.Point(260, 192);
            this.textBoxDesenvolvedor.Name = "textBoxDesenvolvedor";
            this.textBoxDesenvolvedor.Size = new System.Drawing.Size(136, 20);
            this.textBoxDesenvolvedor.TabIndex = 13;
            // 
            // maskedTextBoxValor
            // 
            this.maskedTextBoxValor.Location = new System.Drawing.Point(548, 282);
            this.maskedTextBoxValor.Mask = "$000,00";
            this.maskedTextBoxValor.Name = "maskedTextBoxValor";
            this.maskedTextBoxValor.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxValor.TabIndex = 17;
            // 
            // labelavaliacao
            // 
            this.labelavaliacao.AutoSize = true;
            this.labelavaliacao.Location = new System.Drawing.Point(258, 266);
            this.labelavaliacao.Name = "labelavaliacao";
            this.labelavaliacao.Size = new System.Drawing.Size(54, 13);
            this.labelavaliacao.TabIndex = 18;
            this.labelavaliacao.Text = "Avaliação";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Drama",
            "Ficção ",
            "Fantasia ",
            "Romance"});
            this.comboBoxGenero.Location = new System.Drawing.Point(261, 114);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGenero.TabIndex = 20;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(196, 137);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // comboBoxAvaliacao
            // 
            this.comboBoxAvaliacao.FormattingEnabled = true;
            this.comboBoxAvaliacao.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxAvaliacao.Location = new System.Drawing.Point(259, 281);
            this.comboBoxAvaliacao.Name = "comboBoxAvaliacao";
            this.comboBoxAvaliacao.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAvaliacao.TabIndex = 22;
            // 
            // DreamGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label1);
            this.Name = "DreamGame";
            this.Text = "DreamGame";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxDesenvolvedor;
        private System.Windows.Forms.TextBox textBoxTamanho;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValor;
        private System.Windows.Forms.Label labelavaliacao;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBoxAvaliacao;
    }
}

