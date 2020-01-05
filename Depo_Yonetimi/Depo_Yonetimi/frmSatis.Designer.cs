namespace Depo_Yonetimi
{
    partial class frmSatis
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
            this.label1 = new System.Windows.Forms.Label();
            this.depo_yonetimiDataSet = new Depo_Yonetimi.depo_yonetimiDataSet();
            this.depoyonetimiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTableAdapter = new Depo_Yonetimi.depo_yonetimiDataSetTableAdapters.stokTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.depo_yonetimiDataSet1 = new Depo_Yonetimi.depo_yonetimiDataSet1();
            this.depoyonetimiDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.depo_yonetimiDataSet2 = new Depo_Yonetimi.depo_yonetimiDataSet2();
            this.stokurunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok_urunTableAdapter = new Depo_Yonetimi.depo_yonetimiDataSet2TableAdapters.stok_urunTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.depo_yonetimiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoyonetimiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_yonetimiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoyonetimiDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_yonetimiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokurunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Seçiniz :";
            // 
            // depo_yonetimiDataSet
            // 
            this.depo_yonetimiDataSet.DataSetName = "depo_yonetimiDataSet";
            this.depo_yonetimiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depoyonetimiDataSetBindingSource
            // 
            this.depoyonetimiDataSetBindingSource.DataSource = this.depo_yonetimiDataSet;
            this.depoyonetimiDataSetBindingSource.Position = 0;
            // 
            // stokBindingSource
            // 
            this.stokBindingSource.DataMember = "stok";
            this.stokBindingSource.DataSource = this.depoyonetimiDataSetBindingSource;
            // 
            // stokTableAdapter
            // 
            this.stokTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Satış Miktarı Giriniz :";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(119, 47);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtMiktar.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fiyat Giriniz :";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(91, 80);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Satış Tarihi :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // depo_yonetimiDataSet1
            // 
            this.depo_yonetimiDataSet1.DataSetName = "depo_yonetimiDataSet1";
            this.depo_yonetimiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depoyonetimiDataSet1BindingSource
            // 
            this.depoyonetimiDataSet1BindingSource.DataSource = this.depo_yonetimiDataSet1;
            this.depoyonetimiDataSet1BindingSource.Position = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.stokurunBindingSource;
            this.comboBox1.DisplayMember = "isim";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "isim";
            // 
            // depo_yonetimiDataSet2
            // 
            this.depo_yonetimiDataSet2.DataSetName = "depo_yonetimiDataSet2";
            this.depo_yonetimiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokurunBindingSource
            // 
            this.stokurunBindingSource.DataMember = "stok_urun";
            this.stokurunBindingSource.DataSource = this.depo_yonetimiDataSet2;
            // 
            // stok_urunTableAdapter
            // 
            this.stok_urunTableAdapter.ClearBeforeFill = true;
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 169);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSatis";
            this.Text = "frmSatis";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depo_yonetimiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoyonetimiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_yonetimiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoyonetimiDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_yonetimiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokurunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource depoyonetimiDataSetBindingSource;
        private depo_yonetimiDataSet depo_yonetimiDataSet;
        private System.Windows.Forms.BindingSource stokBindingSource;
        private depo_yonetimiDataSetTableAdapters.stokTableAdapter stokTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource depoyonetimiDataSet1BindingSource;
        private depo_yonetimiDataSet1 depo_yonetimiDataSet1;
        private System.Windows.Forms.ComboBox comboBox1;
        private depo_yonetimiDataSet2 depo_yonetimiDataSet2;
        private System.Windows.Forms.BindingSource stokurunBindingSource;
        private depo_yonetimiDataSet2TableAdapters.stok_urunTableAdapter stok_urunTableAdapter;
    }
}