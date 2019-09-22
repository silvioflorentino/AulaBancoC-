namespace AulaBanco
{
    partial class colecoes
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
            this.buttonVetor = new System.Windows.Forms.Button();
            this.listBoxExemplo = new System.Windows.Forms.ListBox();
            this.buttonMatriz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVetor
            // 
            this.buttonVetor.Location = new System.Drawing.Point(138, 73);
            this.buttonVetor.Name = "buttonVetor";
            this.buttonVetor.Size = new System.Drawing.Size(75, 23);
            this.buttonVetor.TabIndex = 0;
            this.buttonVetor.Text = "Vetor";
            this.buttonVetor.UseVisualStyleBackColor = true;
            this.buttonVetor.Click += new System.EventHandler(this.buttonVetor_Click);
            // 
            // listBoxExemplo
            // 
            this.listBoxExemplo.FormattingEnabled = true;
            this.listBoxExemplo.Location = new System.Drawing.Point(12, 44);
            this.listBoxExemplo.Name = "listBoxExemplo";
            this.listBoxExemplo.Size = new System.Drawing.Size(120, 95);
            this.listBoxExemplo.TabIndex = 1;
            // 
            // buttonMatriz
            // 
            this.buttonMatriz.Location = new System.Drawing.Point(138, 44);
            this.buttonMatriz.Name = "buttonMatriz";
            this.buttonMatriz.Size = new System.Drawing.Size(75, 23);
            this.buttonMatriz.TabIndex = 2;
            this.buttonMatriz.Text = "Matriz";
            this.buttonMatriz.UseVisualStyleBackColor = true;
            this.buttonMatriz.Click += new System.EventHandler(this.buttonMatriz_Click);
            // 
            // colecoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 160);
            this.Controls.Add(this.buttonMatriz);
            this.Controls.Add(this.listBoxExemplo);
            this.Controls.Add(this.buttonVetor);
            this.Name = "colecoes";
            this.Text = "colecoes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVetor;
        private System.Windows.Forms.ListBox listBoxExemplo;
        private System.Windows.Forms.Button buttonMatriz;
    }
}