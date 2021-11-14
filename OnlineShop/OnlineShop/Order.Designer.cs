
namespace OnlineShop
{
    partial class Order
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctImg = new System.Windows.Forms.PictureBox();
            this.pnlOrder = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPay = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.lbAmount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbBrand = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pctImg)).BeginInit();
            this.pnlOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctImg
            // 
            this.pctImg.BackColor = System.Drawing.Color.Transparent;
            this.pctImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctImg.Location = new System.Drawing.Point(0, 0);
            this.pctImg.Name = "pctImg";
            this.pctImg.Size = new System.Drawing.Size(150, 164);
            this.pctImg.TabIndex = 0;
            this.pctImg.TabStop = false;
            // 
            // pnlOrder
            // 
            this.pnlOrder.Controls.Add(this.lbSize);
            this.pnlOrder.Controls.Add(this.label3);
            this.pnlOrder.Controls.Add(this.lbAdress);
            this.pnlOrder.Controls.Add(this.lbSDT);
            this.pnlOrder.Controls.Add(this.label1);
            this.pnlOrder.Controls.Add(this.txtPay);
            this.pnlOrder.Controls.Add(this.btnRemove);
            this.pnlOrder.Controls.Add(this.btnConfirm);
            this.pnlOrder.Controls.Add(this.lbAmount);
            this.pnlOrder.Controls.Add(this.label2);
            this.pnlOrder.Controls.Add(this.lbBrand);
            this.pnlOrder.Controls.Add(this.lbName);
            this.pnlOrder.Controls.Add(this.pctImg);
            this.pnlOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlOrder.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlOrder.Location = new System.Drawing.Point(0, 0);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.ShadowDecoration.Parent = this.pnlOrder;
            this.pnlOrder.Size = new System.Drawing.Size(665, 164);
            this.pnlOrder.TabIndex = 1;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.BackColor = System.Drawing.Color.Transparent;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(202, 113);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(24, 17);
            this.lbSize.TabIndex = 6;
            this.lbSize.Text = "34";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Size:";
            // 
            // lbAdress
            // 
            this.lbAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAdress.AutoSize = true;
            this.lbAdress.BackColor = System.Drawing.Color.Transparent;
            this.lbAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdress.Location = new System.Drawing.Point(156, 84);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(59, 20);
            this.lbAdress.TabIndex = 4;
            this.lbAdress.Text = "Adress";
            // 
            // lbSDT
            // 
            this.lbSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSDT.AutoSize = true;
            this.lbSDT.BackColor = System.Drawing.Color.Transparent;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(156, 57);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(18, 20);
            this.lbSDT.TabIndex = 4;
            this.lbSDT.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "VND";
            // 
            // txtPay
            // 
            this.txtPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPay.BackColor = System.Drawing.Color.Transparent;
            this.txtPay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPay.DefaultText = "0";
            this.txtPay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPay.DisabledState.Parent = this.txtPay;
            this.txtPay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPay.FocusedState.Parent = this.txtPay;
            this.txtPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPay.HoverState.Parent = this.txtPay;
            this.txtPay.Location = new System.Drawing.Point(464, 84);
            this.txtPay.Name = "txtPay";
            this.txtPay.PasswordChar = '\0';
            this.txtPay.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtPay.PlaceholderText = "";
            this.txtPay.SelectedText = "";
            this.txtPay.SelectionStart = 1;
            this.txtPay.ShadowDecoration.Parent = this.txtPay;
            this.txtPay.Size = new System.Drawing.Size(156, 26);
            this.txtPay.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.DisabledState.Parent = this.btnRemove;
            this.btnRemove.FillColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Location = new System.Drawing.Point(464, 116);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(94, 45);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Hủy đơn";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.DisabledState.Parent = this.btnConfirm;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Location = new System.Drawing.Point(564, 116);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(94, 45);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Xác nhận nhận hàng";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbAmount
            // 
            this.lbAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbAmount.Location = new System.Drawing.Point(156, 142);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(11, 19);
            this.lbAmount.TabIndex = 1;
            this.lbAmount.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(574, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đang giao...";
            // 
            // lbBrand
            // 
            this.lbBrand.BackColor = System.Drawing.Color.Transparent;
            this.lbBrand.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrand.ForeColor = System.Drawing.Color.DarkRed;
            this.lbBrand.Location = new System.Drawing.Point(156, 35);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(44, 19);
            this.lbBrand.TabIndex = 1;
            this.lbBrand.Text = "Brand";
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(156, 3);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 26);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlOrder);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(665, 164);
            ((System.ComponentModel.ISupportInitialize)(this.pctImg)).EndInit();
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctImg;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlOrder;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbName;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2TextBox txtPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbAdress;
        private Guna.UI2.WinForms.Guna2HtmlLabel label2;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label3;
    }
}
