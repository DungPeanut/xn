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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            cbbServiceType.Leave += CbbServiceType_Leave;
        }
        private void CbbServiceType_Leave(object sender, EventArgs e)
        {
            // Với DropDownList, bạn kiểm SelectedIndex
            if (cbbServiceType.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn cần chọn loại dịch vụ", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbServiceType.DroppedDown = true;   // mở list để chọn luôn
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show(
                    "Xác nhận gửi?",       // Nội dung
                    "Confirm",             // Tiêu đề
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
           );

            // 2. Nếu chọn Yes thì báo thành công
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Gửi yêu cầu thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            cbbServiceType.SelectedIndex = -1; // chưa chọn gì
            txtNotes.Clear();

        }
    }
}
