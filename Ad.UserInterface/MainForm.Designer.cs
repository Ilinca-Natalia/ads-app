namespace Ad.UserInterface
{
    partial class MainForm
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
            this.cont = new System.Windows.Forms.Button();
            this.adaugare = new System.Windows.Forms.Button();
            this.stergere = new System.Windows.Forms.Button();
            this.modificare = new System.Windows.Forms.Button();
            this.cautare = new System.Windows.Forms.Button();
            this.afisare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(144, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionarea anunturilor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cont
            // 
            this.cont.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cont.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cont.Location = new System.Drawing.Point(15, 156);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(210, 60);
            this.cont.TabIndex = 1;
            this.cont.Text = "Creare Cont Utilizator";
            this.cont.UseVisualStyleBackColor = false;
            this.cont.Click += new System.EventHandler(this.cont_Click);
            // 
            // adaugare
            // 
            this.adaugare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adaugare.Location = new System.Drawing.Point(284, 156);
            this.adaugare.Name = "adaugare";
            this.adaugare.Size = new System.Drawing.Size(210, 60);
            this.adaugare.TabIndex = 2;
            this.adaugare.Text = "Adăugare Anunț";
            this.adaugare.UseVisualStyleBackColor = false;
            this.adaugare.Click += new System.EventHandler(this.button2_Click);
            // 
            // stergere
            // 
            this.stergere.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stergere.Location = new System.Drawing.Point(551, 156);
            this.stergere.Name = "stergere";
            this.stergere.Size = new System.Drawing.Size(210, 60);
            this.stergere.TabIndex = 3;
            this.stergere.Text = "Ștergere Anunț";
            this.stergere.UseVisualStyleBackColor = false;
            this.stergere.Click += new System.EventHandler(this.stergere_Click);
            // 
            // modificare
            // 
            this.modificare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.modificare.Location = new System.Drawing.Point(15, 283);
            this.modificare.Name = "modificare";
            this.modificare.Size = new System.Drawing.Size(210, 60);
            this.modificare.TabIndex = 4;
            this.modificare.Text = "Modificare Anunț";
            this.modificare.UseVisualStyleBackColor = false;
            this.modificare.Click += new System.EventHandler(this.modificare_Click);
            // 
            // cautare
            // 
            this.cautare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cautare.Location = new System.Drawing.Point(284, 283);
            this.cautare.Name = "cautare";
            this.cautare.Size = new System.Drawing.Size(210, 60);
            this.cautare.TabIndex = 5;
            this.cautare.Text = "Căutare Anunțuri";
            this.cautare.UseVisualStyleBackColor = false;
            this.cautare.Click += new System.EventHandler(this.cautare_Click);
            // 
            // afisare
            // 
            this.afisare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.afisare.Location = new System.Drawing.Point(551, 283);
            this.afisare.Name = "afisare";
            this.afisare.Size = new System.Drawing.Size(210, 60);
            this.afisare.TabIndex = 6;
            this.afisare.Text = "Afișare Anunțuri";
            this.afisare.UseVisualStyleBackColor = false;
            this.afisare.Click += new System.EventHandler(this.afisare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alegeti varianta dorita";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.afisare);
            this.Controls.Add(this.cautare);
            this.Controls.Add(this.modificare);
            this.Controls.Add(this.stergere);
            this.Controls.Add(this.adaugare);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cont;
        private System.Windows.Forms.Button adaugare;
        private System.Windows.Forms.Button stergere;
        private System.Windows.Forms.Button modificare;
        private System.Windows.Forms.Button cautare;
        private System.Windows.Forms.Button afisare;
        private System.Windows.Forms.Label label2;
    }
}

