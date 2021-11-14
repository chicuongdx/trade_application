using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }


        public void change_value(string name, string br, int price, Image img)
        {
            lbBrand.Text = br;
            lbName.Text = name;
            string money = string.Format("{0:N}", price).Replace(".00", "");
            lbPrice.Text = money + "VND";
            pctImg.BackgroundImage = img;
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
                string s = "Name='" + lbName.Text + "'";
                DataRow row = DataFrame.Product.Select(s)[0];
                row.Delete();
                DataFrame.Product.AcceptChanges();
                this.Parent.Controls.Remove(this);
                
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;

        private void btnPay_Product_Click(object sender, EventArgs e)
        {
            Cart.Var_Name = lbName.Text;
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
    }
}
