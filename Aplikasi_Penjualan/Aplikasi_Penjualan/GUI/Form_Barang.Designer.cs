namespace Aplikasi_Penjualan.GUI
{
    partial class Form_Barang
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBoxStokBarang = new TextBox();
            textBoxhargaBarang = new TextBox();
            comboBoxSatuan = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBoxNamaBarang = new TextBox();
            label2 = new Label();
            textBoxKodeBarang = new TextBox();
            groupBox2 = new GroupBox();
            buttonHapus = new Button();
            buttonUbah = new Button();
            buttonSimpan = new Button();
            buttonBaru = new Button();
            groupBox3 = new GroupBox();
            dgvDataBarang = new DataGridView();
            kode_barang = new DataGridViewTextBoxColumn();
            nama_barang = new DataGridViewTextBoxColumn();
            harga_barang = new DataGridViewTextBoxColumn();
            stok = new DataGridViewTextBoxColumn();
            satuan = new DataGridViewTextBoxColumn();
            textBoxSearch = new TextBox();
            label6 = new Label();
            buttonCari = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataBarang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 38);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 0;
            label1.Text = "Kode Barang";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxStokBarang);
            groupBox1.Controls.Add(textBoxhargaBarang);
            groupBox1.Controls.Add(comboBoxSatuan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxNamaBarang);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxKodeBarang);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(18, 33);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(452, 260);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = ":: From Barang ::";
            // 
            // textBoxStokBarang
            // 
            textBoxStokBarang.Location = new Point(158, 161);
            textBoxStokBarang.Margin = new Padding(3, 2, 3, 2);
            textBoxStokBarang.Name = "textBoxStokBarang";
            textBoxStokBarang.Size = new Size(271, 29);
            textBoxStokBarang.TabIndex = 11;
            // 
            // textBoxhargaBarang
            // 
            textBoxhargaBarang.Location = new Point(158, 122);
            textBoxhargaBarang.Margin = new Padding(3, 2, 3, 2);
            textBoxhargaBarang.Name = "textBoxhargaBarang";
            textBoxhargaBarang.Size = new Size(271, 29);
            textBoxhargaBarang.TabIndex = 10;
            // 
            // comboBoxSatuan
            // 
            comboBoxSatuan.FormattingEnabled = true;
            comboBoxSatuan.Items.AddRange(new object[] { "pcs", "box" });
            comboBoxSatuan.Location = new Point(158, 204);
            comboBoxSatuan.Margin = new Padding(3, 2, 3, 2);
            comboBoxSatuan.Name = "comboBoxSatuan";
            comboBoxSatuan.Size = new Size(271, 29);
            comboBoxSatuan.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 206);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 8;
            label5.Text = "Satuan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 164);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 6;
            label4.Text = "Stok";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 122);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 4;
            label3.Text = "Harga Barang";
            // 
            // textBoxNamaBarang
            // 
            textBoxNamaBarang.Location = new Point(158, 79);
            textBoxNamaBarang.Margin = new Padding(3, 2, 3, 2);
            textBoxNamaBarang.Name = "textBoxNamaBarang";
            textBoxNamaBarang.Size = new Size(271, 29);
            textBoxNamaBarang.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 79);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 2;
            label2.Text = "Nama barang";
            // 
            // textBoxKodeBarang
            // 
            textBoxKodeBarang.Location = new Point(158, 38);
            textBoxKodeBarang.Margin = new Padding(3, 2, 3, 2);
            textBoxKodeBarang.Name = "textBoxKodeBarang";
            textBoxKodeBarang.Size = new Size(271, 29);
            textBoxKodeBarang.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonHapus);
            groupBox2.Controls.Add(buttonUbah);
            groupBox2.Controls.Add(buttonSimpan);
            groupBox2.Controls.Add(buttonBaru);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(23, 320);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(447, 147);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = ":: Proses ::";
            // 
            // buttonHapus
            // 
            buttonHapus.Location = new Point(244, 86);
            buttonHapus.Margin = new Padding(3, 2, 3, 2);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(198, 45);
            buttonHapus.TabIndex = 3;
            buttonHapus.Text = "Hapus";
            buttonHapus.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHapus.UseVisualStyleBackColor = true;
            // 
            // buttonUbah
            // 
            buttonUbah.Location = new Point(16, 86);
            buttonUbah.Margin = new Padding(3, 2, 3, 2);
            buttonUbah.Name = "buttonUbah";
            buttonUbah.Size = new Size(198, 45);
            buttonUbah.TabIndex = 2;
            buttonUbah.Text = "Ubah";
            buttonUbah.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonUbah.UseVisualStyleBackColor = true;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Location = new Point(244, 36);
            buttonSimpan.Margin = new Padding(3, 2, 3, 2);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(198, 45);
            buttonSimpan.TabIndex = 1;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSimpan.UseVisualStyleBackColor = true;
            buttonSimpan.Click += button1_Click;
            // 
            // buttonBaru
            // 
            buttonBaru.Location = new Point(16, 36);
            buttonBaru.Margin = new Padding(3, 2, 3, 2);
            buttonBaru.Name = "buttonBaru";
            buttonBaru.Size = new Size(198, 45);
            buttonBaru.TabIndex = 0;
            buttonBaru.Text = "Baru";
            buttonBaru.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonBaru.UseVisualStyleBackColor = true;
            buttonBaru.Click += buttonBaru_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonCari);
            groupBox3.Controls.Add(dgvDataBarang);
            groupBox3.Controls.Add(textBoxSearch);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(491, 33);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(748, 434);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = ":: Data Barang::";
            // 
            // dgvDataBarang
            // 
            dgvDataBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataBarang.Columns.AddRange(new DataGridViewColumn[] { kode_barang, nama_barang, harga_barang, stok, satuan });
            dgvDataBarang.Location = new Point(29, 80);
            dgvDataBarang.Margin = new Padding(3, 2, 3, 2);
            dgvDataBarang.Name = "dgvDataBarang";
            dgvDataBarang.RowHeadersWidth = 51;
            dgvDataBarang.RowTemplate.Height = 29;
            dgvDataBarang.Size = new Size(700, 338);
            dgvDataBarang.TabIndex = 2;
            // 
            // kode_barang
            // 
            kode_barang.DataPropertyName = "kode";
            kode_barang.HeaderText = "Kode";
            kode_barang.MinimumWidth = 6;
            kode_barang.Name = "kode_barang";
            kode_barang.ReadOnly = true;
            kode_barang.Width = 125;
            // 
            // nama_barang
            // 
            nama_barang.DataPropertyName = "nama";
            nama_barang.HeaderText = "Nama Barang";
            nama_barang.MinimumWidth = 6;
            nama_barang.Name = "nama_barang";
            nama_barang.ReadOnly = true;
            nama_barang.Width = 250;
            // 
            // harga_barang
            // 
            harga_barang.DataPropertyName = "harga";
            harga_barang.HeaderText = "Harga";
            harga_barang.MinimumWidth = 6;
            harga_barang.Name = "harga_barang";
            harga_barang.ReadOnly = true;
            harga_barang.Width = 125;
            // 
            // stok
            // 
            stok.DataPropertyName = "stok";
            stok.HeaderText = "Stok";
            stok.MinimumWidth = 6;
            stok.Name = "stok";
            stok.ReadOnly = true;
            stok.Width = 125;
            // 
            // satuan
            // 
            satuan.DataPropertyName = "satuan";
            satuan.HeaderText = "Satuan";
            satuan.MinimumWidth = 6;
            satuan.Name = "satuan";
            satuan.ReadOnly = true;
            satuan.Width = 125;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(258, 38);
            textBoxSearch.Margin = new Padding(3, 2, 3, 2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(261, 29);
            textBoxSearch.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(29, 38);
            label6.Name = "label6";
            label6.Size = new Size(195, 21);
            label6.TabIndex = 0;
            label6.Text = "Cari Barang (Kode/Nama)";
            // 
            // buttonCari
            // 
            buttonCari.Location = new Point(542, 38);
            buttonCari.Name = "buttonCari";
            buttonCari.Size = new Size(82, 29);
            buttonCari.TabIndex = 3;
            buttonCari.Text = "Cari";
            buttonCari.UseVisualStyleBackColor = true;
            buttonCari.Click += buttonCari_Click;
            // 
            // Form_Barang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 490);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Barang";
            Text = "Form_Barang";
            Load += Form_Barang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataBarang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBoxKodeBarang;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBoxNamaBarang;
        private Label label2;
        private ComboBox comboBoxSatuan;
        private GroupBox groupBox2;
        private Button buttonBaru;
        private Button buttonSimpan;
        private Button buttonHapus;
        private Button buttonUbah;
        private GroupBox groupBox3;
        private DataGridView dgvDataBarang;
        private TextBox textBoxSearch;
        private Label label6;
        private TextBox textBoxStokBarang;
        private TextBox textBoxhargaBarang;
        private DataGridViewTextBoxColumn kode_barang;
        private DataGridViewTextBoxColumn nama_barang;
        private DataGridViewTextBoxColumn harga_barang;
        private DataGridViewTextBoxColumn stok;
        private DataGridViewTextBoxColumn satuan;
        private Button buttonCari;
    }
}