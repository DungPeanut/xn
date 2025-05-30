using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khách_Hàng_Luxury
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            // 1. Xác nhận nếu cần:
            var dr = MessageBox.Show(
                "Xác nhận nhập lại?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (dr != DialogResult.Yes)
                return;

            // 2. Clear các ô nhập
            txtRoomID.Clear();
            txtCustomerName.Clear();
            txtID.Clear();

            // 3. Đặt con trỏ (focus) về ô Mã Phòng
            txtRoomID.Focus();
        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtRoomID.Text == " " ||
                 txtCustomerName.Text == " " ||
                 txtID.Text == " ")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            // Kiểm tra thông tin (demo)
            if (txtRoomID.Text == "001" &&
                txtCustomerName.Text == "Trần Tiến Dũng" &&
                txtID.Text == "0004968")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                Storyboards  ds = new Storyboards ();
                ds.Show();
                this.Hide();
                // Chuyển sang Dashboard...
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập sai!", "Cảnh báo");                
            }
        }
    }
}
