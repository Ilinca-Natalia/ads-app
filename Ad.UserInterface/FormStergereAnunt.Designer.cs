namespace Ad.UserInterface
{
    partial class FormStergereAnunt
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.stergere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stergere Anunt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume Utilizator";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbName.Location = new System.Drawing.Point(29, 167);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(151, 22);
            this.tbName.TabIndex = 2;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.name.Location = new System.Drawing.Point(311, 124);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(213, 56);
            this.name.TabIndex = 3;
            this.name.Text = "Afisare Anunturi";
            this.name.UseVisualStyleBackColor = false;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(29, 226);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(432, 194);
            this.dgv.TabIndex = 4;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // stergere
            // 
            this.stergere.BackColor = System.Drawing.Color.DarkGray;
            this.stergere.Location = new System.Drawing.Point(546, 271);
            this.stergere.Name = "stergere";
            this.stergere.Size = new System.Drawing.Size(222, 64);
            this.stergere.TabIndex = 5;
            this.stergere.Text = "Stergeti Anuntul";
            this.stergere.UseVisualStyleBackColor = false;
            this.stergere.Click += new System.EventHandler(this.stergere_Click);
            // 
            // FormStergereAnunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stergere);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.name);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormStergereAnunt";
            this.Text = "FormStergereAnunt";
            this.Load += new System.EventHandler(this.FormStergereAnunt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button name;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button stergere;
    }
}