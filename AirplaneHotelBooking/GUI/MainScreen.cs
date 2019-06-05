using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AirplaneHotelBooking.DAO;

namespace AirplaneHotelBooking
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            MyInitial();
            HienChucNang(1);
        }

        private void MyInitial()
        {
            this.MaximizeBox = false;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
        }

        public void HienChucNang(int idGiaoDien)
        {
            this.userControlFormKetNoi.Visible = (idGiaoDien == 1);
            this.userControlFormChonTaiKhoan.Visible = (idGiaoDien == 2);
            this.userControlChucNangUser.Visible = (idGiaoDien == 3);
            this.userControlMenuAdmin.Visible=(idGiaoDien==4);
        }

        private void userControlFormKetNoi_Load(object sender, EventArgs e)
        {

        }

        private void userControlFormKetNoi_SuKienKetNoi()
        {
            HienChucNang(2);
        }


        //Bat dau Form chon tai khoan
        private void userControlFormChonTaiKhoan_SuKienChonAdmin()
        {
            HienChucNang(4);
        }

        private void userControlFormChonTaiKhoan_SuKienChonUser()
        {
            //Khởi tạo giao diện cho cửa sổ user.
            this.userControlChucNangUser.MyInitial();            
            HienChucNang(3);
        }

        private void userControlMenuAdmin_QuayVeMenu()
        {
            HienChucNang(2);
        }

        private void userControlChucNangUser_QuayVeMenu()
        {
            HienChucNang(2);
        }

        //Ket thuc Form chon tai khoan


        


       


    }
}
