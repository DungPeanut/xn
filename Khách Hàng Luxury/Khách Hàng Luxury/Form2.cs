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
    public partial class Form2 : Form
    {
        private int selectedRating = 0;
        private Button[] ratingButtons;
        public Form2()
        {
            InitializeComponent();
            InitRatingButtons();
        }
        private void InitRatingButtons()
        {
            // Tập hợp lại cho dễ sử lý
            ratingButtons = new[] { btnExcellent, btnOkay, btnPoor };
            // Flat style để dễ custom
            foreach (var b in ratingButtons)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 1;
                b.FlatAppearance.BorderColor = Color.Gray;
                b.TabStop = false;       // để khi click txtComment không đổi focus lên button
                b.Click += (s, e) => OnRatingClicked(Array.IndexOf(ratingButtons, (Button)s) + 1, (Button)s);
            }

            btnSubmit.Enabled = false;
            btnSubmit.Click += btnSubmit_Click;

            // Đảm bảo click vào txtComment không ảnh hưởng gì
            txtComment.TabIndex = ratingButtons.Max(b => b.TabIndex) + 1;
        }
        private void OnRatingClicked(int ratingValue, Button btn)
        {
            // Xác nhận
            var dr = MessageBox.Show(
                "Bạn có chắc chắn muốn chọn nút này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr != DialogResult.Yes)
                return;

            // Lưu lựa chọn
            selectedRating = ratingValue;

            // Highlight nút được chọn, reset các nút khác
            ResetRatingStyles();
            btn.BackColor = ControlPaint.Light(btn.BackColor); // hoặc Color.LightGreen...
            btn.FlatAppearance.BorderSize = 3;
            btn.FlatAppearance.BorderColor = Color.Black;

            btnSubmit.Enabled = true;
        }
        private void ResetRatingStyles()
        {
            foreach (var b in ratingButtons)
            {
                b.BackColor = SystemColors.Control;
                b.FlatAppearance.BorderSize = 1;
                b.FlatAppearance.BorderColor = Color.Gray;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Xác nhận gửi
            var dr = MessageBox.Show(
                "Bạn có muốn gửi nhận xét không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr != DialogResult.Yes)
                return;

            // TODO: lưu selectedRating + txtComment.Text vào DB tại đây

            MessageBox.Show(
                "Gửi thành công",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Reset toàn form
            selectedRating = 0;
            ResetRatingStyles();
            txtComment.Clear();

            // Chưa chọn Rating nào
            btnSubmit.Enabled = false;
           
        }
    }
}
