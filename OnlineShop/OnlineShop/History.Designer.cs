
namespace OnlineShop
{
    partial class History
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
            this.tbControlOrder = new Guna.UI2.WinForms.Guna2TabControl();
            this.pageOrder = new System.Windows.Forms.TabPage();
            this.pageHistory = new System.Windows.Forms.TabPage();
            this.txtSum = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.dateTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuy = new Guna.UI2.WinForms.Guna2Button();
            this.lstViewOrder = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbBuy = new System.Windows.Forms.Label();
            this.lbDelete = new System.Windows.Forms.Label();
            this.tbControlOrder.SuspendLayout();
            this.pageHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControlOrder
            // 
            this.tbControlOrder.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tbControlOrder.Controls.Add(this.pageOrder);
            this.tbControlOrder.Controls.Add(this.pageHistory);
            this.tbControlOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlOrder.ItemSize = new System.Drawing.Size(180, 40);
            this.tbControlOrder.Location = new System.Drawing.Point(0, 0);
            this.tbControlOrder.Name = "tbControlOrder";
            this.tbControlOrder.SelectedIndex = 0;
            this.tbControlOrder.Size = new System.Drawing.Size(821, 438);
            this.tbControlOrder.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tbControlOrder.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbControlOrder.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbControlOrder.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tbControlOrder.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbControlOrder.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tbControlOrder.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbControlOrder.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbControlOrder.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tbControlOrder.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbControlOrder.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbControlOrder.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tbControlOrder.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tbControlOrder.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbControlOrder.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tbControlOrder.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tbControlOrder.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tbControlOrder.TabIndex = 0;
            this.tbControlOrder.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbControlOrder.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalBottom;
            this.tbControlOrder.SelectedIndexChanged += new System.EventHandler(this.tbControlOrder_SelectedIndexChanged);
            // 
            // pageOrder
            // 
            this.pageOrder.Location = new System.Drawing.Point(4, 4);
            this.pageOrder.Name = "pageOrder";
            this.pageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.pageOrder.Size = new System.Drawing.Size(813, 390);
            this.pageOrder.TabIndex = 0;
            this.pageOrder.Text = "Đơn hàng";
            this.pageOrder.UseVisualStyleBackColor = true;
            // 
            // pageHistory
            // 
            this.pageHistory.Controls.Add(this.txtSum);
            this.pageHistory.Controls.Add(this.lbDelete);
            this.pageHistory.Controls.Add(this.lbBuy);
            this.pageHistory.Controls.Add(this.label5);
            this.pageHistory.Controls.Add(this.label4);
            this.pageHistory.Controls.Add(this.label3);
            this.pageHistory.Controls.Add(this.label2);
            this.pageHistory.Controls.Add(this.label1);
            this.pageHistory.Controls.Add(this.btnFilter);
            this.pageHistory.Controls.Add(this.dateTo);
            this.pageHistory.Controls.Add(this.dateFrom);
            this.pageHistory.Controls.Add(this.btnRefresh);
            this.pageHistory.Controls.Add(this.btnBuy);
            this.pageHistory.Controls.Add(this.lstViewOrder);
            this.pageHistory.Location = new System.Drawing.Point(4, 4);
            this.pageHistory.Name = "pageHistory";
            this.pageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.pageHistory.Size = new System.Drawing.Size(813, 390);
            this.pageHistory.TabIndex = 1;
            this.pageHistory.Text = "Đã xử lý";
            this.pageHistory.UseVisualStyleBackColor = true;
            // 
            // txtSum
            // 
            this.txtSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSum.DefaultText = "";
            this.txtSum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSum.DisabledState.Parent = this.txtSum;
            this.txtSum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSum.FocusedState.Parent = this.txtSum;
            this.txtSum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSum.HoverState.Parent = this.txtSum;
            this.txtSum.Location = new System.Drawing.Point(622, 104);
            this.txtSum.Name = "txtSum";
            this.txtSum.PasswordChar = '\0';
            this.txtSum.PlaceholderText = "";
            this.txtSum.ReadOnly = true;
            this.txtSum.SelectedText = "";
            this.txtSum.ShadowDecoration.Parent = this.txtSum;
            this.txtSum.Size = new System.Drawing.Size(185, 26);
            this.txtSum.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(619, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng tiền đã thanh toán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From:";
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::OnlineShop.Properties.Resources.filter;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFilter.CheckedState.Parent = this.btnFilter;
            this.btnFilter.CustomImages.Parent = this.btnFilter;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.DisabledState.Parent = this.btnFilter;
            this.btnFilter.FillColor = System.Drawing.Color.Transparent;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.HoverState.Parent = this.btnFilter;
            this.btnFilter.Location = new System.Drawing.Point(322, 42);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.ShadowDecoration.Parent = this.btnFilter;
            this.btnFilter.Size = new System.Drawing.Size(40, 36);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dateTo
            // 
            this.dateTo.CheckedState.Parent = this.dateTo;
            this.dateTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTo.HoverState.Parent = this.dateTo;
            this.dateTo.Location = new System.Drawing.Point(92, 42);
            this.dateTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTo.Name = "dateTo";
            this.dateTo.ShadowDecoration.Parent = this.dateTo;
            this.dateTo.Size = new System.Drawing.Size(224, 36);
            this.dateTo.TabIndex = 3;
            this.dateTo.Value = new System.DateTime(2021, 11, 4, 16, 59, 6, 161);
            // 
            // dateFrom
            // 
            this.dateFrom.CheckedState.Parent = this.dateFrom;
            this.dateFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateFrom.HoverState.Parent = this.dateFrom;
            this.dateFrom.Location = new System.Drawing.Point(92, 0);
            this.dateFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.ShadowDecoration.Parent = this.dateFrom;
            this.dateFrom.Size = new System.Drawing.Size(224, 36);
            this.dateFrom.TabIndex = 3;
            this.dateFrom.Value = new System.DateTime(2021, 11, 4, 16, 59, 6, 161);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Snow;
            this.btnRefresh.BackgroundImage = global::OnlineShop.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.DisabledState.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(772, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(35, 32);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuy.CheckedState.Parent = this.btnBuy;
            this.btnBuy.CustomImages.Parent = this.btnBuy;
            this.btnBuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuy.DisabledState.Parent = this.btnBuy;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.HoverState.Parent = this.btnBuy;
            this.btnBuy.Location = new System.Drawing.Point(703, 48);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.ShadowDecoration.Parent = this.btnBuy;
            this.btnBuy.Size = new System.Drawing.Size(107, 30);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Mua lại";
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lstViewOrder
            // 
            this.lstViewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstViewOrder.HideSelection = false;
            this.lstViewOrder.Location = new System.Drawing.Point(3, 133);
            this.lstViewOrder.Name = "lstViewOrder";
            this.lstViewOrder.Size = new System.Drawing.Size(807, 254);
            this.lstViewOrder.TabIndex = 0;
            this.lstViewOrder.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số đơn đã nhận:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số đơn đã hủy:";
            // 
            // lbBuy
            // 
            this.lbBuy.AutoSize = true;
            this.lbBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuy.Location = new System.Drawing.Point(178, 90);
            this.lbBuy.Name = "lbBuy";
            this.lbBuy.Size = new System.Drawing.Size(17, 17);
            this.lbBuy.TabIndex = 6;
            this.lbBuy.Text = "0";
            // 
            // lbDelete
            // 
            this.lbDelete.AutoSize = true;
            this.lbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelete.Location = new System.Drawing.Point(178, 113);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(17, 17);
            this.lbDelete.TabIndex = 6;
            this.lbDelete.Text = "0";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(821, 438);
            this.Controls.Add(this.tbControlOrder);
            this.Name = "History";
            this.Text = "History";
            this.tbControlOrder.ResumeLayout(false);
            this.pageHistory.ResumeLayout(false);
            this.pageHistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tbControlOrder;
        private System.Windows.Forms.TabPage pageOrder;
        private System.Windows.Forms.TabPage pageHistory;
        private System.Windows.Forms.ListView lstViewOrder;
        private Guna.UI2.WinForms.Guna2Button btnBuy;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateFrom;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDelete;
        private System.Windows.Forms.Label lbBuy;
    }
}