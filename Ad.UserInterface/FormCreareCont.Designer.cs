namespace Ad.UserInterface
{
    partial class FormCreareCont
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
            this.label1 = new System.Windows.Forms.Label();
            this.numeUtilizator = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.Label();
            this.cont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creare cont utilizator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numeUtilizator
            // 
            this.numeUtilizator.AutoSize = true;
            this.numeUtilizator.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeUtilizator.Location = new System.Drawing.Point(68, 229);
            this.numeUtilizator.Name = "numeUtilizator";
            this.numeUtilizator.Size = new System.Drawing.Size(158, 21);
            this.numeUtilizator.TabIndex = 1;
            this.numeUtilizator.Text = "Nume Utilizator";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbName.Location = new System.Drawing.Point(72, 273);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(191, 22);
            this.tbName.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPassword.Location = new System.Drawing.Point(463, 273);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(191, 22);
            this.tbPassword.TabIndex = 5;
            // 
            // parola
            // 
            this.parola.AutoSize = true;
            this.parola.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parola.Location = new System.Drawing.Point(468, 229);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(74, 21);
            this.parola.TabIndex = 7;
            this.parola.Text = "Parola";
            // 
            // cont
            // 
            this.cont.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cont.Location = new System.Drawing.Point(267, 354);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(244, 39);
            this.cont.TabIndex = 8;
            this.cont.Text = "Creare Cont";
            this.cont.UseVisualStyleBackColor = false;
            this.cont.Click += new System.EventHandler(this.cont_Click);
            // 
            // FormCreareCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.numeUtilizator);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormCreareCont";
            this.Text = "FormCreareCont";
            this.Load += new System.EventHandler(this.FormCreareCont_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numeUtilizator;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label parola;
        private System.Windows.Forms.Button cont;
    }
}