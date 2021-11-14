
namespace OnlineShop
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.gunaBtnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.pctIcon = new System.Windows.Forms.PictureBox();
            this.gunaBtnCart = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBtnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTile = new System.Windows.Forms.Panel();
            this.ctrlHide = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrlMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gunaPnlForm = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.ShadowPnl = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.checkBoxAnanas = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkBoxConverse = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkBoxPuma = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkBoxNike = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gunaPctAll = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunTxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.imgLstProduct = new System.Windows.Forms.ImageList(this.components);
            this.imgLstBrand = new System.Windows.Forms.ImageList(this.components);
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcon)).BeginInit();
            this.pnlTile.SuspendLayout();
            this.gunaPnlForm.SuspendLayout();
            this.ShadowPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPctAll)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.pnlMenu.Controls.Add(this.gunaBtnHistory);
            this.pnlMenu.Controls.Add(this.pctIcon);
            this.pnlMenu.Controls.Add(this.gunaBtnCart);
            this.pnlMenu.Controls.Add(this.gunaBtnProduct);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(128, 450);
            this.pnlMenu.TabIndex = 0;
            // 
            // gunaBtnHistory
            // 
            this.gunaBtnHistory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaBtnHistory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.gunaBtnHistory.CheckedState.Parent = this.gunaBtnHistory;
            this.gunaBtnHistory.CustomImages.Parent = this.gunaBtnHistory;
            this.gunaBtnHistory.DisabledState.BorderColor = System.Drawing.Color.Lime;
            this.gunaBtnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.Lime;
            this.gunaBtnHistory.DisabledState.FillColor = System.Drawing.Color.Lime;
            this.gunaBtnHistory.DisabledState.ForeColor = System.Drawing.Color.Lime;
            this.gunaBtnHistory.DisabledState.Parent = this.gunaBtnHistory;
            this.gunaBtnHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.gunaBtnHistory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaBtnHistory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaBtnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaBtnHistory.HoverState.Parent = this.gunaBtnHistory;
            this.gunaBtnHistory.Image = global::OnlineShop.Properties.Resources.history;
            this.gunaBtnHistory.Location = new System.Drawing.Point(12, 225);
            this.gunaBtnHistory.Name = "gunaBtnHistory";
            this.gunaBtnHistory.ShadowDecoration.Parent = this.gunaBtnHistory;
            this.gunaBtnHistory.Size = new System.Drawing.Size(107, 33);
            this.gunaBtnHistory.TabIndex = 2;
            this.gunaBtnHistory.Text = "Đơn hàng";
            this.gunaBtnHistory.Click += new System.EventHandler(this.gunaBtnHistory_Click);
            // 
            // pctIcon
            // 
            this.pctIcon.BackColor = System.Drawing.Color.White;
            this.pctIcon.BackgroundImage = global::OnlineShop.Properties.Resources.shoe;
            this.pctIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctIcon.Location = new System.Drawing.Point(0, 0);
            this.pctIcon.Name = "pctIcon";
            this.pctIcon.Size = new System.Drawing.Size(128, 108);
            this.pctIcon.TabIndex = 0;
            this.pctIcon.TabStop = false;
            this.pctIcon.Click += new System.EventHandler(this.pctIcon_Click);
            // 
            // gunaBtnCart
            // 
            this.gunaBtnCart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaBtnCart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.gunaBtnCart.CheckedState.Parent = this.gunaBtnCart;
            this.gunaBtnCart.CustomImages.Parent = this.gunaBtnCart;
            this.gunaBtnCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBtnCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBtnCart.DisabledState.Parent = this.gunaBtnCart;
            this.gunaBtnCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.gunaBtnCart.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaBtnCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaBtnCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaBtnCart.HoverState.Parent = this.gunaBtnCart;
            this.gunaBtnCart.Image = global::OnlineShop.Properties.Resources.paper_bag;
            this.gunaBtnCart.Location = new System.Drawing.Point(12, 169);
            this.gunaBtnCart.Name = "gunaBtnCart";
            this.gunaBtnCart.ShadowDecoration.Parent = this.gunaBtnCart;
            this.gunaBtnCart.Size = new System.Drawing.Size(107, 33);
            this.gunaBtnCart.TabIndex = 2;
            this.gunaBtnCart.Text = "Giỏ hàng";
            this.gunaBtnCart.Click += new System.EventHandler(this.gunaBtnCart_Click);
            // 
            // gunaBtnProduct
            // 
            this.gunaBtnProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaBtnProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.gunaBtnProduct.CheckedState.Parent = this.gunaBtnProduct;
            this.gunaBtnProduct.CustomImages.Parent = this.gunaBtnProduct;
            this.gunaBtnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBtnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBtnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBtnProduct.DisabledState.Parent = this.gunaBtnProduct;
            this.gunaBtnProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.gunaBtnProduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaBtnProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaBtnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaBtnProduct.HoverState.Parent = this.gunaBtnProduct;
            this.gunaBtnProduct.Image = global::OnlineShop.Properties.Resources.product;
            this.gunaBtnProduct.Location = new System.Drawing.Point(12, 115);
            this.gunaBtnProduct.Name = "gunaBtnProduct";
            this.gunaBtnProduct.ShadowDecoration.Parent = this.gunaBtnProduct;
            this.gunaBtnProduct.Size = new System.Drawing.Size(107, 33);
            this.gunaBtnProduct.TabIndex = 2;
            this.gunaBtnProduct.Text = "Sản phẩm";
            this.gunaBtnProduct.Click += new System.EventHandler(this.gunaBtnProduct_Click);
            // 
            // pnlTile
            // 
            this.pnlTile.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pnlTile.Controls.Add(this.ctrlHide);
            this.pnlTile.Controls.Add(this.ctrlMax);
            this.pnlTile.Controls.Add(this.ctrlClose);
            this.pnlTile.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTile.Location = new System.Drawing.Point(128, 0);
            this.pnlTile.Name = "pnlTile";
            this.pnlTile.Size = new System.Drawing.Size(672, 29);
            this.pnlTile.TabIndex = 1;
            this.pnlTile.DoubleClick += new System.EventHandler(this.pnlTile_DoubleClick);
            this.pnlTile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTile_MouseMove);
            // 
            // ctrlHide
            // 
            this.ctrlHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlHide.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ctrlHide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ctrlHide.HoverState.Parent = this.ctrlHide;
            this.ctrlHide.IconColor = System.Drawing.Color.LightGray;
            this.ctrlHide.Location = new System.Drawing.Point(531, 3);
            this.ctrlHide.Name = "ctrlHide";
            this.ctrlHide.ShadowDecoration.BorderRadius = 10;
            this.ctrlHide.ShadowDecoration.Parent = this.ctrlHide;
            this.ctrlHide.Size = new System.Drawing.Size(42, 22);
            this.ctrlHide.TabIndex = 1;
            // 
            // ctrlMax
            // 
            this.ctrlMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.ctrlMax.FillColor = System.Drawing.Color.Gray;
            this.ctrlMax.HoverState.Parent = this.ctrlMax;
            this.ctrlMax.IconColor = System.Drawing.Color.LightGray;
            this.ctrlMax.Location = new System.Drawing.Point(579, 3);
            this.ctrlMax.Name = "ctrlMax";
            this.ctrlMax.ShadowDecoration.BorderRadius = 10;
            this.ctrlMax.ShadowDecoration.Parent = this.ctrlMax;
            this.ctrlMax.Size = new System.Drawing.Size(42, 22);
            this.ctrlMax.TabIndex = 1;
            // 
            // ctrlClose
            // 
            this.ctrlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlClose.FillColor = System.Drawing.Color.Red;
            this.ctrlClose.HoverState.Parent = this.ctrlClose;
            this.ctrlClose.IconColor = System.Drawing.Color.LightGray;
            this.ctrlClose.Location = new System.Drawing.Point(627, 3);
            this.ctrlClose.Name = "ctrlClose";
            this.ctrlClose.ShadowDecoration.BorderRadius = 10;
            this.ctrlClose.ShadowDecoration.Parent = this.ctrlClose;
            this.ctrlClose.Size = new System.Drawing.Size(42, 22);
            this.ctrlClose.TabIndex = 1;
            // 
            // gunaPnlForm
            // 
            this.gunaPnlForm.Controls.Add(this.pnlProduct);
            this.gunaPnlForm.Controls.Add(this.ShadowPnl);
            this.gunaPnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPnlForm.Location = new System.Drawing.Point(128, 29);
            this.gunaPnlForm.Name = "gunaPnlForm";
            this.gunaPnlForm.ShadowDecoration.Parent = this.gunaPnlForm;
            this.gunaPnlForm.Size = new System.Drawing.Size(672, 421);
            this.gunaPnlForm.TabIndex = 2;
            // 
            // pnlProduct
            // 
            this.pnlProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProduct.AutoScroll = true;
            this.pnlProduct.Location = new System.Drawing.Point(7, 86);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(653, 323);
            this.pnlProduct.TabIndex = 1;
            // 
            // ShadowPnl
            // 
            this.ShadowPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShadowPnl.BackColor = System.Drawing.Color.Transparent;
            this.ShadowPnl.Controls.Add(this.checkBoxAnanas);
            this.ShadowPnl.Controls.Add(this.checkBoxConverse);
            this.ShadowPnl.Controls.Add(this.checkBoxPuma);
            this.ShadowPnl.Controls.Add(this.checkBoxNike);
            this.ShadowPnl.Controls.Add(this.gunaPctAll);
            this.ShadowPnl.Controls.Add(this.gunTxtSearch);
            this.ShadowPnl.FillColor = System.Drawing.Color.White;
            this.ShadowPnl.Location = new System.Drawing.Point(6, 6);
            this.ShadowPnl.Name = "ShadowPnl";
            this.ShadowPnl.ShadowColor = System.Drawing.Color.Black;
            this.ShadowPnl.Size = new System.Drawing.Size(654, 73);
            this.ShadowPnl.TabIndex = 0;
            // 
            // checkBoxAnanas
            // 
            this.checkBoxAnanas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxAnanas.AutoSize = true;
            this.checkBoxAnanas.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxAnanas.CheckedState.BorderRadius = 0;
            this.checkBoxAnanas.CheckedState.BorderThickness = 0;
            this.checkBoxAnanas.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxAnanas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAnanas.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxAnanas.Location = new System.Drawing.Point(151, 40);
            this.checkBoxAnanas.Name = "checkBoxAnanas";
            this.checkBoxAnanas.Size = new System.Drawing.Size(79, 20);
            this.checkBoxAnanas.TabIndex = 4;
            this.checkBoxAnanas.Text = "Ananas";
            this.checkBoxAnanas.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxAnanas.UncheckedState.BorderRadius = 0;
            this.checkBoxAnanas.UncheckedState.BorderThickness = 0;
            this.checkBoxAnanas.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxAnanas.CheckedChanged += new System.EventHandler(this.check_value);
            // 
            // checkBoxConverse
            // 
            this.checkBoxConverse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxConverse.AutoSize = true;
            this.checkBoxConverse.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxConverse.CheckedState.BorderRadius = 0;
            this.checkBoxConverse.CheckedState.BorderThickness = 0;
            this.checkBoxConverse.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxConverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxConverse.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxConverse.Location = new System.Drawing.Point(151, 10);
            this.checkBoxConverse.Name = "checkBoxConverse";
            this.checkBoxConverse.Size = new System.Drawing.Size(93, 20);
            this.checkBoxConverse.TabIndex = 4;
            this.checkBoxConverse.Text = "Converse";
            this.checkBoxConverse.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxConverse.UncheckedState.BorderRadius = 0;
            this.checkBoxConverse.UncheckedState.BorderThickness = 0;
            this.checkBoxConverse.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxConverse.CheckedChanged += new System.EventHandler(this.check_value);
            // 
            // checkBoxPuma
            // 
            this.checkBoxPuma.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxPuma.AutoSize = true;
            this.checkBoxPuma.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxPuma.CheckedState.BorderRadius = 0;
            this.checkBoxPuma.CheckedState.BorderThickness = 0;
            this.checkBoxPuma.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxPuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPuma.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxPuma.Location = new System.Drawing.Point(34, 40);
            this.checkBoxPuma.Name = "checkBoxPuma";
            this.checkBoxPuma.Size = new System.Drawing.Size(66, 20);
            this.checkBoxPuma.TabIndex = 4;
            this.checkBoxPuma.Text = "Puma";
            this.checkBoxPuma.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxPuma.UncheckedState.BorderRadius = 0;
            this.checkBoxPuma.UncheckedState.BorderThickness = 0;
            this.checkBoxPuma.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxPuma.CheckedChanged += new System.EventHandler(this.check_value);
            // 
            // checkBoxNike
            // 
            this.checkBoxNike.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxNike.AutoSize = true;
            this.checkBoxNike.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxNike.CheckedState.BorderRadius = 0;
            this.checkBoxNike.CheckedState.BorderThickness = 0;
            this.checkBoxNike.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxNike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNike.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxNike.Location = new System.Drawing.Point(34, 10);
            this.checkBoxNike.Name = "checkBoxNike";
            this.checkBoxNike.Size = new System.Drawing.Size(59, 20);
            this.checkBoxNike.TabIndex = 4;
            this.checkBoxNike.Text = "Nike";
            this.checkBoxNike.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxNike.UncheckedState.BorderRadius = 0;
            this.checkBoxNike.UncheckedState.BorderThickness = 0;
            this.checkBoxNike.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxNike.CheckedChanged += new System.EventHandler(this.check_value);
            // 
            // gunaPctAll
            // 
            this.gunaPctAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaPctAll.BackColor = System.Drawing.Color.White;
            this.gunaPctAll.BackgroundImage = global::OnlineShop.Properties.Resources.find;
            this.gunaPctAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaPctAll.Image = global::OnlineShop.Properties.Resources.find;
            this.gunaPctAll.ImageRotate = 0F;
            this.gunaPctAll.Location = new System.Drawing.Point(373, 10);
            this.gunaPctAll.Name = "gunaPctAll";
            this.gunaPctAll.ShadowDecoration.Parent = this.gunaPctAll;
            this.gunaPctAll.Size = new System.Drawing.Size(50, 50);
            this.gunaPctAll.TabIndex = 3;
            this.gunaPctAll.TabStop = false;
            this.gunaPctAll.Click += new System.EventHandler(this.gunaPctAll_Click);
            // 
            // gunTxtSearch
            // 
            this.gunTxtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunTxtSearch.BorderColor = System.Drawing.Color.Purple;
            this.gunTxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunTxtSearch.DefaultText = "";
            this.gunTxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunTxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunTxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunTxtSearch.DisabledState.Parent = this.gunTxtSearch;
            this.gunTxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunTxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunTxtSearch.FocusedState.Parent = this.gunTxtSearch;
            this.gunTxtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunTxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunTxtSearch.HoverState.Parent = this.gunTxtSearch;
            this.gunTxtSearch.Location = new System.Drawing.Point(429, 20);
            this.gunTxtSearch.Name = "gunTxtSearch";
            this.gunTxtSearch.PasswordChar = '\0';
            this.gunTxtSearch.PlaceholderText = "";
            this.gunTxtSearch.SelectedText = "";
            this.gunTxtSearch.ShadowDecoration.Parent = this.gunTxtSearch;
            this.gunTxtSearch.Size = new System.Drawing.Size(200, 30);
            this.gunTxtSearch.TabIndex = 1;
            this.gunTxtSearch.TextChanged += new System.EventHandler(this.gunTxtSearch_TextChanged);
            // 
            // imgLstProduct
            // 
            this.imgLstProduct.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstProduct.ImageStream")));
            this.imgLstProduct.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstProduct.Images.SetKeyName(0, "NikeWaffleOne.jpg");
            this.imgLstProduct.Images.SetKeyName(1, "revolution.jpg");
            // 
            // imgLstBrand
            // 
            this.imgLstBrand.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstBrand.ImageStream")));
            this.imgLstBrand.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstBrand.Images.SetKeyName(0, "nike.jpg");
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaPnlForm);
            this.Controls.Add(this.pnlTile);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 728);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctIcon)).EndInit();
            this.pnlTile.ResumeLayout(false);
            this.gunaPnlForm.ResumeLayout(false);
            this.ShadowPnl.ResumeLayout(false);
            this.ShadowPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPctAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlTile;
        private Guna.UI2.WinForms.Guna2Panel gunaPnlForm;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlHide;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlMax;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlClose;
        private Guna.UI2.WinForms.Guna2Button gunaBtnProduct;
        private Guna.UI2.WinForms.Guna2Button gunaBtnHistory;
        private Guna.UI2.WinForms.Guna2Button gunaBtnCart;
        private System.Windows.Forms.PictureBox pctIcon;
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPnl;
        private Guna.UI2.WinForms.Guna2TextBox gunTxtSearch;
        private Guna.UI2.WinForms.Guna2PictureBox gunaPctAll;
        private System.Windows.Forms.ImageList imgLstProduct;
        private System.Windows.Forms.ImageList imgLstBrand;
        private System.Windows.Forms.Panel pnlProduct;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxAnanas;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxConverse;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxPuma;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxNike;
    }
}