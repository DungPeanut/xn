namespace Khách_Hàng_Luxury
{
    partial class Form3
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
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.cbbServiceType = new System.Windows.Forms.ComboBox();
            this.lblLoaiDV = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(158, 369);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(879, 51);
            this.txtNotes.TabIndex = 22;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(149, 288);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(133, 46);
            this.lblGhiChu.TabIndex = 21;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // cbbServiceType
            // 
            this.cbbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbServiceType.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbServiceType.FormattingEnabled = true;
            this.cbbServiceType.Items.AddRange(new object[] {
            "1. Giặt ủi",
            "2. Ăn uống",
            "3. Xe đưa đón",
            "4. Dịch vụ khác"});
            this.cbbServiceType.Location = new System.Drawing.Point(157, 179);
            this.cbbServiceType.Name = "cbbServiceType";
            this.cbbServiceType.Size = new System.Drawing.Size(879, 53);
            this.cbbServiceType.TabIndex = 20;
            // 
            // lblLoaiDV
            // 
            this.lblLoaiDV.AutoSize = true;
            this.lblLoaiDV.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiDV.Location = new System.Drawing.Point(150, 99);
            this.lblLoaiDV.Name = "lblLoaiDV";
            this.lblLoaiDV.Size = new System.Drawing.Size(206, 46);
            this.lblLoaiDV.TabIndex = 19;
            this.lblLoaiDV.Text = "Loại Dịch Vụ";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Turquoise;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(442, 510);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(327, 161);
            this.btnSend.TabIndex = 23;
            this.btnSend.Text = "Gửi Yêu Cầu";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Khách_Hàng_Luxury.Properties.Resources.cancel_25px;
            this.button1.Location = new System.Drawing.Point(24, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 53);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 745);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.cbbServiceType);
            this.Controls.Add(this.lblLoaiDV);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.ComboBox cbbServiceType;
        private System.Windows.Forms.Label lblLoaiDV;
        private System.Windows.Forms.Button btnSend;
    }
}