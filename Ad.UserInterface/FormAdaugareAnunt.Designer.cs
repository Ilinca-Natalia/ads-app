namespace Ad.UserInterface
{
    partial class FormAdaugareAnunt
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
            this.titlu = new System.Windows.Forms.Label();
            this.descriere = new System.Windows.Forms.Label();
            this.pret = new System.Windows.Forms.Label();
            this.categorie = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.adaugare = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adaugare Anunt";
            // 
            // titlu
            // 
            this.titlu.AutoSize = true;
            this.titlu.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu.Location = new System.Drawing.Point(27, 138);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(114, 21);
            this.titlu.TabIndex = 1;
            this.titlu.Text = "Titlu anunt";
            this.titlu.Click += new System.EventHandler(this.label2_Click);
            // 
            // descriere
            // 
            this.descriere.AutoSize = true;
            this.descriere.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriere.Location = new System.Drawing.Point(28, 176);
            this.descriere.Name = "descriere";
            this.descriere.Size = new System.Drawing.Size(99, 21);
            this.descriere.TabIndex = 2;
            this.descriere.Text = "Descriere";
            // 
            // pret
            // 
            this.pret.AutoSize = true;
            this.pret.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pret.Location = new System.Drawing.Point(28, 256);
            this.pret.Name = "pret";
            this.pret.Size = new System.Drawing.Size(52, 21);
            this.pret.TabIndex = 3;
            this.pret.Text = "Pret";
            // 
            // categorie
            // 
            this.categorie.AutoSize = true;
            this.categorie.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorie.Location = new System.Drawing.Point(28, 294);
            this.categorie.Name = "categorie";
            this.categorie.Size = new System.Drawing.Size(100, 21);
            this.categorie.TabIndex = 4;
            this.categorie.Text = "Categorie";
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbTitle.Location = new System.Drawing.Point(207, 140);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(154, 22);
            this.tbTitle.TabIndex = 5;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbDescription.Location = new System.Drawing.Point(207, 178);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(154, 22);
            this.tbDescription.TabIndex = 6;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Bestsellers",
            "Romance",
            "Young_adult",
            "Kids",
            "History"});
            this.cbCategory.Location = new System.Drawing.Point(207, 291);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(154, 24);
            this.cbCategory.TabIndex = 8;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // adaugare
            // 
            this.adaugare.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adaugare.Location = new System.Drawing.Point(515, 405);
            this.adaugare.Name = "adaugare";
            this.adaugare.Size = new System.Drawing.Size(204, 33);
            this.adaugare.TabIndex = 9;
            this.adaugare.Text = "Adaugare anunt";
            this.adaugare.UseVisualStyleBackColor = false;
            this.adaugare.Click += new System.EventHandler(this.adaugare_Click);
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.price.Location = new System.Drawing.Point(207, 255);
            this.price.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(154, 22);
            this.price.TabIndex = 10;
            this.price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(28, 215);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(158, 21);
            this.name.TabIndex = 11;
            this.name.Text = "Nume Utilizator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descriere";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbName.Location = new System.Drawing.Point(207, 217);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(154, 22);
            this.tbName.TabIndex = 12;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(31, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Adaugare imagine";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(468, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormAdaugareAnunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.price);
            this.Controls.Add(this.adaugare);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.categorie);
            this.Controls.Add(this.pret);
            this.Controls.Add(this.descriere);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.label1);
            this.Name = "FormAdaugareAnunt";
            this.Text = "FormAdaugareAnunt";
            this.Load += new System.EventHandler(this.FormAdaugareAnunt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titlu;
        private System.Windows.Forms.Label descriere;
        private System.Windows.Forms.Label pret;
        private System.Windows.Forms.Label categorie;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button adaugare;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}