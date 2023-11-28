namespace WindowsFormsApp6
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
            this.rbAlternativaCorretaA = new System.Windows.Forms.RadioButton();
            this.rtxPergunta = new System.Windows.Forms.RichTextBox();
            this.txbAlternativaA = new System.Windows.Forms.TextBox();
            this.txbAlternativaB = new System.Windows.Forms.TextBox();
            this.rbAlternativaCorretaB = new System.Windows.Forms.RadioButton();
            this.txbAlternativaC = new System.Windows.Forms.TextBox();
            this.rbAlternativaCorretaC = new System.Windows.Forms.RadioButton();
            this.txbAlternativaD = new System.Windows.Forms.TextBox();
            this.rbAlternativaCorretaD = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbAlternativaCorretaA
            // 
            this.rbAlternativaCorretaA.AutoSize = true;
            this.rbAlternativaCorretaA.Location = new System.Drawing.Point(12, 121);
            this.rbAlternativaCorretaA.Name = "rbAlternativaCorretaA";
            this.rbAlternativaCorretaA.Size = new System.Drawing.Size(32, 17);
            this.rbAlternativaCorretaA.TabIndex = 0;
            this.rbAlternativaCorretaA.TabStop = true;
            this.rbAlternativaCorretaA.Text = "A";
            this.rbAlternativaCorretaA.UseVisualStyleBackColor = true;
            // 
            // rtxPergunta
            // 
            this.rtxPergunta.Location = new System.Drawing.Point(12, 12);
            this.rtxPergunta.Name = "rtxPergunta";
            this.rtxPergunta.Size = new System.Drawing.Size(270, 100);
            this.rtxPergunta.TabIndex = 1;
            this.rtxPergunta.Text = "";
            // 
            // txbAlternativaA
            // 
            this.txbAlternativaA.Location = new System.Drawing.Point(50, 118);
            this.txbAlternativaA.Name = "txbAlternativaA";
            this.txbAlternativaA.Size = new System.Drawing.Size(230, 20);
            this.txbAlternativaA.TabIndex = 2;
            // 
            // txbAlternativaB
            // 
            this.txbAlternativaB.Location = new System.Drawing.Point(50, 144);
            this.txbAlternativaB.Name = "txbAlternativaB";
            this.txbAlternativaB.Size = new System.Drawing.Size(230, 20);
            this.txbAlternativaB.TabIndex = 4;
            // 
            // rbAlternativaCorretaB
            // 
            this.rbAlternativaCorretaB.AutoSize = true;
            this.rbAlternativaCorretaB.Location = new System.Drawing.Point(12, 147);
            this.rbAlternativaCorretaB.Name = "rbAlternativaCorretaB";
            this.rbAlternativaCorretaB.Size = new System.Drawing.Size(32, 17);
            this.rbAlternativaCorretaB.TabIndex = 3;
            this.rbAlternativaCorretaB.TabStop = true;
            this.rbAlternativaCorretaB.Text = "B";
            this.rbAlternativaCorretaB.UseVisualStyleBackColor = true;
            // 
            // txbAlternativaC
            // 
            this.txbAlternativaC.Location = new System.Drawing.Point(50, 170);
            this.txbAlternativaC.Name = "txbAlternativaC";
            this.txbAlternativaC.Size = new System.Drawing.Size(230, 20);
            this.txbAlternativaC.TabIndex = 6;
            // 
            // rbAlternativaCorretaC
            // 
            this.rbAlternativaCorretaC.AutoSize = true;
            this.rbAlternativaCorretaC.Location = new System.Drawing.Point(12, 173);
            this.rbAlternativaCorretaC.Name = "rbAlternativaCorretaC";
            this.rbAlternativaCorretaC.Size = new System.Drawing.Size(32, 17);
            this.rbAlternativaCorretaC.TabIndex = 5;
            this.rbAlternativaCorretaC.TabStop = true;
            this.rbAlternativaCorretaC.Text = "C";
            this.rbAlternativaCorretaC.UseVisualStyleBackColor = true;
            // 
            // txbAlternativaD
            // 
            this.txbAlternativaD.Location = new System.Drawing.Point(50, 196);
            this.txbAlternativaD.Name = "txbAlternativaD";
            this.txbAlternativaD.Size = new System.Drawing.Size(230, 20);
            this.txbAlternativaD.TabIndex = 8;
            // 
            // rbAlternativaCorretaD
            // 
            this.rbAlternativaCorretaD.AutoSize = true;
            this.rbAlternativaCorretaD.Location = new System.Drawing.Point(12, 199);
            this.rbAlternativaCorretaD.Name = "rbAlternativaCorretaD";
            this.rbAlternativaCorretaD.Size = new System.Drawing.Size(33, 17);
            this.rbAlternativaCorretaD.TabIndex = 7;
            this.rbAlternativaCorretaD.TabStop = true;
            this.rbAlternativaCorretaD.Text = "D";
            this.rbAlternativaCorretaD.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 244);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(80, 29);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 294);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbAlternativaD);
            this.Controls.Add(this.rbAlternativaCorretaD);
            this.Controls.Add(this.txbAlternativaC);
            this.Controls.Add(this.rbAlternativaCorretaC);
            this.Controls.Add(this.txbAlternativaB);
            this.Controls.Add(this.rbAlternativaCorretaB);
            this.Controls.Add(this.txbAlternativaA);
            this.Controls.Add(this.rtxPergunta);
            this.Controls.Add(this.rbAlternativaCorretaA);
            this.Name = "Form1";
            this.Text = "Cadastrar Perguntas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAlternativaCorretaA;
        private System.Windows.Forms.RichTextBox rtxPergunta;
        private System.Windows.Forms.TextBox txbAlternativaA;
        private System.Windows.Forms.TextBox txbAlternativaB;
        private System.Windows.Forms.RadioButton rbAlternativaCorretaB;
        private System.Windows.Forms.TextBox txbAlternativaC;
        private System.Windows.Forms.RadioButton rbAlternativaCorretaC;
        private System.Windows.Forms.TextBox txbAlternativaD;
        private System.Windows.Forms.RadioButton rbAlternativaCorretaD;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

