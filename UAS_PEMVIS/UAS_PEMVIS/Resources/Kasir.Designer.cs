namespace UAS_PEMVIS.Resources
{
    partial class Kasir
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
            labelJudulKasir = new Label();
            groupBoxFormKasir = new GroupBox();
            labelIDKasir = new Label();
            labelNamaKasir = new Label();
            labelAlamat = new Label();
            labelTelepon = new Label();
            textBoxIDKasir = new TextBox();
            textBoxNamaKasir = new TextBox();
            textBoxAlamat = new TextBox();
            textBoxTelepon = new TextBox();
            groupBoxProses = new GroupBox();
            buttonBaru = new Button();
            buttonRefresh = new Button();
            buttonSimpan = new Button();
            buttonHapus = new Button();
            groupBoxMenu = new GroupBox();
            buttonKeluar = new Button();
            buttonBarang = new Button();
            buttonTransaksi = new Button();
            buttonHome = new Button();
            groupBoxDataKasir = new GroupBox();
            textBoxCariDataKasir = new TextBox();
            dataGridViewDataKasir = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBoxFormKasir.SuspendLayout();
            groupBoxProses.SuspendLayout();
            groupBoxMenu.SuspendLayout();
            groupBoxDataKasir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataKasir).BeginInit();
            SuspendLayout();
            // 
            // labelJudulKasir
            // 
            labelJudulKasir.AutoSize = true;
            labelJudulKasir.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJudulKasir.Location = new Point(46, 12);
            labelJudulKasir.Name = "labelJudulKasir";
            labelJudulKasir.Size = new Size(267, 22);
            labelJudulKasir.TabIndex = 3;
            labelJudulKasir.Text = "DATA KASIR FLOWER MARKET";
            // 
            // groupBoxFormKasir
            // 
            groupBoxFormKasir.BackColor = Color.CadetBlue;
            groupBoxFormKasir.Controls.Add(textBoxTelepon);
            groupBoxFormKasir.Controls.Add(textBoxAlamat);
            groupBoxFormKasir.Controls.Add(textBoxNamaKasir);
            groupBoxFormKasir.Controls.Add(textBoxIDKasir);
            groupBoxFormKasir.Controls.Add(labelTelepon);
            groupBoxFormKasir.Controls.Add(labelAlamat);
            groupBoxFormKasir.Controls.Add(labelNamaKasir);
            groupBoxFormKasir.Controls.Add(labelIDKasir);
            groupBoxFormKasir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxFormKasir.Location = new Point(12, 96);
            groupBoxFormKasir.Name = "groupBoxFormKasir";
            groupBoxFormKasir.Size = new Size(342, 213);
            groupBoxFormKasir.TabIndex = 4;
            groupBoxFormKasir.TabStop = false;
            groupBoxFormKasir.Text = "Form Kasir";
            // 
            // labelIDKasir
            // 
            labelIDKasir.AutoSize = true;
            labelIDKasir.Location = new Point(10, 36);
            labelIDKasir.Name = "labelIDKasir";
            labelIDKasir.Size = new Size(53, 17);
            labelIDKasir.TabIndex = 0;
            labelIDKasir.Text = "ID Kasir";
            // 
            // labelNamaKasir
            // 
            labelNamaKasir.AutoSize = true;
            labelNamaKasir.Location = new Point(10, 77);
            labelNamaKasir.Name = "labelNamaKasir";
            labelNamaKasir.Size = new Size(76, 17);
            labelNamaKasir.TabIndex = 1;
            labelNamaKasir.Text = "Nama Kasir";
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Location = new Point(10, 119);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(48, 17);
            labelAlamat.TabIndex = 2;
            labelAlamat.Text = "Alamat";
            // 
            // labelTelepon
            // 
            labelTelepon.AutoSize = true;
            labelTelepon.Location = new Point(10, 160);
            labelTelepon.Name = "labelTelepon";
            labelTelepon.Size = new Size(54, 17);
            labelTelepon.TabIndex = 3;
            labelTelepon.Text = "Telepon";
            // 
            // textBoxIDKasir
            // 
            textBoxIDKasir.Location = new Point(118, 36);
            textBoxIDKasir.Name = "textBoxIDKasir";
            textBoxIDKasir.Size = new Size(205, 25);
            textBoxIDKasir.TabIndex = 4;
            // 
            // textBoxNamaKasir
            // 
            textBoxNamaKasir.Location = new Point(118, 77);
            textBoxNamaKasir.Name = "textBoxNamaKasir";
            textBoxNamaKasir.Size = new Size(205, 25);
            textBoxNamaKasir.TabIndex = 5;
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.Location = new Point(118, 119);
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.Size = new Size(205, 25);
            textBoxAlamat.TabIndex = 6;
            // 
            // textBoxTelepon
            // 
            textBoxTelepon.Location = new Point(118, 160);
            textBoxTelepon.Name = "textBoxTelepon";
            textBoxTelepon.Size = new Size(205, 25);
            textBoxTelepon.TabIndex = 7;
            // 
            // groupBoxProses
            // 
            groupBoxProses.BackColor = Color.CadetBlue;
            groupBoxProses.Controls.Add(buttonHapus);
            groupBoxProses.Controls.Add(buttonSimpan);
            groupBoxProses.Controls.Add(buttonRefresh);
            groupBoxProses.Controls.Add(buttonBaru);
            groupBoxProses.Location = new Point(12, 357);
            groupBoxProses.Name = "groupBoxProses";
            groupBoxProses.Size = new Size(342, 116);
            groupBoxProses.TabIndex = 5;
            groupBoxProses.TabStop = false;
            groupBoxProses.Text = "Proses";
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
            // groupBoxMenu
            // 
            groupBoxMenu.BackColor = Color.CadetBlue;
            groupBoxMenu.Controls.Add(buttonHome);
            groupBoxMenu.Controls.Add(buttonTransaksi);
            groupBoxMenu.Controls.Add(buttonBarang);
            groupBoxMenu.Controls.Add(buttonKeluar);
            groupBoxMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxMenu.Location = new Point(395, 12);
            groupBoxMenu.Name = "groupBoxMenu";
            groupBoxMenu.Size = new Size(535, 70);
            groupBoxMenu.TabIndex = 6;
            groupBoxMenu.TabStop = false;
            groupBoxMenu.Text = "Menu";
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
            // buttonBarang
            // 
            buttonBarang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonBarang.Image = Properties.Resources.icon_bunga;
            buttonBarang.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBarang.Location = new Point(297, 22);
            buttonBarang.Name = "buttonBarang";
            buttonBarang.Size = new Size(113, 38);
            buttonBarang.TabIndex = 7;
            buttonBarang.Text = "BARANG";
            buttonBarang.TextAlign = ContentAlignment.MiddleRight;
            buttonBarang.UseVisualStyleBackColor = true;
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
            // groupBoxDataKasir
            // 
            groupBoxDataKasir.BackColor = Color.CadetBlue;
            groupBoxDataKasir.Controls.Add(dataGridViewDataKasir);
            groupBoxDataKasir.Controls.Add(textBoxCariDataKasir);
            groupBoxDataKasir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxDataKasir.Location = new Point(395, 96);
            groupBoxDataKasir.Name = "groupBoxDataKasir";
            groupBoxDataKasir.Size = new Size(535, 377);
            groupBoxDataKasir.TabIndex = 7;
            groupBoxDataKasir.TabStop = false;
            groupBoxDataKasir.Text = "Data Kasir";
            // 
            // textBoxCariDataKasir
            // 
            textBoxCariDataKasir.Location = new Point(6, 33);
            textBoxCariDataKasir.Name = "textBoxCariDataKasir";
            textBoxCariDataKasir.PlaceholderText = "Cari Data (ID / Nama)";
            textBoxCariDataKasir.Size = new Size(205, 25);
            textBoxCariDataKasir.TabIndex = 5;
            // 
            // dataGridViewDataKasir
            // 
            dataGridViewDataKasir.BackgroundColor = Color.PowderBlue;
            dataGridViewDataKasir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDataKasir.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewDataKasir.Location = new Point(6, 77);
            dataGridViewDataKasir.Name = "dataGridViewDataKasir";
            dataGridViewDataKasir.Size = new Size(523, 293);
            dataGridViewDataKasir.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID Kasir";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama Kasir";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Alamat";
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Telepon";
            Column4.Name = "Column4";
            // 
            // Kasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(942, 478);
            Controls.Add(groupBoxDataKasir);
            Controls.Add(groupBoxMenu);
            Controls.Add(groupBoxProses);
            Controls.Add(groupBoxFormKasir);
            Controls.Add(labelJudulKasir);
            Name = "Kasir";
            Text = "Kasir";
            groupBoxFormKasir.ResumeLayout(false);
            groupBoxFormKasir.PerformLayout();
            groupBoxProses.ResumeLayout(false);
            groupBoxMenu.ResumeLayout(false);
            groupBoxDataKasir.ResumeLayout(false);
            groupBoxDataKasir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataKasir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelJudulKasir;
        private GroupBox groupBoxFormKasir;
        private Label labelTelepon;
        private Label labelAlamat;
        private Label labelNamaKasir;
        private Label labelIDKasir;
        private TextBox textBoxTelepon;
        private TextBox textBoxAlamat;
        private TextBox textBoxNamaKasir;
        private TextBox textBoxIDKasir;
        private GroupBox groupBoxProses;
        private Button buttonHapus;
        private Button buttonSimpan;
        private Button buttonRefresh;
        private Button buttonBaru;
        private GroupBox groupBoxMenu;
        private Button buttonHome;
        private Button buttonTransaksi;
        private Button buttonBarang;
        private Button buttonKeluar;
        private GroupBox groupBoxDataKasir;
        private DataGridView dataGridViewDataKasir;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox textBoxCariDataKasir;
    }
}