using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AirplaneHotelBooking.BUS;
using AirplaneHotelBooking.DTO;
using System.Xml;
using Nhom04_DiaDiemDuLich.Properties;

namespace Nhom04_DiaDiemDuLich.GUI
{
    public partial class UserControlChucNangUser : UserControl
    {
        public delegate void EventMenuChinh();
        public event EventMenuChinh QuayVeMenu;

        private int DDDL_NumberOfPage;
        private int DDDL_CurrentPage=1;
        private int DDDL_NumberItemOnAPage = 10;
        private List<DiaDiemDuLichDTO> DDDL_DsDiaDiemDuLich;
        private bool isTimKiem = false;
        private ThongTinTimKiemDTO ThongTinKiemDDDL = null;

        private int CB_NumberOfPage;
        private int CB_CurrentPage = 1;
        private int CB_NumberItemOnAPage = 10;
        private int indexCB;
        private List<ChuyenBayDTO> CB_DsChuyenBay;

        private int Phong_NumberOfPage;
        private int Phong_CurrentPage = 1;
        private int Phong_NumberItemOnAPage = 10;
        private List<PhongDTO> Phong_DsPhong;

        private int KS_NumberOfPage;
        private int KS_CurrentPage = 1;
        private int KS_NumberItemOnAPage = 10;
        private List<KhachSanDTO> KS_DsKhachSan;
        private ThongTinTimKiemDTO ThongTinKiemKS = null;

        public UserControlChucNangUser()
        {
            InitializeComponent();
        }
        // ---------------- Dia Diem Du Lich------------------------------------
        public void MyInitial()
        {
            
            DiaDiemDuLichBUS dddlBus = new DiaDiemDuLichBUS();

            //Đếm số lượng record trong bảng du lịch.
            int nR = dddlBus.getTongSoRecord();
            DDDL_NumberOfPage = nR / DDDL_NumberItemOnAPage;
            if (nR % DDDL_NumberItemOnAPage != 0)
            {
                DDDL_NumberOfPage++;
            }
            //Lấy danh sách trang đầu tiên.
            CapNhatDanhSachDiaDiemDuLichTheoPhanTrang(1, DDDL_NumberItemOnAPage);

            //Lấy danh sách tên quốc gia, vùng
            LoadQuocGia();
            LoadVung();

        }

        private void CapNhatDanhSachDiaDiemDuLichTheoPhanTrang(int iPage, int nItem)
        {
            DiaDiemDuLichBUS dddlBus = new DiaDiemDuLichBUS();
            if (!isTimKiem)
            {
                DDDL_DsDiaDiemDuLich = dddlBus.getDanhSachDiaDiemDuLich(iPage, DDDL_NumberItemOnAPage);
            }
            else
            {
                DDDL_DsDiaDiemDuLich = dddlBus.TimKiemDiaDiemDuLich(ThongTinKiemDDDL.QuocGia, ThongTinKiemDDDL.Vung, ThongTinKiemDDDL.ThanhPho, iPage,nItem);  
            }
                
            BindingSource bindData = new BindingSource();
            bindData.DataSource = DDDL_DsDiaDiemDuLich;
            this.labelDsDDDLPhanTrang.Text = this.DDDL_CurrentPage.ToString() + "/" + this.DDDL_NumberOfPage.ToString();
            this.dataGridViewDSDiaDiemDuLich.DataSource = bindData;
            this.dataGridViewDSDiaDiemDuLich.Refresh();
            this.dataGridViewDSDiaDiemDuLich.Parent.Parent.Refresh();
            this.dataGridViewDSDiaDiemDuLich.Columns["HinhAnh"].Visible = false;
            this.dataGridViewDSDiaDiemDuLich.Columns["MoTa"].Visible = false;
            
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (QuayVeMenu != null)
            {
                QuayVeMenu();
            }
        }

        private void UserControlChucNangUser_Load(object sender, EventArgs e)
        {

        }


        //Về trang trước.
        private void buttonPrevDDDL_Click(object sender, EventArgs e)
        {
            if (this.DDDL_CurrentPage > 1)
            {
                this.DDDL_CurrentPage--;
                CapNhatDanhSachDiaDiemDuLichTheoPhanTrang(DDDL_CurrentPage, DDDL_NumberItemOnAPage);
            }
        }


        //Tới trang sau.
        private void buttonNextDDDL_Click(object sender, EventArgs e)
        {
            if (this.DDDL_CurrentPage < DDDL_NumberOfPage)
            {
                this.DDDL_CurrentPage++;
                CapNhatDanhSachDiaDiemDuLichTheoPhanTrang(DDDL_CurrentPage, DDDL_NumberItemOnAPage);
            }
        }

        private void dataGridViewDSDiaDiemDuLich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index=this.dataGridViewDSDiaDiemDuLich.CurrentRow.Index;
            if (index >= 0)
            {
                this.textBoxDDDL_MoTa.Text = this.DDDL_DsDiaDiemDuLich[index].MoTa;
            }
        }

        private void buttonDDDLTimKiem_Click(object sender, EventArgs e)
        {
            //Lấy thông tin tìm kiếm.
            string QuocGia = "";
            string Vung = "";
            string ThanhPho = "";
            if (this.comboBoxDDDLQuocGia.SelectedIndex != 0)
            {
                QuocGia = this.comboBoxDDDLQuocGia.Text;

                if (this.comboBoxDDDLThanhPho.Enabled == true && this.comboBoxDDDLThanhPho.SelectedIndex > 0)
                {
                    ThanhPho = this.comboBoxDDDLThanhPho.Text;
                }

                if (this.comboBoxDDDLQuocGia.Text.Equals("Việt Nam"))
                {
                    if(this.comboBoxDDDLVung.Enabled==true && this.comboBoxDDDLVung.SelectedIndex>0)
                    {
                        Vung=this.comboBoxDDDLVung.Text;
                    }                    
                }

                //Cập nhật lại danh sách, thông tin tìm kiếm
                isTimKiem = true;
                ThongTinKiemDDDL = new ThongTinTimKiemDTO();
                ThongTinKiemDDDL.ResetData();
                ThongTinKiemDDDL.QuocGia = QuocGia;
                ThongTinKiemDDDL.Vung = Vung;
                ThongTinKiemDDDL.ThanhPho = ThanhPho;

                this.DDDL_CurrentPage = 1;
                DiaDiemDuLichBUS dddlBus = new DiaDiemDuLichBUS();
                int n = dddlBus.getTongSeRecordKetQuaTimKiemDDDL(ThongTinKiemDDDL.QuocGia, ThongTinKiemDDDL.Vung, ThongTinKiemDDDL.ThanhPho);
                this.DDDL_NumberOfPage = (n / DDDL_NumberItemOnAPage);
                if (n % this.DDDL_NumberItemOnAPage != 0)
                {
                    this.CB_NumberOfPage++;
                }

                CapNhatDanhSachDiaDiemDuLichTheoPhanTrang(1, DDDL_NumberItemOnAPage);
                
              
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm.");
                isTimKiem = false;
            }            
        }

        private void buttonDDDlXemBinhLuan_Click(object sender, EventArgs e)
        {
            //Chuẩn bị dữ liệu cho form bình luận
            int index=this.dataGridViewDSDiaDiemDuLich.CurrentRow.Index;
            if (index >= 0)
            {
                DiaDiemDuLichBUS DiaDiemDuLichBUS = new DiaDiemDuLichBUS();
                int MaDDDL = this.DDDL_DsDiaDiemDuLich[index].MaDDDL;
                this.labelTenDiaDiemDuLich.Text = this.DDDL_DsDiaDiemDuLich[index].TenDDDL;
                List<BinhLuanDTO> dsBinhLuan = DiaDiemDuLichBUS.getDanhSachBinhLuan(MaDDDL);
                BindingSource bindData = new BindingSource();
                bindData.DataSource = dsBinhLuan;
                this.dataGridViewXemBinhLuan.DataSource = bindData;
                this.dataGridViewXemBinhLuan.Refresh();
                this.dataGridViewXemBinhLuan.Parent.Parent.Refresh();
                this.dataGridViewXemBinhLuan.Columns["MaBinhLuan"].Width = 100;
                this.dataGridViewXemBinhLuan.Columns["NoiDung"].Width = 500;
                this.dataGridViewXemBinhLuan.Columns["MaDDDL"].Visible = false;
                this.dataGridViewXemBinhLuan.Columns["Valid"].Visible = false;
                this.TabControlUser.SelectTab(tabPageXemBinhLuan);    
            }
            else
            {
                MessageBox.Show("Chưa dọn địa điểm du lịch !");
            }
            
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.TabControlUser.SelectTab(tabPageDiaDiemDuLich);
        }

        private void buttonBack01_Click(object sender, EventArgs e)
        {
            this.TabControlUser.SelectTab(tabPageDiaDiemDuLich);
        }

        private void buttonBack02_Click(object sender, EventArgs e)
        {
            this.TabControlUser.SelectTab(tabPageDiaDiemDuLich);
        }

        private void buttonBack03_Click(object sender, EventArgs e)
        {
            this.TabControlUser.SelectTab(tabPageDiaDiemDuLich);
        }

        private void buttonDDDLChuyenBay_Click(object sender, EventArgs e)
        {
            //Chuẩn bị dữ liệu cho form bình luận
            int index = this.dataGridViewDSDiaDiemDuLich.CurrentRow.Index;
            if (index >= 0)
            {
                DiaDiemDuLichBUS DiaDiemDuLichBUS = new DiaDiemDuLichBUS();
                int MaDDDL = this.DDDL_DsDiaDiemDuLich[index].MaDDDL;
                this.labelTenDDDL_CB.Text = this.DDDL_DsDiaDiemDuLich[index].TenDDDL;
                List<ChuyenBayDTO> dsCB = DiaDiemDuLichBUS.getDanhSachChuyenBay(MaDDDL);
                BindingSource bindData = new BindingSource();
                bindData.DataSource = dsCB;
                this.dataGridViewXemChuyenBay.DataSource = bindData;
                this.dataGridViewXemChuyenBay.Refresh();
                this.dataGridViewXemChuyenBay.Parent.Parent.Refresh();

                this.dataGridViewXemChuyenBay.Columns["DiaDiemDi"].Visible = false;
                this.dataGridViewXemChuyenBay.Columns["DiaDiemDen"].Visible = false;

                this.TabControlUser.SelectTab(tabPageXemChuyenBay);
            }
            else
            {
                MessageBox.Show("Chưa dọn địa điểm du lịch !");
            }
            
        }

        private void buttonDDDLKhachSan_Click(object sender, EventArgs e)
        {
            int index = this.dataGridViewDSDiaDiemDuLich.CurrentRow.Index;
            if (index >= 0)
            {
                DiaDiemDuLichBUS DiaDiemDuLichBUS = new DiaDiemDuLichBUS();
                int MaDDDL = this.DDDL_DsDiaDiemDuLich[index].MaDDDL;
                this.labelTenDDDL_Tour.Text = this.DDDL_DsDiaDiemDuLich[index].TenDDDL;
                List<KhachSanDTO> dsKS = DiaDiemDuLichBUS.getDanhSachKhachSan1(MaDDDL);
                BindingSource bindData = new BindingSource();
                bindData.DataSource = dsKS;
                this.dataGridViewXemKhachSan.DataSource = bindData;
                this.dataGridViewXemKhachSan.Refresh();
                this.dataGridViewXemKhachSan.Parent.Parent.Refresh();
                this.dataGridViewXemKhachSan.Columns["MaDDDL"].Visible = false;
                this.TabControlUser.SelectTab(tabPageXemKhachSan);
            }
            else
            {
                MessageBox.Show("Chưa dọn địa điểm du lịch !");
            }

        }

        private void buttonDDDLTour_Click(object sender, EventArgs e)
        {
            int index = this.dataGridViewDSDiaDiemDuLich.CurrentRow.Index;
            if (index >= 0)
            {
                DiaDiemDuLichBUS DiaDiemDuLichBUS = new DiaDiemDuLichBUS();
                int MaDDDL = this.DDDL_DsDiaDiemDuLich[index].MaDDDL;
                this.labelTenDDDL_Tour.Text = this.DDDL_DsDiaDiemDuLich[index].TenDDDL;
                List<TourDuLichDTO> dsTour = DiaDiemDuLichBUS.getDanhSachTourDuLich(MaDDDL);
                BindingSource bindData = new BindingSource();
                bindData.DataSource = dsTour;
                this.dataGridViewXemTour_DDDL.DataSource = bindData;
                this.dataGridViewXemTour_DDDL.Refresh();
                this.dataGridViewXemTour_DDDL.Parent.Parent.Refresh();
                this.dataGridViewXemTour_DDDL.Columns["MaDDDL"].Visible = false;
                this.TabControlUser.SelectTab(tabPageXemBinhLuan);
            }
            else
            {
                MessageBox.Show("Chưa dọn địa điểm du lịch !");
            }
            this.TabControlUser.SelectTab(tabPageXemTour);
        }
        //----------------------------Chuyen Bay------------------------

        public void MyInitial_CB()
        {

            ChuyenBayBUS cbBus = new ChuyenBayBUS();

            //Đếm số lượng record trong bảng chuyen bay.
            int nR = cbBus.getTongSoRecord();
            CB_NumberOfPage = nR / CB_NumberItemOnAPage;
            if (nR % CB_NumberItemOnAPage != 0)
            {
                CB_NumberOfPage++;
            }
            //Lấy danh sách trang đầu tiên.
            CapNhatDanhSachChuyenBayTheoPhanTrang(1, CB_NumberItemOnAPage);
        }

        private void CapNhatDanhSachChuyenBayTheoPhanTrang(int iPage, int nItem)
        {
            ChuyenBayBUS cbBus = new ChuyenBayBUS();
            CB_DsChuyenBay = cbBus.getDanhSachChuyenBay(iPage, CB_NumberItemOnAPage);
            BindingSource bindData = new BindingSource();
            bindData.DataSource = CB_DsChuyenBay;
            this.labelDsCBPhanTrang.Text = this.CB_CurrentPage.ToString() + "/" + this.CB_NumberOfPage.ToString();
            this.dataGridViewDSChuyenBay.DataSource = bindData;
            this.dataGridViewDSChuyenBay.Refresh();
            this.dataGridViewDSChuyenBay.Parent.Parent.Refresh();

            this.dataGridViewDSChuyenBay.Columns["DiaDiemDi"].Visible = false;
            this.dataGridViewDSChuyenBay.Columns["DiaDiemDen"].Visible = false;
        }

        //Về trang trước.
        private void buttonVeTrangTruocCB_Click(object sender, EventArgs e)
        {
            if (this.CB_CurrentPage > 1)
            {
                this.CB_CurrentPage--;
                CapNhatDanhSachChuyenBayTheoPhanTrang(CB_CurrentPage, CB_NumberItemOnAPage);
            }
        }

        //Tới trang sau.
        private void buttonTrangTiepCB_Click(object sender, EventArgs e)
        {
            if (this.CB_CurrentPage < CB_NumberOfPage)
            {
                this.CB_CurrentPage++;
                CapNhatDanhSachChuyenBayTheoPhanTrang(CB_CurrentPage, CB_NumberItemOnAPage);
            }
        }


        private void dataGridViewDSChuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = this.dataGridViewDSChuyenBay.CurrentRow.Index;
            if (index > 0)
            {
                indexCB = index;
            }
        }

        private void comboBoxDDDLQuocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kiểm tra địa điểm:
            int index = this.comboBoxDDDLQuocGia.SelectedIndex;
            List<string> dsQuocGia = (List<string>)this.comboBoxDDDLQuocGia.Tag;
            if (index > 0)
            {                                
                if (dsQuocGia[index].Contains("Việt Nam"))
                {
                    this.comboBoxDDDLVung.Enabled = true;
                    this.comboBoxDDDLThanhPho.Enabled = false;
                }
                else
                {
                    this.comboBoxDDDLVung.Enabled = false;
                    this.comboBoxDDDLThanhPho.Enabled = true;
                    LoadThanhPho(dsQuocGia[index]);
                }
  
            }
            else
            {
                this.comboBoxDDDLThanhPho.Enabled = false;
                this.comboBoxDDDLVung.Enabled = false;
            }
        }

        public void LoadThanhPho(string QuocGia)
        {
            XmlDocument document = new XmlDocument();
            string pathFile = "Resources\\VungTimKiem.xml";
            document.Load(pathFile);
            XmlElement root = document.DocumentElement;
            List<string> dsThanhPho = new List<string>();
            dsThanhPho.Add("Chọn thành phố");
            XmlNodeList nodeTPs = root.SelectNodes("QuocGia[@Ten='"+QuocGia+"']/ThanhPho");
            if (nodeTPs != null)
            {
                int n = nodeTPs.Count;
                for (int i = 0; i < n; i++)
                {
                    dsThanhPho.Add(((XmlElement)nodeTPs[i]).InnerText);
                }
                this.comboBoxDDDLThanhPho.DataSource = dsThanhPho;
                this.comboBoxDDDLThanhPho.Tag = dsThanhPho;
            }
        }
        public void LoadThanhPhoTheoVung(string Vung)
        {
            XmlDocument document = new XmlDocument();
            string pathFile = "Resources\\VungTimKiem.xml";
            document.Load(pathFile);
            XmlElement root = document.DocumentElement;
            List<string> dsThanhPho = new List<string>();
            dsThanhPho.Add("Chọn thành phố");
            XmlNodeList nodeTPs = root.SelectNodes("QuocGia/Vung[@Ten='" + Vung + "']/ThanhPho");
            if (nodeTPs != null)
            {
                int n = nodeTPs.Count;
                for (int i = 0; i < n; i++)
                {
                    dsThanhPho.Add(((XmlElement)nodeTPs[i]).InnerText);
                }
                this.comboBoxDDDLThanhPho.DataSource = dsThanhPho;
                this.comboBoxDDDLThanhPho.Tag = dsThanhPho;
            }
        }

        public void LoadVung()
        {
            XmlDocument document = new XmlDocument();
            string pathFile = "Resources\\VungTimKiem.xml";
            document.Load(pathFile);
            XmlElement root = document.DocumentElement;
            List<string> dsVung = new List<string>();
            dsVung.Add("Chọn vùng");
            XmlNodeList nodeVungs =root.SelectNodes("QuocGia[@Ten='Việt Nam']/Vung");
            if (nodeVungs != null)
            {
                int n = nodeVungs.Count;
                for (int i = 0; i < n; i++)
                {
                    dsVung.Add(((XmlElement)nodeVungs[i]).Attributes["Ten"].Value.ToString());
                }
                this.comboBoxDDDLVung.DataSource = dsVung;
                this.comboBoxDDDLVung.Tag = dsVung;
            }            
        }

        public void LoadQuocGia()
        {
            XmlDocument document = new XmlDocument();
            string pathFile = "Resources\\VungTimKiem.xml";
            document.Load(pathFile);
            if (document != null)
            {
                List<String> dsQuocGia = new List<string>();
                dsQuocGia.Add("Chọn quốc gia");
                XmlElement root = document.DocumentElement;
                XmlNodeList listQuocGia=root.ChildNodes;
                int nQuocGia = listQuocGia.Count;
                for (int i = 0; i < nQuocGia; i++)
                {
                    string ten = listQuocGia[i].Attributes["Ten"].Value.ToString();
                    dsQuocGia.Add(ten);
                }
                this.comboBoxDDDLQuocGia.DataSource = dsQuocGia;
                this.comboBoxDDDLQuocGia.Tag = dsQuocGia;
            }
            else {
                MessageBox.Show("Không load được Resource !");
            }
        }

        private void comboBoxDDDLVung_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.comboBoxDDDLVung.SelectedIndex;            
            if (index > 0)
            {
                List<string> dsVung = (List<string>)this.comboBoxDDDLVung.Tag;
                LoadThanhPhoTheoVung(dsVung[index]);
                this.comboBoxDDDLThanhPho.Enabled = true;
            }
            else
            {
                this.comboBoxDDDLThanhPho.Enabled=false;
            }
        }

        private void comboBoxDDDLThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    


        private void buttonTimChuyenBay_Click(object sender, EventArgs e)
        {
            MyInitial_CB();
            this.TabControlUser.SelectTab(tabPageChuyenBay);
        }

        //-------------------------Phòng-----------------
        public void MyInitial_Phong()
        {

            PhongBUS pBus = new PhongBUS();

            //Đếm số lượng record trong bảng chuyen bay.
            int nR = pBus.getTongSoRecord();
            Phong_NumberOfPage = nR / Phong_NumberItemOnAPage;
            if (nR % Phong_NumberItemOnAPage != 0)
            {
                Phong_NumberOfPage++;
            }
            //Lấy danh sách trang đầu tiên.
            CapNhatDanhSachPhongTheoPhanTrang(1, Phong_NumberItemOnAPage);
        }

        private void CapNhatDanhSachPhongTheoPhanTrang(int iPage, int nItem)
        {
            PhongBUS pBus = new PhongBUS();
            Phong_DsPhong = pBus.getDanhSachPhong(iPage, Phong_NumberItemOnAPage);
            BindingSource bindData = new BindingSource();
            bindData.DataSource = Phong_DsPhong;
            this.labelDsPhongPhanTrang.Text = this.Phong_CurrentPage.ToString() + "/" + this.Phong_NumberOfPage.ToString();
            this.dataGridViewDsPhong.DataSource = bindData;
            this.dataGridViewDsPhong.Refresh();
            this.dataGridViewDsPhong.Parent.Parent.Refresh();
        }

        //Về trang trước.
        private void buttonVeTrangTruocPhong_Click(object sender, EventArgs e)
        {
            if (this.Phong_CurrentPage > 1)
            {
                this.Phong_CurrentPage--;
                CapNhatDanhSachPhongTheoPhanTrang(Phong_CurrentPage, Phong_NumberItemOnAPage);
            }
        }

        //Tới trang sau.
        private void buttonVeTrangSauPhong_Click(object sender, EventArgs e)
        {
            if (this.Phong_CurrentPage < Phong_NumberOfPage)
            {
                this.Phong_CurrentPage++;
                CapNhatDanhSachPhongTheoPhanTrang(Phong_CurrentPage, Phong_NumberItemOnAPage);
            }
        }
        private void buttonThongTinPhong_Click(object sender, EventArgs e)
        {
            MyInitial_Phong();
            this.TabControlUser.SelectTab(tabPageTTPhong);
        }

        private void buttonKhachSan_Click(object sender, EventArgs e)
        {
            this.TabControlUser.SelectTab(tabPageKhachSan);
        }

        private void buttonXCB_DatVe_Click(object sender, EventArgs e)
        {
            this.TabControlUser.SelectTab(tabPageTTVeMB);
        }

        //---------------Khach San------------------------
        public void MyInitial_KhachSan()
        {

            KhachSanBUS ksBus = new KhachSanBUS();

            //Đếm số lượng record trong bảng khach san
            int nR = ksBus.getTongSoRecord();
            KS_NumberOfPage = nR / KS_NumberItemOnAPage;
            if (nR % KS_NumberItemOnAPage != 0)
            {
                KS_NumberOfPage++;
            }
            //Lấy danh sách trang đầu tiên.
            CapNhatDanhSachKhachSanTheoPhanTrang(1, KS_NumberItemOnAPage);
        }

        private void CapNhatDanhSachKhachSanTheoPhanTrang(int iPage, int nItem)
        {
            KhachSanBUS ksBus = new KhachSanBUS();
            KS_DsKhachSan = ksBus.getDanhSachKhachSan(iPage, KS_NumberItemOnAPage);
            BindingSource bindData = new BindingSource();
            bindData.DataSource = KS_DsKhachSan;
            this.labelDSKhachSan.Text = this.KS_CurrentPage.ToString() + "/" + this.KS_NumberOfPage.ToString();
            this.dataGridViewKhachSan.DataSource = bindData;
            this.dataGridViewKhachSan.Refresh();
            this.dataGridViewKhachSan.Parent.Parent.Refresh();
           
        }
        //ve trang truoc
        private void buttonPreviousPageKhachSan_Click(object sender, EventArgs e)
        {
            if (this.KS_CurrentPage > 1)
            {
                this.KS_CurrentPage--;
                CapNhatDanhSachKhachSanTheoPhanTrang(Phong_CurrentPage, Phong_NumberItemOnAPage);
            }
        }
        //ve trang sau
        private void buttonNextpageKhachSan_Click(object sender, EventArgs e)
        {
            if (this.KS_CurrentPage < KS_NumberOfPage)
            {
                this.KS_CurrentPage++;
                CapNhatDanhSachPhongTheoPhanTrang(KS_CurrentPage, KS_NumberItemOnAPage);
            }

        }

        private void dataGridViewKhachSan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = this.dataGridViewKhachSan.CurrentRow.Index;
            if (index > 0)
            {
                indexCB = index;
            }
        }

        private void buttonTimKiemKS_Click(object sender, EventArgs e)
        {
            //Lấy thông tin tìm kiếm.
            string TenKS = "";
            string TenDDDL = "";
            if (this.comboBoxTimKS_TenKS.SelectedIndex != 0)
            {
                TenKS = this.comboBoxTimKS_TenKS.Text;

                if (this.comboBoxTimKS_TenDDDL.Enabled == true && this.comboBoxTimKS_TenDDDL.SelectedIndex > 0)
                {
                    TenDDDL = this.comboBoxTimKS_TenDDDL.Text;
                }

                //Cập nhật lại danh sách, thông tin tìm kiếm
                isTimKiem = true;
                ThongTinKiemKS = new ThongTinTimKiemDTO();
                ThongTinKiemKS.ResetDataTKKhachSan();
                ThongTinKiemKS.TenKS = TenKS;
                ThongTinKiemDDDL.TenDDDL = TenDDDL;

                this.KS_CurrentPage = 1;
                KhachSanBUS ksBus = new KhachSanBUS();
                int n = ksBus.getTongSeRecordKetQuaTimKiemKhachSan(ThongTinKiemKS.TenKS, ThongTinKiemKS.TenDDDL);
                this.KS_NumberOfPage = (n / KS_NumberItemOnAPage);
                if (n % this.KS_NumberItemOnAPage != 0)
                {
                    this.KS_NumberOfPage++;
                }

                CapNhatDanhSachKhachSanTheoPhanTrang(1, KS_NumberItemOnAPage);
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm.");
                isTimKiem = false;
            }   
        }




    }
}
