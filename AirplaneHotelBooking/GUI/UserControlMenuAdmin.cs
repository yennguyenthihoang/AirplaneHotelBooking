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
    public partial class UserControlMenuAdmin : UserControl
    {
        public delegate void EventMenuChinh();
        public event EventMenuChinh QuayVeMenu;
        public UserControlMenuAdmin()
        {
            InitializeComponent();
        }



        private void UserControlMenuAdmin_Load(object sender, EventArgs e)
        {

        }



        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (QuayVeMenu != null)
            {
                QuayVeMenu();
            }
        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void TabPageDiaDiemDuLich_Click(object sender, EventArgs e)
        {

        }
    }
}
