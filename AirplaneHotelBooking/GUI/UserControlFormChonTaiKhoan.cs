using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nhom04_DiaDiemDuLich.GUI
{
    public partial class UserControlFormChonTaiKhoan : UserControl
    {
        public delegate void ChonUser();
        public event ChonUser SuKienChonUser;

        public delegate void ChonAdmin();
        public event ChonUser SuKienChonAdmin;

        public UserControlFormChonTaiKhoan()
        {
            InitializeComponent();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            if (SuKienChonUser != null)
            {
                SuKienChonUser();
            }
        }



        private void UserControlFormChonTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            if (SuKienChonAdmin != null)
            {
                SuKienChonAdmin();
            }
        }
    }
}
