using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Qlbanhang;
using DTO_Qlbanhang;

namespace GUI_QLBANHANG
{
    public partial class FrmDoimk : Form
    {
        private BUS_NhanVien busNV = new BUS_NhanVien();


        public FrmDoimk(string email)
        {
            InitializeComponent();
            txtemail.ReadOnly = true;
            txtemail.Text = email;
        }

        private void FrmDoimk_Load(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpassOld.Text) == true)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpassOld.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPassNew.Text) == true)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassNew.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPassNew2.Text) == true)
            {
                MessageBox.Show("Bạn phải nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassNew2.Focus();
                return;
            }
            else if (string.Compare(txtPassNew.Text,txtPassNew2.Text,false)!=0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu và nhập lại mật khẩu giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassNew.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn thật sự muốn nhập lại mật khẩu", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    string matkhaumoi = busNV.encryption(txtPassNew.Text);
                    string matkhaucu = busNV.encryption(txtpassOld.Text);
                    if (busNV.UpdateMatKhau(txtemail.Text, matkhaucu, matkhaumoi))
                    {
                        FrmMain.CheckLogin = 0;

                        try
                        {
                            busNV.SendMailDoiMK(txtemail.Text, txtPassNew.Text);
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        MessageBox.Show("Cập nhật mật khẩu thành công,đăng nhập lại để tiếp tục sử dụng phần mềm");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mât khẩu cũ không đúng, Mời nhập lại");
                        txtpassOld.Text = null;
                        txtPassNew.Text = null;
                        txtPassNew2.Text = null;
                    }
                }
                else
                {
                    
                    txtpassOld.Text = null;
                    txtPassNew.Text = null;
                    txtPassNew2.Text = null;
                }
            }
        }
    }
}
