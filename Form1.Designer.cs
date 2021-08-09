namespace Reta_dois_pontos
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
            this.DrawningArea = new System.Windows.Forms.PictureBox();
            this.Button = new System.Windows.Forms.Button();
            this.TBX1 = new System.Windows.Forms.TextBox();
            this.TBY1 = new System.Windows.Forms.TextBox();
            this.TBX2 = new System.Windows.Forms.TextBox();
            this.TBY2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrawningArea)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawningArea
            // 
            this.DrawningArea.Location = new System.Drawing.Point(173, 12);
            this.DrawningArea.Name = "DrawningArea";
            this.DrawningArea.Size = new System.Drawing.Size(200, 200);
            this.DrawningArea.TabIndex = 0;
            this.DrawningArea.TabStop = false;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(12, 145);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(100, 37);
            this.Button.TabIndex = 1;
            this.Button.Text = "Desenhar Linha";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // TBX1
            // 
            this.TBX1.Location = new System.Drawing.Point(12, 41);
            this.TBX1.Name = "TBX1";
            this.TBX1.Size = new System.Drawing.Size(100, 20);
            this.TBX1.TabIndex = 2;
            // 
            // TBY1
            // 
            this.TBY1.Location = new System.Drawing.Point(12, 67);
            this.TBY1.Name = "TBY1";
            this.TBY1.Size = new System.Drawing.Size(100, 20);
            this.TBY1.TabIndex = 3;
            // 
            // TBX2
            // 
            this.TBX2.Location = new System.Drawing.Point(12, 93);
            this.TBX2.Name = "TBX2";
            this.TBX2.Size = new System.Drawing.Size(100, 20);
            this.TBX2.TabIndex = 4;
            // 
            // TBY2
            // 
            this.TBY2.Location = new System.Drawing.Point(12, 119);
            this.TBY2.Name = "TBY2";
            this.TBY2.Size = new System.Drawing.Size(100, 20);
            this.TBY2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "X2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 225);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBY2);
            this.Controls.Add(this.TBX2);
            this.Controls.Add(this.TBY1);
            this.Controls.Add(this.TBX1);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.DrawningArea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DrawningArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawningArea;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox TBX1;
        private System.Windows.Forms.TextBox TBY1;
        private System.Windows.Forms.TextBox TBX2;
        private System.Windows.Forms.TextBox TBY2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

