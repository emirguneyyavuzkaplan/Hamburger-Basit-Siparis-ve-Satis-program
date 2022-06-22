namespace _21_OOP_Hamburgerci
{
    partial class FrmExtraEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExtraAdi = new System.Windows.Forms.TextBox();
            this.btnExtraKaydet = new System.Windows.Forms.Button();
            this.nmrExtraFiyat = new System.Windows.Forms.NumericUpDown();
            this.lblExtraFiyat = new System.Windows.Forms.Label();
            this.lblAxtraAdı = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrExtraFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExtraAdi);
            this.groupBox1.Controls.Add(this.btnExtraKaydet);
            this.groupBox1.Controls.Add(this.nmrExtraFiyat);
            this.groupBox1.Controls.Add(this.lblExtraFiyat);
            this.groupBox1.Controls.Add(this.lblAxtraAdı);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 197);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra Ekle";
            // 
            // txtExtraAdi
            // 
            this.txtExtraAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraAdi.Location = new System.Drawing.Point(116, 41);
            this.txtExtraAdi.Name = "txtExtraAdi";
            this.txtExtraAdi.Size = new System.Drawing.Size(171, 20);
            this.txtExtraAdi.TabIndex = 11;
            // 
            // btnExtraKaydet
            // 
            this.btnExtraKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExtraKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraKaydet.ForeColor = System.Drawing.Color.White;
            this.btnExtraKaydet.Location = new System.Drawing.Point(116, 144);
            this.btnExtraKaydet.Name = "btnExtraKaydet";
            this.btnExtraKaydet.Size = new System.Drawing.Size(171, 34);
            this.btnExtraKaydet.TabIndex = 10;
            this.btnExtraKaydet.Text = "Kaydet";
            this.btnExtraKaydet.UseVisualStyleBackColor = false;
            this.btnExtraKaydet.Click += new System.EventHandler(this.btnExtraKaydet_Click);
            // 
            // nmrExtraFiyat
            // 
            this.nmrExtraFiyat.DecimalPlaces = 2;
            this.nmrExtraFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrExtraFiyat.Location = new System.Drawing.Point(116, 87);
            this.nmrExtraFiyat.Name = "nmrExtraFiyat";
            this.nmrExtraFiyat.Size = new System.Drawing.Size(62, 20);
            this.nmrExtraFiyat.TabIndex = 9;
            this.nmrExtraFiyat.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblExtraFiyat
            // 
            this.lblExtraFiyat.AutoSize = true;
            this.lblExtraFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraFiyat.Location = new System.Drawing.Point(21, 87);
            this.lblExtraFiyat.Name = "lblExtraFiyat";
            this.lblExtraFiyat.Size = new System.Drawing.Size(37, 13);
            this.lblExtraFiyat.TabIndex = 8;
            this.lblExtraFiyat.Text = "Fiyatı";
            // 
            // lblAxtraAdı
            // 
            this.lblAxtraAdı.AutoSize = true;
            this.lblAxtraAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAxtraAdı.Location = new System.Drawing.Point(21, 44);
            this.lblAxtraAdı.Name = "lblAxtraAdı";
            this.lblAxtraAdı.Size = new System.Drawing.Size(58, 13);
            this.lblAxtraAdı.TabIndex = 8;
            this.lblAxtraAdı.Text = "Extra Adı";
            // 
            // FrmExtraEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 268);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExtraEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmExtraEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrExtraFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtExtraAdi;
        private System.Windows.Forms.Button btnExtraKaydet;
        private System.Windows.Forms.NumericUpDown nmrExtraFiyat;
        private System.Windows.Forms.Label lblExtraFiyat;
        private System.Windows.Forms.Label lblAxtraAdı;
    }
}