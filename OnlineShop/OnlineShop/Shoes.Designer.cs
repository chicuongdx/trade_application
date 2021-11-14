
namespace OnlineShop
{
    partial class Shoes
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
            this.pnlShoes = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pctBrand = new System.Windows.Forms.PictureBox();
            this.btnCheck = new Guna.UI2.WinForms.Guna2Button();
            this.pctImg = new System.Windows.Forms.PictureBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbBrand = new System.Windows.Forms.Label();
            this.pnlShoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlShoes
            // 
            this.pnlShoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlShoes.BackColor = System.Drawing.Color.Transparent;
            this.pnlShoes.BackgroundImage = global::OnlineShop.Properties.Resources.shoe;
            this.pnlShoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlShoes.Controls.Add(this.lbBrand);
            this.pnlShoes.Controls.Add(this.pctBrand);
            this.pnlShoes.Controls.Add(this.btnCheck);
            this.pnlShoes.Controls.Add(this.pctImg);
            this.pnlShoes.Controls.Add(this.lbPrice);
            this.pnlShoes.Controls.Add(this.lbName);
            this.pnlShoes.FillColor = System.Drawing.Color.PaleGreen;
            this.pnlShoes.FillColor2 = System.Drawing.Color.LightSkyBlue;
            this.pnlShoes.Location = new System.Drawing.Point(0, 0);
            this.pnlShoes.Name = "pnlShoes";
            this.pnlShoes.ShadowDecoration.Parent = this.pnlShoes;
            this.pnlShoes.Size = new System.Drawing.Size(220, 200);
            this.pnlShoes.TabIndex = 5;
            // 
            // pctBrand
            // 
            this.pctBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctBrand.Image = global::OnlineShop.Properties.Resources.shoe;
            this.pctBrand.Location = new System.Drawing.Point(141, 29);
            this.pctBrand.Name = "pctBrand";
            this.pctBrand.Size = new System.Drawing.Size(35, 35);
            this.pctBrand.TabIndex = 6;
            this.pctBrand.TabStop = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.CheckedState.Parent = this.btnCheck;
            this.btnCheck.CustomImages.Parent = this.btnCheck;
            this.btnCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheck.DisabledState.Parent = this.btnCheck;
            this.btnCheck.FocusedColor = System.Drawing.Color.Transparent;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.HoverState.Parent = this.btnCheck;
            this.btnCheck.Image = global::OnlineShop.Properties.Resources.cart;
            this.btnCheck.Location = new System.Drawing.Point(182, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.ShadowDecoration.Parent = this.btnCheck;
            this.btnCheck.Size = new System.Drawing.Size(35, 35);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // pctImg
            // 
            this.pctImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctImg.BackgroundImage = global::OnlineShop.Properties.Resources.shoe;
            this.pctImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctImg.Location = new System.Drawing.Point(36, 49);
            this.pctImg.Name = "pctImg";
            this.pctImg.Size = new System.Drawing.Size(120, 100);
            this.pctImg.TabIndex = 4;
            this.pctImg.TabStop = false;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbPrice.Location = new System.Drawing.Point(6, 3);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbPrice.Size = new System.Drawing.Size(17, 19);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "0";
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(3, 183);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(39, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrand.Location = new System.Drawing.Point(33, 33);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(40, 13);
            this.lbBrand.TabIndex = 7;
            this.lbBrand.Text = "Brand";
            // 
            // Shoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.pnlShoes);
            this.DoubleBuffered = true;
            this.Name = "Shoes";
            this.Size = new System.Drawing.Size(220, 200);
            this.pnlShoes.ResumeLayout(false);
            this.pnlShoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel pnlShoes;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.PictureBox pctImg;
        private Guna.UI2.WinForms.Guna2Button btnCheck;
        private System.Windows.Forms.PictureBox pctBrand;
        private System.Windows.Forms.Label lbBrand;
    }
}
