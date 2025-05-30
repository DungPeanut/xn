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
    public partial class Storyboards : Form
    {
        private readonly Timer _timerClock = new Timer();
        public Storyboards()
        {
            InitializeComponent();
            customizeDesing();

            _timerClock.Interval = 1000;
            _timerClock.Tick += TimerClock_Tick;
            _timerClock.Start();
            TimerClock_Tick(this, EventArgs.Empty);
        }
        private void TimerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void customizeDesing()
        {
            panelSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (
                panelSubMenu.Visible == true)
                panelSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Storyboards_Load(object sender, EventArgs e)
        {

        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu);
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            hideSubMenu();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            hideSubMenu();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
            hideSubMenu();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có chắc chắn muốn đăng xuất không?",   // Nội dung
               "Xác nhận",                                // Tiêu đề
               MessageBoxButtons.YesNo,                   // Các nút Yes/No
               MessageBoxIcon.Question                    // Icon hỏi
             );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
