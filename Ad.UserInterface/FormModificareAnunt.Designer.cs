namespace Ad.UserInterface
{
    partial class FormModificareAnunt
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
            this.label2 = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.TextBox();
            this.afisare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modificare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descriereModificata = new System.Windows.Forms.TextBox();
            this.pret = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pret)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificare Anunt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume Utilizator";
            // 
            // nume
            // 
            this.nume.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nume.Location = new System.Drawing.Point(236, 105);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(164, 22);
            this.nume.TabIndex = 2;
            this.nume.TextChanged += new System.EventHandler(this.nume_TextChanged);
            // 
            // afisare
            // 
            this.afisare.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.afisare.Location = new System.Drawing.Point(499, 84);
            this.afisare.Name = "afisare";
            this.afisare.Size = new System.Drawing.Size(134, 64);
            this.afisare.TabIndex = 3;
            this.afisare.Text = "Afisare Anunturi Utilizator";
            this.afisare.UseVisualStyleBackColor = false;
            this.afisare.Click += new System.EventHandler(this.afisare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(359, 219);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // modificare
            // 
            this.modificare.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.modificare.Location = new System.Drawing.Point(645, 280);
            this.modificare.Name = "modificare";
            this.modificare.Size = new System.Drawing.Size(133, 62);
            this.modificare.TabIndex = 5;
            this.modificare.Text = "Modificare Anunt";
            this.modificare.UseVisualStyleBackColor = false;
            this.modificare.Click += new System.EventHandler(this.modificare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modifica Descrierea";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Modifica Pretul";
            // 
            // descriereModificata
            // 
            this.descriereModificata.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.descriereModificata.Location = new System.Drawing.Point(426, 246);
            this.descriereModificata.Name = "descriereModificata";
            this.descriereModificata.Size = new System.Drawing.Size(189, 22);
            this.descriereModificata.TabIndex = 8;
            this.descriereModificata.TextChanged += new System.EventHandler(this.descriereModificata_TextChanged);
            // 
            // pret
            // 
            this.pret.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pret.Location = new System.Drawing.Point(426, 363);
            this.pret.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pret.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pret.Name = "pret";
            this.pret.Size = new System.Drawing.Size(189, 22);
            this.pret.TabIndex = 9;
            this.pret.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pret.ValueChanged += new System.EventHandler(this.pretNou_ValueChanged);
            // 
            // FormModificareAnunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pret);
            this.Controls.Add(this.descriereModificata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modificare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.afisare);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormModificareAnunt";
            this.Text = "FormModificareAnunt";
            this.Load += new System.EventHandler(this.FormModificareAnunt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Button afisare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button modificare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriereModificata;
        private System.Windows.Forms.NumericUpDown pret;
    }
}