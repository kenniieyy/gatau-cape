namespace UAS_PEMVIS.Resources
{
    partial class Barang
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
            groupBoxProses = new GroupBox();
            buttonHapus = new Button();
            buttonSimpan = new Button();
            buttonRefresh = new Button();
            buttonBaru = new Button();
            groupBoxFormBarang = new GroupBox();
            textBoxHarga = new TextBox();
            textBoxNamaBarang = new TextBox();
            textBoxIDBarang = new TextBox();
            labelUkuran = new Label();
            labelHarga = new Label();
            labelNamaBarang = new Label();
            labelIDBarang = new Label();
            labelJudulBarang = new Label();
            labelStok = new Label();
            labelGambar = new Label();
            textBoxStok = new TextBox();
            comboBoxUkuran = new ComboBox();
            pictureBox = new PictureBox();
            buttonBrowse = new Button();
            groupBoxMenu = new GroupBox();
            buttonHome = new Button();
            buttonTransaksi = new Button();
            buttonKasir = new Button();
            buttonKeluar = new Button();
            groupBoxDataKasir = new GroupBox();
            dataGridViewDataKasir = new DataGridView();
            textBoxCariDataKasir = new TextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBoxProses.SuspendLayout();
            groupBoxFormBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBoxMenu.SuspendLayout();
            groupBoxDataKasir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataKasir).BeginInit();
            SuspendLayout();
            // 
            // groupBoxProses
            // 
            groupBoxProses.BackColor = Color.CadetBlue;
            groupBoxProses.Controls.Add(buttonHapus);
            groupBoxProses.Controls.Add(buttonSimpan);
            groupBoxProses.Controls.Add(buttonRefresh);
            groupBoxProses.Controls.Add(buttonBaru);
            groupBoxProses.Location = new Point(12, 526);
            groupBoxProses.Name = "groupBoxProses";
            groupBoxProses.Size = new Size(342, 116);
            groupBoxProses.TabIndex = 8;
            groupBoxProses.TabStop = false;
            groupBoxProses.Text = "Proses";
            // 
            // buttonHapus
            // 
            buttonHapus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHapus.Image = Properties.Resources.icon_delete;
            buttonHapus.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHapus.Location = new Point(238, 71);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(98, 38);
            buttonHapus.TabIndex = 3;
            buttonHapus.Text = "HAPUS";
            buttonHapus.TextAlign = ContentAlignment.MiddleRight;
            buttonHapus.UseVisualStyleBackColor = true;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSimpan.Image = Properties.Resources.icon_simpan;
            buttonSimpan.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSimpan.Location = new Point(10, 71);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(98, 38);
            buttonSimpan.TabIndex = 2;
            buttonSimpan.Text = "SIMPAN";
            buttonSimpan.TextAlign = ContentAlignment.MiddleRight;
            buttonSimpan.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRefresh.Image = Properties.Resources.icon_refresh;
            buttonRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRefresh.Location = new Point(238, 22);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(98, 38);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "REFRESH";
            buttonRefresh.TextAlign = ContentAlignment.MiddleRight;
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonBaru
            // 
            buttonBaru.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonBaru.Image = Properties.Resources.icon_baru;
            buttonBaru.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBaru.Location = new Point(10, 22);
            buttonBaru.Name = "buttonBaru";
            buttonBaru.Size = new Size(98, 38);
            buttonBaru.TabIndex = 0;
            buttonBaru.Text = "BARU";
            buttonBaru.TextAlign = ContentAlignment.MiddleRight;
            buttonBaru.UseVisualStyleBackColor = true;
            // 
            // groupBoxFormBarang
            // 
            groupBoxFormBarang.BackColor = Color.CadetBlue;
            groupBoxFormBarang.Controls.Add(buttonBrowse);
            groupBoxFormBarang.Controls.Add(pictureBox);
            groupBoxFormBarang.Controls.Add(comboBoxUkuran);
            groupBoxFormBarang.Controls.Add(textBoxStok);
            groupBoxFormBarang.Controls.Add(labelGambar);
            groupBoxFormBarang.Controls.Add(labelStok);
            groupBoxFormBarang.Controls.Add(textBoxHarga);
            groupBoxFormBarang.Controls.Add(textBoxNamaBarang);
            groupBoxFormBarang.Controls.Add(textBoxIDBarang);
            groupBoxFormBarang.Controls.Add(labelUkuran);
            groupBoxFormBarang.Controls.Add(labelHarga);
            groupBoxFormBarang.Controls.Add(labelNamaBarang);
            groupBoxFormBarang.Controls.Add(labelIDBarang);
            groupBoxFormBarang.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxFormBarang.Location = new Point(12, 95);
            groupBoxFormBarang.Name = "groupBoxFormBarang";
            groupBoxFormBarang.Size = new Size(342, 395);
            groupBoxFormBarang.TabIndex = 7;
            groupBoxFormBarang.TabStop = false;
            groupBoxFormBarang.Text = "Form Barang";
            // 
            // textBoxHarga
            // 
            textBoxHarga.Location = new Point(118, 119);
            textBoxHarga.Name = "textBoxHarga";
            textBoxHarga.Size = new Size(205, 25);
            textBoxHarga.TabIndex = 6;
            // 
            // textBoxNamaBarang
            // 
            textBoxNamaBarang.Location = new Point(118, 77);
            textBoxNamaBarang.Name = "textBoxNamaBarang";
            textBoxNamaBarang.Size = new Size(205, 25);
            textBoxNamaBarang.TabIndex = 5;
            // 
            // textBoxIDBarang
            // 
            textBoxIDBarang.Location = new Point(118, 36);
            textBoxIDBarang.Name = "textBoxIDBarang";
            textBoxIDBarang.Size = new Size(205, 25);
            textBoxIDBarang.TabIndex = 4;
            // 
            // labelUkuran
            // 
            labelUkuran.AutoSize = true;
            labelUkuran.Location = new Point(10, 160);
            labelUkuran.Name = "labelUkuran";
            labelUkuran.Size = new Size(49, 17);
            labelUkuran.TabIndex = 3;
            labelUkuran.Text = "Ukuran";
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.Location = new Point(10, 119);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(44, 17);
            labelHarga.TabIndex = 2;
            labelHarga.Text = "Harga";
            // 
            // labelNamaBarang
            // 
            labelNamaBarang.AutoSize = true;
            labelNamaBarang.Location = new Point(10, 77);
            labelNamaBarang.Name = "labelNamaBarang";
            labelNamaBarang.Size = new Size(88, 17);
            labelNamaBarang.TabIndex = 1;
            labelNamaBarang.Text = "Nama Barang";
            // 
            // labelIDBarang
            // 
            labelIDBarang.AutoSize = true;
            labelIDBarang.Location = new Point(10, 36);
            labelIDBarang.Name = "labelIDBarang";
            labelIDBarang.Size = new Size(65, 17);
            labelIDBarang.TabIndex = 0;
            labelIDBarang.Text = "ID Barang";
            // 
            // labelJudulBarang
            // 
            labelJudulBarang.AutoSize = true;
            labelJudulBarang.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJudulBarang.Location = new Point(46, 11);
            labelJudulBarang.Name = "labelJudulBarang";
            labelJudulBarang.Size = new Size(288, 22);
            labelJudulBarang.TabIndex = 6;
            labelJudulBarang.Text = "DATA BARANG FLOWER MARKET";
            // 
            // labelStok
            // 
            labelStok.AutoSize = true;
            labelStok.Location = new Point(10, 205);
            labelStok.Name = "labelStok";
            labelStok.Size = new Size(33, 17);
            labelStok.TabIndex = 8;
            labelStok.Text = "Stok";
            // 
            // labelGambar
            // 
            labelGambar.AutoSize = true;
            labelGambar.Location = new Point(10, 247);
            labelGambar.Name = "labelGambar";
            labelGambar.Size = new Size(55, 17);
            labelGambar.TabIndex = 9;
            labelGambar.Text = "Gambar";
            // 
            // textBoxStok
            // 
            textBoxStok.Location = new Point(117, 205);
            textBoxStok.Name = "textBoxStok";
            textBoxStok.Size = new Size(205, 25);
            textBoxStok.TabIndex = 10;
            // 
            // comboBoxUkuran
            // 
            comboBoxUkuran.FormattingEnabled = true;
            comboBoxUkuran.Location = new Point(117, 160);
            comboBoxUkuran.Name = "comboBoxUkuran";
            comboBoxUkuran.Size = new Size(206, 25);
            comboBoxUkuran.TabIndex = 11;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(117, 247);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(89, 87);
            pictureBox.TabIndex = 12;
            pictureBox.TabStop = false;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonBrowse.Image = Properties.Resources.icon_browse;
            buttonBrowse.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBrowse.Location = new Point(117, 340);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(98, 38);
            buttonBrowse.TabIndex = 13;
            buttonBrowse.Text = "Browse";
            buttonBrowse.TextAlign = ContentAlignment.MiddleRight;
            buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // groupBoxMenu
            // 
            groupBoxMenu.BackColor = Color.CadetBlue;
            groupBoxMenu.Controls.Add(buttonHome);
            groupBoxMenu.Controls.Add(buttonTransaksi);
            groupBoxMenu.Controls.Add(buttonKasir);
            groupBoxMenu.Controls.Add(buttonKeluar);
            groupBoxMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxMenu.Location = new Point(395, 11);
            groupBoxMenu.Name = "groupBoxMenu";
            groupBoxMenu.Size = new Size(535, 70);
            groupBoxMenu.TabIndex = 9;
            groupBoxMenu.TabStop = false;
            groupBoxMenu.Text = "Menu";
            // 
            // buttonHome
            // 
            buttonHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonHome.Image = Properties.Resources.icon_home;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(59, 22);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(113, 38);
            buttonHome.TabIndex = 9;
            buttonHome.Text = "HOME";
            buttonHome.TextAlign = ContentAlignment.MiddleRight;
            buttonHome.UseVisualStyleBackColor = true;
            // 
            // buttonTransaksi
            // 
            buttonTransaksi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonTransaksi.Image = Properties.Resources.icon_transaksi;
            buttonTransaksi.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTransaksi.Location = new Point(178, 22);
            buttonTransaksi.Name = "buttonTransaksi";
            buttonTransaksi.Size = new Size(113, 38);
            buttonTransaksi.TabIndex = 8;
            buttonTransaksi.Text = "TRANSAKSI";
            buttonTransaksi.TextAlign = ContentAlignment.MiddleRight;
            buttonTransaksi.UseVisualStyleBackColor = true;
            // 
            // buttonKasir
            // 
            buttonKasir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonKasir.Image = Properties.Resources.icon_kasir;
            buttonKasir.ImageAlign = ContentAlignment.MiddleLeft;
            buttonKasir.Location = new Point(297, 22);
            buttonKasir.Name = "buttonKasir";
            buttonKasir.Size = new Size(113, 38);
            buttonKasir.TabIndex = 7;
            buttonKasir.Text = "KASIR";
            buttonKasir.TextAlign = ContentAlignment.MiddleRight;
            buttonKasir.UseVisualStyleBackColor = true;
            // 
            // buttonKeluar
            // 
            buttonKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonKeluar.Image = Properties.Resources.icon_exit;
            buttonKeluar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonKeluar.Location = new Point(416, 22);
            buttonKeluar.Name = "buttonKeluar";
            buttonKeluar.Size = new Size(113, 38);
            buttonKeluar.TabIndex = 1;
            buttonKeluar.Text = "KELUAR";
            buttonKeluar.TextAlign = ContentAlignment.MiddleRight;
            buttonKeluar.UseVisualStyleBackColor = true;
            // 
            // groupBoxDataKasir
            // 
            groupBoxDataKasir.BackColor = Color.CadetBlue;
            groupBoxDataKasir.Controls.Add(dataGridViewDataKasir);
            groupBoxDataKasir.Controls.Add(textBoxCariDataKasir);
            groupBoxDataKasir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxDataKasir.Location = new Point(395, 95);
            groupBoxDataKasir.Name = "groupBoxDataKasir";
            groupBoxDataKasir.Size = new Size(535, 547);
            groupBoxDataKasir.TabIndex = 10;
            groupBoxDataKasir.TabStop = false;
            groupBoxDataKasir.Text = "Data Barang";
            // 
            // dataGridViewDataKasir
            // 
            dataGridViewDataKasir.BackgroundColor = Color.PowderBlue;
            dataGridViewDataKasir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDataKasir.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewDataKasir.Location = new Point(6, 77);
            dataGridViewDataKasir.Name = "dataGridViewDataKasir";
            dataGridViewDataKasir.Size = new Size(523, 463);
            dataGridViewDataKasir.TabIndex = 6;
            // 
            // textBoxCariDataKasir
            // 
            textBoxCariDataKasir.Location = new Point(6, 33);
            textBoxCariDataKasir.Name = "textBoxCariDataKasir";
            textBoxCariDataKasir.PlaceholderText = "Cari Data (ID / Nama)";
            textBoxCariDataKasir.Size = new Size(205, 25);
            textBoxCariDataKasir.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID Barang";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama Barang";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Harga";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Ukuran";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Stok";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Gambar";
            Column6.Name = "Column6";
            // 
            // Barang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(938, 654);
            Controls.Add(groupBoxDataKasir);
            Controls.Add(groupBoxMenu);
            Controls.Add(groupBoxProses);
            Controls.Add(groupBoxFormBarang);
            Controls.Add(labelJudulBarang);
            Name = "Barang";
            Text = "Barang";
            groupBoxProses.ResumeLayout(false);
            groupBoxFormBarang.ResumeLayout(false);
            groupBoxFormBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBoxMenu.ResumeLayout(false);
            groupBoxDataKasir.ResumeLayout(false);
            groupBoxDataKasir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataKasir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxProses;
        private Button buttonHapus;
        private Button buttonSimpan;
        private Button buttonRefresh;
        private Button buttonBaru;
        private GroupBox groupBoxFormBarang;
        private TextBox textBoxHarga;
        private TextBox textBoxNamaBarang;
        private TextBox textBoxIDBarang;
        private Label labelUkuran;
        private Label labelHarga;
        private Label labelNamaBarang;
        private Label labelIDBarang;
        private Label labelJudulBarang;
        private TextBox textBoxStok;
        private Label labelGambar;
        private Label labelStok;
        private ComboBox comboBoxUkuran;
        private Button buttonBrowse;
        private PictureBox pictureBox;
        private GroupBox groupBoxMenu;
        private Button buttonHome;
        private Button buttonTransaksi;
        private Button buttonKasir;
        private Button buttonKeluar;
        private GroupBox groupBoxDataKasir;
        private DataGridView dataGridViewDataKasir;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox textBoxCariDataKasir;
    }
}