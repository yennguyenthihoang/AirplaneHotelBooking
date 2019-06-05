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
    public partial class UserControlFormKetNoi : UserControl
    {
        public delegate void KetNoi();
        public event KetNoi SuKienKetNoi;

        public UserControlFormKetNoi()
        {
            InitializeComponent();
        }

        private void buttonKetNoi_Click_1(object sender, EventArgs e)
        {
            if (SuKienKetNoi != null)
            {
                SuKienKetNoi();
            }
        }

        private void UserControlFormKetNoi_Load(object sender, EventArgs e)
        {

        }




    }
}
