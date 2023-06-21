namespace EntityFramework_DBFirstYaklasimiOrnek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstBolgeler = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            btnEkle = new Button();
            dgvBolgeler = new DataGridView();
            btnSil = new Button();
            btnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBolgeler).BeginInit();
            SuspendLayout();
            // 
            // lstBolgeler
            // 
            lstBolgeler.DisplayMember = "RegionDescription";
            lstBolgeler.FormattingEnabled = true;
            lstBolgeler.ItemHeight = 15;
            lstBolgeler.Location = new Point(851, 40);
            lstBolgeler.Name = "lstBolgeler";
            lstBolgeler.Size = new Size(220, 334);
            lstBolgeler.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 63);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "BolgeId";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 108);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Bolge Adı:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(278, 409);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(90, 40);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvBolgeler
            // 
            dgvBolgeler.AllowUserToAddRows = false;
            dgvBolgeler.AllowUserToDeleteRows = false;
            dgvBolgeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBolgeler.Location = new Point(278, 42);
            dgvBolgeler.Name = "dgvBolgeler";
            dgvBolgeler.ReadOnly = true;
            dgvBolgeler.RowTemplate.Height = 25;
            dgvBolgeler.Size = new Size(544, 332);
            dgvBolgeler.TabIndex = 6;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(505, 409);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(90, 40);
            btnSil.TabIndex = 7;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(732, 409);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(90, 40);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 472);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(dgvBolgeler);
            Controls.Add(btnEkle);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lstBolgeler);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvBolgeler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstBolgeler;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button btnEkle;
        private DataGridView dgvBolgeler;
        private Button btnSil;
        private Button btnGuncelle;
    }
}