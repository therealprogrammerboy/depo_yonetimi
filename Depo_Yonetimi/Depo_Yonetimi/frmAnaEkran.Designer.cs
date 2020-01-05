namespace Depo_Yonetimi
{
    partial class frmAnaEkran
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
            this.gelenUrunKayit = new System.Windows.Forms.Button();
            this.btnArama = new System.Windows.Forms.Button();
            this.stok = new System.Windows.Forms.Button();
            this.satis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gelenUrunKayit
            // 
            this.gelenUrunKayit.Location = new System.Drawing.Point(12, 12);
            this.gelenUrunKayit.Name = "gelenUrunKayit";
            this.gelenUrunKayit.Size = new System.Drawing.Size(127, 56);
            this.gelenUrunKayit.TabIndex = 0;
            this.gelenUrunKayit.Text = "Gelen Ürün Kayıt";
            this.gelenUrunKayit.UseVisualStyleBackColor = true;
            this.gelenUrunKayit.Click += new System.EventHandler(this.gelenUrunKayit_Click);
            // 
            // btnArama
            // 
            this.btnArama.Location = new System.Drawing.Point(145, 74);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(127, 56);
            this.btnArama.TabIndex = 1;
            this.btnArama.Text = "Ürün Arama";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // stok
            // 
            this.stok.Location = new System.Drawing.Point(12, 74);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(127, 56);
            this.stok.TabIndex = 2;
            this.stok.Text = "Ürün Stok";
            this.stok.UseVisualStyleBackColor = true;
            this.stok.Click += new System.EventHandler(this.stok_Click);
            // 
            // satis
            // 
            this.satis.Location = new System.Drawing.Point(145, 12);
            this.satis.Name = "satis";
            this.satis.Size = new System.Drawing.Size(127, 56);
            this.satis.TabIndex = 3;
            this.satis.Text = "Ürün Satış";
            this.satis.UseVisualStyleBackColor = true;
            this.satis.Click += new System.EventHandler(this.satis_Click);
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 145);
            this.Controls.Add(this.satis);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.gelenUrunKayit);
            this.Name = "frmAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlemler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gelenUrunKayit;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button stok;
        private System.Windows.Forms.Button satis;
    }
}