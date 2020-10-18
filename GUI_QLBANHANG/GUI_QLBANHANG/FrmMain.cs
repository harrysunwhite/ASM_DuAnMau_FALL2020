using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBANHANG
{

    public partial class FrmMain : Form
    {
        public static int CheckLogin = 0;
        public static int Role = 0;
        public static string mail;
        public static int CheckDoiMatKhau = 0;



        Thread th;

        public void opennewapp()
        {
            FrmMain FMain = new FrmMain();
            CheckLogin = 0;

            Application.Run(FMain);
        }
      
        void FrmThongTinNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            this.Refresh();

            FrmMain_Load(sender, e);
        }

        public void openFrm(Form frm, object sender, EventArgs e)
        {
            if (!CheckExistFrm(frm.Name))
            {
                
                //Hidelb(sender, e);
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                
                frm.Show();
                frm.FormClosed += new FormClosedEventHandler(CloseFrm);
                ActiveCurrentForm(frm.Name);

            }
            else
                ActiveCurrentForm(frm.Name);
        }
        private void LoOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            CheckLogin = 0;
            StartProgram();
        }
        public FrmMain()
        {
            InitializeComponent();
           
        }
        //private void Hidelb(object sender, EventArgs e)
        //{
        //    this.IsMdiContainer = true;
        //    lbName.Visible = false;
        //    lbHK.Visible = false;
        //}

        private void ActiveCurrentForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (string.Compare(frm.Name,name,true)==0)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        public void PhanQuyen()
        {
            nhanvienToolStripMenuItem.Visible = false;
            thongKeToolStripMenuItem.Visible = false;


        }

       public void CheckChangePass()
        {
            danhMucToolStripMenuItem.Visible = false;
            thongKeHangHoaToolStripMenuItem.Visible = false;

        }
        private void CloseFrm(object sender, FormClosedEventArgs e)
        {
           
                this.Refresh();
                FrmMain_Load(sender, e);
            
           
         
        }


        private bool CheckExistFrm(string frmName)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == frmName)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrm("FrmDangNhap"))
            {
                FrmDangNhap dn = new FrmDangNhap();

                //Hidelb(sender, e);
                
                dn.MdiParent = this;
               
                dn.Show();
                dn.FormClosed += new FormClosedEventHandler(CloseFrm);
            }
            else
            {
                ActiveCurrentForm("FrmDangNhap");
            }
           
        }

        private void StartProgram()
        {
            //if(this.MdiChildren.Count()>0)
            //{
                if (CheckLogin == 1)
                {

                    labelUser.Text = "Chào " + mail;
                    hosoNVToolStripMenuItem.Enabled = true;
                    danhMucToolStripMenuItem.Visible = true;
                    dangxuatToolStripMenuItem.Enabled = true;
                    thongKeToolStripMenuItem.Visible = true;
                    dangNhapToolStripMenuItem.Enabled = false;
                    thongKeHangHoaToolStripMenuItem.Visible = true;

                    if (Role == 0)
                    {
                        PhanQuyen();
                    }
                    if(CheckDoiMatKhau == 0)
                    {
                        CheckChangePass();
                    }    
                }
                else
                {
                    this.IsMdiContainer = false;
                    dangNhapToolStripMenuItem.Enabled = true;
                    dangxuatToolStripMenuItem.Enabled = false;
                    hosoNVToolStripMenuItem.Enabled = false;
                    danhMucToolStripMenuItem.Visible = false;
                    thongKeToolStripMenuItem.Visible = false;
                    labelUser.Text = null;
                    //lbName.Visible = true;
                    //lbHK.Visible = true;
                }

            //}

            //    else
            //{
               
            //    this.IsMdiContainer = false;
              
            //    lbName.Visible = true;
            //    lbHK.Visible = true;
            //}
        }

        

        public void FrmMain_Load(object sender, EventArgs e)
        {
            StartProgram();
            this.IsMdiContainer = true;
        }

        private void thongKeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void hosoNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (!CheckExistFrm("FrmDoimk"))
            {
                FrmDoimk dmk = new FrmDoimk(mail);

                //Hidelb(sender, e);
               
                dmk.MdiParent = this;

                dmk.Show();
                dmk.FormClosed += new FormClosedEventHandler(CloseFrm);
            }
            else
            {
                ActiveCurrentForm("FrmDoimk");
            }

        }

        private void hanghoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHang Hang = new FrmHang();
            openFrm(Hang,sender,e);

        }

        private void nhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien fNV = new FrmNhanVien();
            openFrm(fNV, sender, e);
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhach kh = new FrmKhach();
            openFrm(kh, sender, e);
        }

        private void thongKeHangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmThongKe tk = new FrmThongKe();
            openFrm(tk, sender, e);
        }

        private void dangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewapp);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

}
