namespace Nhom04_DiaDiemDuLich
{
    partial class MainScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControlMenuAdmin = new Nhom04_DiaDiemDuLich.GUI.UserControlMenuAdmin();
            this.userControlChucNangUser = new Nhom04_DiaDiemDuLich.GUI.UserControlChucNangUser();
            this.userControlFormChonTaiKhoan = new Nhom04_DiaDiemDuLich.GUI.UserControlFormChonTaiKhoan();
            this.userControlFormKetNoi = new Nhom04_DiaDiemDuLich.GUI.UserControlFormKetNoi();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Nhom04_DiaDiemDuLich.Properties.Resources.LOGO1;
            this.pictureBox1.Location = new System.Drawing.Point(237, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 101);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // userControlMenuAdmin
            // 
            this.userControlMenuAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlMenuAdmin.Location = new System.Drawing.Point(62, 109);
            this.userControlMenuAdmin.Name = "userControlMenuAdmin";
            this.userControlMenuAdmin.Size = new System.Drawing.Size(857, 539);
            this.userControlMenuAdmin.TabIndex = 7;
            this.userControlMenuAdmin.QuayVeMenu += new Nhom04_DiaDiemDuLich.GUI.UserControlMenuAdmin.EventMenuChinh(this.userControlMenuAdmin_QuayVeMenu);
            // 
            // userControlChucNangUser
            // 
            this.userControlChucNangUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlChucNangUser.Location = new System.Drawing.Point(62, 109);
            this.userControlChucNangUser.Name = "userControlChucNangUser";
            this.userControlChucNangUser.Size = new System.Drawing.Size(859, 541);
            this.userControlChucNangUser.TabIndex = 6;
            this.userControlChucNangUser.QuayVeMenu += new Nhom04_DiaDiemDuLich.GUI.UserControlChucNangUser.EventMenuChinh(this.userControlChucNangUser_QuayVeMenu);
            // 
            // userControlFormChonTaiKhoan
            // 
            this.userControlFormChonTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.userControlFormChonTaiKhoan.Location = new System.Drawing.Point(203, 123);
            this.userControlFormChonTaiKhoan.Name = "userControlFormChonTaiKhoan";
            this.userControlFormChonTaiKhoan.Size = new System.Drawing.Size(570, 371);
            this.userControlFormChonTaiKhoan.TabIndex = 5;
            this.userControlFormChonTaiKhoan.SuKienChonUser += new Nhom04_DiaDiemDuLich.GUI.UserControlFormChonTaiKhoan.ChonUser(this.userControlFormChonTaiKhoan_SuKienChonUser);
            this.userControlFormChonTaiKhoan.SuKienChonAdmin += new Nhom04_DiaDiemDuLich.GUI.UserControlFormChonTaiKhoan.ChonUser(this.userControlFormChonTaiKhoan_SuKienChonAdmin);
            // 
            // userControlFormKetNoi
            // 
            this.userControlFormKetNoi.BackColor = System.Drawing.Color.Transparent;
            this.userControlFormKetNoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userControlFormKetNoi.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlFormKetNoi.Location = new System.Drawing.Point(182, 176);
            this.userControlFormKetNoi.Name = "userControlFormKetNoi";
            this.userControlFormKetNoi.Size = new System.Drawing.Size(685, 354);
            this.userControlFormKetNoi.TabIndex = 4;
            this.userControlFormKetNoi.SuKienKetNoi += new Nhom04_DiaDiemDuLich.GUI.UserControlFormKetNoi.KetNoi(this.userControlFormKetNoi_SuKienKetNoi);
            // 
            // MainScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Nhom04_DiaDiemDuLich.Properties.Resources.background01;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.userControlMenuAdmin);
            this.Controls.Add(this.userControlChucNangUser);
            this.Controls.Add(this.userControlFormChonTaiKhoan);
            this.Controls.Add(this.userControlFormKetNoi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Du lịch online";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private GUI.UserControlFormKetNoi userControlFormKetNoi;
        private GUI.UserControlFormChonTaiKhoan userControlFormChonTaiKhoan;
        private GUI.UserControlChucNangUser userControlChucNangUser;
        private GUI.UserControlMenuAdmin userControlMenuAdmin;


    }
}