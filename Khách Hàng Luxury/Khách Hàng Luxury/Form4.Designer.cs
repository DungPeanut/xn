namespace Khách_Hàng_Luxury
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblBinhLuan = new System.Windows.Forms.Label();
            this.cbbRating = new System.Windows.Forms.ComboBox();
            this.lblDanhGia = new System.Windows.Forms.Label();
            this.btnSendFb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::Khách_Hàng_Luxury.Properties.Resources.cancel_25px;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 53);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtComment
            // 
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(151, 360);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(879, 51);
            this.txtComment.TabIndex = 23;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // lblBinhLuan
            // 
            this.lblBinhLuan.AutoSize = true;
            this.lblBinhLuan.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinhLuan.Location = new System.Drawing.Point(144, 283);
            this.lblBinhLuan.Name = "lblBinhLuan";
            this.lblBinhLuan.Size = new System.Drawing.Size(165, 46);
            this.lblBinhLuan.TabIndex = 22;
            this.lblBinhLuan.Text = "Bình Luận";
            // 
            // cbbRating
            // 
            this.cbbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRating.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRating.FormattingEnabled = true;
            this.cbbRating.Items.AddRange(new object[] {
            "1 sao",
            "2 sao",
            "3 sao",
            "4 sao",
            "5 sao"});
            this.cbbRating.Location = new System.Drawing.Point(151, 166);
            this.cbbRating.Name = "cbbRating";
            this.cbbRating.Size = new System.Drawing.Size(879, 53);
            this.cbbRating.TabIndex = 21;
            // 
            // lblDanhGia
            // 
            this.lblDanhGia.AutoSize = true;
            this.lblDanhGia.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhGia.Location = new System.Drawing.Point(144, 95);
            this.lblDanhGia.Name = "lblDanhGia";
            this.lblDanhGia.Size = new System.Drawing.Size(156, 46);
            this.lblDanhGia.TabIndex = 20;
            this.lblDanhGia.Text = "Đánh Giá";
            // 
            // btnSendFb
            // 
            this.btnSendFb.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSendFb.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFb.Location = new System.Drawing.Point(425, 499);
            this.btnSendFb.Name = "btnSendFb";
            this.btnSendFb.Size = new System.Drawing.Size(327, 190);
            this.btnSendFb.TabIndex = 24;
            this.btnSendFb.Text = "Gửi Phản Hồi";
            this.btnSendFb.UseVisualStyleBackColor = false;
            this.btnSendFb.Click += new System.EventHandler(this.btnSendFb_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 745);
            this.Controls.Add(this.btnSendFb);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblBinhLuan);
            this.Controls.Add(this.cbbRating);
            this.Controls.Add(this.lblDanhGia);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblBinhLuan;
        private System.Windows.Forms.ComboBox cbbRating;
        private System.Windows.Forms.Label lblDanhGia;
        private System.Windows.Forms.Button btnSendFb;
    }
}