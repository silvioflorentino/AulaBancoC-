namespace AulaBanco
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxcidade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.labelcodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxbusca = new System.Windows.Forms.TextBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.agendaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxcidade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxemail);
            this.groupBox1.Controls.Add(this.labelcodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxnome);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Cliente";
            // 
            // comboBoxcidade
            // 
            this.comboBoxcidade.FormattingEnabled = true;
            this.comboBoxcidade.Items.AddRange(new object[] {
            "Guarulhos",
            "São paulo",
            "Itaqua"});
            this.comboBoxcidade.Location = new System.Drawing.Point(49, 121);
            this.comboBoxcidade.Name = "comboBoxcidade";
            this.comboBoxcidade.Size = new System.Drawing.Size(88, 21);
            this.comboBoxcidade.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail:";
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(8, 91);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(246, 20);
            this.textBoxemail.TabIndex = 5;
            // 
            // labelcodigo
            // 
            this.labelcodigo.AutoSize = true;
            this.labelcodigo.Location = new System.Drawing.Point(46, 22);
            this.labelcodigo.Name = "labelcodigo";
            this.labelcodigo.Size = new System.Drawing.Size(13, 13);
            this.labelcodigo.TabIndex = 2;
            this.labelcodigo.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(8, 52);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(246, 20);
            this.textBoxnome.TabIndex = 4;
            this.textBoxnome.TextChanged += new System.EventHandler(this.textBoxnome_TextChanged);
            // 
            // buttonGravar
            // 
            this.buttonGravar.AccessibleDescription = "";
            this.buttonGravar.AccessibleName = "ssss";
            this.buttonGravar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGravar.BackgroundImage")));
            this.buttonGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGravar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonGravar.FlatAppearance.BorderSize = 3;
            this.buttonGravar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonGravar.Location = new System.Drawing.Point(4, 196);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(60, 60);
            this.buttonGravar.TabIndex = 7;
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAlterar.BackgroundImage")));
            this.buttonAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAlterar.Location = new System.Drawing.Point(70, 196);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(60, 60);
            this.buttonAlterar.TabIndex = 8;
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExcluir.BackgroundImage")));
            this.buttonExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExcluir.Location = new System.Drawing.Point(136, 196);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(60, 60);
            this.buttonExcluir.TabIndex = 9;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(4, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 53);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxbusca
            // 
            this.textBoxbusca.Location = new System.Drawing.Point(70, 295);
            this.textBoxbusca.Name = "textBoxbusca";
            this.textBoxbusca.Size = new System.Drawing.Size(156, 20);
            this.textBoxbusca.TabIndex = 7;
            // 
            // buttonSair
            // 
            this.buttonSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSair.BackgroundImage")));
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSair.Location = new System.Drawing.Point(202, 196);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(60, 60);
            this.buttonSair.TabIndex = 11;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Digite o Código";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(317, 327);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.textBoxbusca);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label labelcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxbusca;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxcidade;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.BindingSource agendaDataSetBindingSource;
    }
}

