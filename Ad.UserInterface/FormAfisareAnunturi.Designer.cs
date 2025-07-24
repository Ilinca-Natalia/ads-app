namespace Ad.UserInterface
{
    partial class FormAfisareAnunturi
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
            this.cautare = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.afisareUtilizator = new System.Windows.Forms.Button();
            this.afisareTotala = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cautare
            // 
            this.cautare.AutoSize = true;
            this.cautare.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cautare.Location = new System.Drawing.Point(216, 24);
            this.cautare.Name = "cautare";
            this.cautare.Size = new System.Drawing.Size(318, 42);
            this.cautare.TabIndex = 0;
            this.cautare.Text = "Afisare Anunturi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // nume
            // 
            this.nume.AutoSize = true;
            this.nume.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume.Location = new System.Drawing.Point(26, 114);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(158, 21);
            this.nume.TabIndex = 2;
            this.nume.Text = "Nume Utilizator";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbName.Location = new System.Drawing.Point(30, 159);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(165, 22);
            this.tbName.TabIndex = 3;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // afisareUtilizator
            // 
            this.afisareUtilizator.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.afisareUtilizator.Location = new System.Drawing.Point(30, 214);
            this.afisareUtilizator.Name = "afisareUtilizator";
            this.afisareUtilizator.Size = new System.Drawing.Size(172, 46);
            this.afisareUtilizator.TabIndex = 4;
            this.afisareUtilizator.Text = "Afiseaza Anunturile Utilizatorului";
            this.afisareUtilizator.UseVisualStyleBackColor = false;
            this.afisareUtilizator.Click += new System.EventHandler(this.afisareUtilizator_Click);
            // 
            // afisareTotala
            // 
            this.afisareTotala.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.afisareTotala.Location = new System.Drawing.Point(30, 292);
            this.afisareTotala.Name = "afisareTotala";
            this.afisareTotala.Size = new System.Drawing.Size(172, 47);
            this.afisareTotala.TabIndex = 5;
            this.afisareTotala.Text = "Afiseaza Toate Anunturile";
            this.afisareTotala.UseVisualStyleBackColor = false;
            this.afisareTotala.Click += new System.EventHandler(this.afisareTotala_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(269, 119);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(519, 219);
            this.dgv.TabIndex = 6;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(454, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Total Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(334, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "Export XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAfisareAnunturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.afisareTotala);
            this.Controls.Add(this.afisareUtilizator);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cautare);
            this.Name = "FormAfisareAnunturi";
            this.Text = "FormAfisareAnunturi";
            this.Load += new System.EventHandler(this.FormAfisareAnunturi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cautare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nume;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button afisareUtilizator;
        private System.Windows.Forms.Button afisareTotala;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}