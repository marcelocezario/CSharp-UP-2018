namespace WindowsFormsApp1
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
            this.nomeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cpfCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeRua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.complemento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeCliente
            // 
            this.nomeCliente.Location = new System.Drawing.Point(100, 52);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(465, 22);
            this.nomeCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF do cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cpfCliente
            // 
            this.cpfCliente.Location = new System.Drawing.Point(100, 112);
            this.cpfCliente.Name = "cpfCliente";
            this.cpfCliente.Size = new System.Drawing.Size(465, 22);
            this.cpfCliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome da rua";
            // 
            // nomeRua
            // 
            this.nomeRua.Location = new System.Drawing.Point(100, 180);
            this.nomeRua.Name = "nomeRua";
            this.nomeRua.Size = new System.Drawing.Size(465, 22);
            this.nomeRua.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número";
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(100, 258);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(465, 22);
            this.numero.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Complemento";
            // 
            // complemento
            // 
            this.complemento.Location = new System.Drawing.Point(100, 328);
            this.complemento.Name = "complemento";
            this.complemento.Size = new System.Drawing.Size(465, 22);
            this.complemento.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salvar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.complemento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomeRua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cpfCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cpfCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeRua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox complemento;
        private System.Windows.Forms.Button button1;
    }
}

