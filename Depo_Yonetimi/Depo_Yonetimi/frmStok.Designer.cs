namespace Depo_Yonetimi
{
    partial class frmStok
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depo_yonetimiDataSet = new Depo_Yonetimi.depo_yonetimiDataSet();
            this.stokTableAdapter = new Depo_Yonetimi.depo_yonetimiDataSetTableAdapters.stokTableAdapter();
            this.stokBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.depo_yonetimiDataSet1 = new Depo_Yonetimi.depo_yonetimiDataSet1();
            this.stokurunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok_urunTableAdapter = new Depo_Yonetimi.depo_yonetimiDataSet1TableAdapters.stok_urunTableAdapter();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_yonetimiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_yonetimiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokurunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adetDataGridViewTextBoxColumn,
            this.isimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stokurunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 448);
            this.dataGridView1.TabIndex = 0;
            // 
            // stokBindingSource
            // 
            this.stokBindingSource.DataMember = "stok";
            this.stokBindingSource.DataSource = this.depo_yonetimiDataSet;
            // 
            // depo_yonetimiDataSet
            // 
            this.depo_yonetimiDataSet.DataSetName = "depo_yonetimiDataSet";
            this.depo_yonetimiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokTableAdapter
            // 
            this.stokTableAdapter.ClearBeforeFill = true;
            // 
            // stokBindingSource1
            // 
            this.stokBindingSource1.DataMember = "stok";
            this.stokBindingSource1.DataSource = this.depo_yonetimiDataSet;
            // 
            // depo_yonetimiDataSet1
            // 
            this.depo_yonetimiDataSet1.DataSetName = "depo_yonetimiDataSet1";
            this.depo_yonetimiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokurunBindingSource
            // 
            this.stokurunBindingSource.DataMember = "stok_urun";
            this.stokurunBindingSource.DataSource = this.depo_yonetimiDataSet1;
            // 
            // stok_urunTableAdapter
            // 
            this.stok_urunTableAdapter.ClearBeforeFill = true;
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "isim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "isim";
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            // 
            // frmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmStok";
            this.Text = "Stoklar";
            this.Load += new System.EventHandler(this.frmStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_yonetimiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_yonetimiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokurunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private depo_yonetimiDataSet depo_yonetimiDataSet;
        private System.Windows.Forms.BindingSource stokBindingSource;
        private depo_yonetimiDataSetTableAdapters.stokTableAdapter stokTableAdapter;
        private System.Windows.Forms.BindingSource stokBindingSource1;
        private depo_yonetimiDataSet1 depo_yonetimiDataSet1;
        private System.Windows.Forms.BindingSource stokurunBindingSource;
        private depo_yonetimiDataSet1TableAdapters.stok_urunTableAdapter stok_urunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
    }
}