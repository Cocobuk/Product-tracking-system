
namespace Urun_Stok_Takip_Sistemi
{
    partial class CalisanCikar
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calisanTCNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sicilNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calisanEklemeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.urun_Stok_Takip_SistemiDataSet6 = new Urun_Stok_Takip_Sistemi.Urun_Stok_Takip_SistemiDataSet6();
            this.calisanEklemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urun_Stok_Takip_SistemiDataSet4 = new Urun_Stok_Takip_Sistemi.Urun_Stok_Takip_SistemiDataSet4();
            this.calisan_EklemeTableAdapter = new Urun_Stok_Takip_Sistemi.Urun_Stok_Takip_SistemiDataSet4TableAdapters.Calisan_EklemeTableAdapter();
            this.calisan_EklemeTableAdapter1 = new Urun_Stok_Takip_Sistemi.Urun_Stok_Takip_SistemiDataSet6TableAdapters.Calisan_EklemeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanEklemeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urun_Stok_Takip_SistemiDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanEklemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urun_Stok_Takip_SistemiDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışan TC_No:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(601, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Çalışan Çıkar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 30);
            this.textBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calisanTCNoDataGridViewTextBoxColumn,
            this.sicilNoDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calisanEklemeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(114, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(684, 332);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // calisanTCNoDataGridViewTextBoxColumn
            // 
            this.calisanTCNoDataGridViewTextBoxColumn.DataPropertyName = "Calisan_TC_No";
            this.calisanTCNoDataGridViewTextBoxColumn.HeaderText = "Calisan_TC_No";
            this.calisanTCNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.calisanTCNoDataGridViewTextBoxColumn.Name = "calisanTCNoDataGridViewTextBoxColumn";
            this.calisanTCNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // sicilNoDataGridViewTextBoxColumn
            // 
            this.sicilNoDataGridViewTextBoxColumn.DataPropertyName = "Sicil_No";
            this.sicilNoDataGridViewTextBoxColumn.HeaderText = "Sicil_No";
            this.sicilNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sicilNoDataGridViewTextBoxColumn.Name = "sicilNoDataGridViewTextBoxColumn";
            this.sicilNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            this.cinsiyetDataGridViewTextBoxColumn.Width = 125;
            // 
            // calisanEklemeBindingSource1
            // 
            this.calisanEklemeBindingSource1.DataMember = "Calisan_Ekleme";
            this.calisanEklemeBindingSource1.DataSource = this.urun_Stok_Takip_SistemiDataSet6;
            // 
            // urun_Stok_Takip_SistemiDataSet6
            // 
            this.urun_Stok_Takip_SistemiDataSet6.DataSetName = "Urun_Stok_Takip_SistemiDataSet6";
            this.urun_Stok_Takip_SistemiDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calisanEklemeBindingSource
            // 
            this.calisanEklemeBindingSource.DataMember = "Calisan_Ekleme";
            this.calisanEklemeBindingSource.DataSource = this.urun_Stok_Takip_SistemiDataSet4;
            // 
            // urun_Stok_Takip_SistemiDataSet4
            // 
            this.urun_Stok_Takip_SistemiDataSet4.DataSetName = "Urun_Stok_Takip_SistemiDataSet4";
            this.urun_Stok_Takip_SistemiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calisan_EklemeTableAdapter
            // 
            this.calisan_EklemeTableAdapter.ClearBeforeFill = true;
            // 
            // calisan_EklemeTableAdapter1
            // 
            this.calisan_EklemeTableAdapter1.ClearBeforeFill = true;
            // 
            // CalisanCikar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(844, 589);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalisanCikar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalisanCikar";
            this.Load += new System.EventHandler(this.CalisanCikar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanEklemeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urun_Stok_Takip_SistemiDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanEklemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urun_Stok_Takip_SistemiDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Urun_Stok_Takip_SistemiDataSet4 urun_Stok_Takip_SistemiDataSet4;
        private System.Windows.Forms.BindingSource calisanEklemeBindingSource;
        private Urun_Stok_Takip_SistemiDataSet4TableAdapters.Calisan_EklemeTableAdapter calisan_EklemeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn calisanTCNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicilNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private Urun_Stok_Takip_SistemiDataSet6 urun_Stok_Takip_SistemiDataSet6;
        private System.Windows.Forms.BindingSource calisanEklemeBindingSource1;
        private Urun_Stok_Takip_SistemiDataSet6TableAdapters.Calisan_EklemeTableAdapter calisan_EklemeTableAdapter1;
    }
}