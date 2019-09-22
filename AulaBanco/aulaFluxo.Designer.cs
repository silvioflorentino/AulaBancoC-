namespace AulaBanco
{
    partial class aulaFluxo
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
            this.buttonIfelse = new System.Windows.Forms.Button();
            this.textBoxIfelse = new System.Windows.Forms.TextBox();
            this.textBoxSwitch = new System.Windows.Forms.TextBox();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.buttonWhile = new System.Windows.Forms.Button();
            this.listBoxExemplo = new System.Windows.Forms.ListBox();
            this.buttonDowhile = new System.Windows.Forms.Button();
            this.buttonFor = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIfelse
            // 
            this.buttonIfelse.Location = new System.Drawing.Point(12, 50);
            this.buttonIfelse.Name = "buttonIfelse";
            this.buttonIfelse.Size = new System.Drawing.Size(75, 23);
            this.buttonIfelse.TabIndex = 0;
            this.buttonIfelse.Text = "If e Else";
            this.buttonIfelse.UseVisualStyleBackColor = true;
            this.buttonIfelse.Click += new System.EventHandler(this.buttonIfelse_Click);
            // 
            // textBoxIfelse
            // 
            this.textBoxIfelse.Location = new System.Drawing.Point(12, 24);
            this.textBoxIfelse.Name = "textBoxIfelse";
            this.textBoxIfelse.Size = new System.Drawing.Size(223, 20);
            this.textBoxIfelse.TabIndex = 1;
            // 
            // textBoxSwitch
            // 
            this.textBoxSwitch.Location = new System.Drawing.Point(257, 24);
            this.textBoxSwitch.Name = "textBoxSwitch";
            this.textBoxSwitch.Size = new System.Drawing.Size(223, 20);
            this.textBoxSwitch.TabIndex = 3;
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Location = new System.Drawing.Point(257, 50);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(75, 23);
            this.buttonSwitch.TabIndex = 2;
            this.buttonSwitch.Text = "Switch";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // buttonWhile
            // 
            this.buttonWhile.Location = new System.Drawing.Point(12, 90);
            this.buttonWhile.Name = "buttonWhile";
            this.buttonWhile.Size = new System.Drawing.Size(75, 23);
            this.buttonWhile.TabIndex = 4;
            this.buttonWhile.Text = "While";
            this.buttonWhile.UseVisualStyleBackColor = true;
            this.buttonWhile.Click += new System.EventHandler(this.buttonWhile_Click);
            // 
            // listBoxExemplo
            // 
            this.listBoxExemplo.FormattingEnabled = true;
            this.listBoxExemplo.Location = new System.Drawing.Point(93, 90);
            this.listBoxExemplo.Name = "listBoxExemplo";
            this.listBoxExemplo.Size = new System.Drawing.Size(223, 82);
            this.listBoxExemplo.TabIndex = 5;
            // 
            // buttonDowhile
            // 
            this.buttonDowhile.Location = new System.Drawing.Point(12, 119);
            this.buttonDowhile.Name = "buttonDowhile";
            this.buttonDowhile.Size = new System.Drawing.Size(75, 23);
            this.buttonDowhile.TabIndex = 6;
            this.buttonDowhile.Text = "Do/While";
            this.buttonDowhile.UseVisualStyleBackColor = true;
            this.buttonDowhile.Click += new System.EventHandler(this.buttonDowhile_Click);
            // 
            // buttonFor
            // 
            this.buttonFor.Location = new System.Drawing.Point(12, 148);
            this.buttonFor.Name = "buttonFor";
            this.buttonFor.Size = new System.Drawing.Size(75, 23);
            this.buttonFor.TabIndex = 7;
            this.buttonFor.Text = "For";
            this.buttonFor.UseVisualStyleBackColor = true;
            this.buttonFor.Click += new System.EventHandler(this.buttonFor_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(400, 152);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 8;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // aulaFluxo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 187);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonFor);
            this.Controls.Add(this.buttonDowhile);
            this.Controls.Add(this.listBoxExemplo);
            this.Controls.Add(this.buttonWhile);
            this.Controls.Add(this.textBoxSwitch);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.textBoxIfelse);
            this.Controls.Add(this.buttonIfelse);
            this.Name = "aulaFluxo";
            this.Text = "aulaFluxo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIfelse;
        private System.Windows.Forms.TextBox textBoxIfelse;
        private System.Windows.Forms.TextBox textBoxSwitch;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.Button buttonWhile;
        private System.Windows.Forms.ListBox listBoxExemplo;
        private System.Windows.Forms.Button buttonDowhile;
        private System.Windows.Forms.Button buttonFor;
        private System.Windows.Forms.Button buttonLimpar;
    }
}