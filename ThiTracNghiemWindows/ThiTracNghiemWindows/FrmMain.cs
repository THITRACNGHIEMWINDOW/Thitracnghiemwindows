using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;

namespace ThiTracNghiemWindows
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
            btn_qlysinhvien.ItemClick += btn_qlysinhvien_ItemClick;
            btn_dangxuat.ItemClick += btn_dangxuat_ItemClick;
            btn_qlphong.ItemClick += btn_qlphong_ItemClick;
        }

        void btn_qlphong_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.XtraTab.XtraTabPage tab = new DevExpress.XtraTab.XtraTabPage();
            tab.Name = "QLSinhVien";
            tab.Text = "Quản lý sinh viên";
            FrmQLtheophong qlphong = new FrmQLtheophong();
            tab.Controls.Add(qlphong);
            qlphong.Dock = DockStyle.Fill;
            tab_hienthi.TabPages.Add(tab);
        }

        void btn_dangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Login lgin = new Login();
            lgin.Show();
        }

        void btn_qlysinhvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            //DevExpress.XtraTab.XtraTabPage tab = new DevExpress.XtraTab.XtraTabPage();
            //tab.Name = "QLSinhVien";
            //tab.Text = "Quản lý sinh viên";
            //LoginControls ql = new LoginControls();
            //tab.Controls.Add(ql);
            //ql.Dock = DockStyle.Fill;
            //tab_hienthi.TabPages.Add(tab);

            //
            QLSinhvien ql = new QLSinhvien();
            ql.Show();

        }

       

   
    }
}