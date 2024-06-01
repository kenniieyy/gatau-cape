namespace UAS_PEMVIS.Resources
{
    partial class Dashboard
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
            pictureBoxDashboard = new PictureBox();
            buttonTransaksi = new Button();
            buttonBarang = new Button();
            buttonKasir = new Button();
            buttonKeluar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDashboard).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxDashboard
            // 
            pictureBoxDashboard.Image = Properties.Resources.bg_dashboard;
            pictureBoxDashboard.Location = new Point(-1, 0);
            pictureBoxDashboard.Name = "pictureBoxDashboard";
            pictureBoxDashboard.Size = new Size(801, 450);
            pictureBoxDashboard.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDashboard.TabIndex = 0;
            pictureBoxDashboard.TabStop = false;
            // 
            // buttonTransaksi
            // 
            buttonTransaksi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTransaksi.Location = new Point(338, 92);
            buttonTransaksi.Name = "buttonTransaksi";
            buttonTransaksi.Size = new Size(103, 31);
            buttonTransaksi.TabIndex = 1;
            buttonTransaksi.Text = "Transaksi";
            buttonTransaksi.UseVisualStyleBackColor = true;
            // 
            // buttonBarang
            // 
            buttonBarang.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBarang.Location = new Point(254, 140);
            buttonBarang.Name = "buttonBarang";
            buttonBarang.Size = new Size(79, 31);
            buttonBarang.TabIndex = 2;
            buttonBarang.Text = "Barang";
            buttonBarang.UseVisualStyleBackColor = true;
            // 
            // buttonKasir
            // 
            buttonKasir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKasir.Location = new Point(348, 140);
            buttonKasir.Name = "buttonKasir";
            buttonKasir.Size = new Size(79, 31);
            buttonKasir.TabIndex = 3;
            buttonKasir.Text = "Kasir";
            buttonKasir.UseVisualStyleBackColor = true;
            // 
            // buttonKeluar
            // 
            buttonKeluar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKeluar.Location = new Point(444, 140);
            buttonKeluar.Name = "buttonKeluar";
            buttonKeluar.Size = new Size(79, 31);
            buttonKeluar.TabIndex = 4;
            buttonKeluar.Text = "Keluar";
            buttonKeluar.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonKeluar);
            Controls.Add(buttonKasir);
            Controls.Add(buttonBarang);
            Controls.Add(buttonTransaksi);
            Controls.Add(pictureBoxDashboard);
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDashboard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxDashboard;
        private Button buttonTransaksi;
        private Button buttonBarang;
        private Button buttonKasir;
        private Button buttonKeluar;
    }
}