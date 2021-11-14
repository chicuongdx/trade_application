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
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
        }

        public void change_value(string name, string br, int pay, int amount, int size, int sdt, string adress, Image img)
        {
            lbBrand.Text = br;
            lbName.Text = name;
            lbSDT.Text = sdt.ToString();
            lbSize.Text = size.ToString();
            lbAdress.Text = adress;
            lbAmount.Text = "x" + amount.ToString();
            string money = string.Format("{0:N}", pay).Replace(".00", "");
            txtPay.Text = money;
            pctImg.BackgroundImage = img;
        }

        private void Remove_Data(string s)
        {
            string key = "Name='" + s + "'";
            DataRow row = DataFrame.Order.Select(key)[0];
            row.Delete();
            DataFrame.Order.AcceptChanges();
            this.Parent.Controls.Remove(this);
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string name = lbName.Text;
            string brand = lbBrand.Text;
            int pay = Convert.ToInt32(txtPay.Text.Replace(",", ""));
            int amount = Convert.ToInt32(lbAmount.Text.Replace("x", ""));
            int size = Convert.ToInt32(lbSize.Text);
            int sdt = Convert.ToInt32(lbSDT.Text);
            string adress = lbAdress.Text;
            string status = "Đã nhận hàng";
            DateTime date = DateTime.Now;
            DataFrame.History.Rows.Add(DataFrame.ID, name, brand, pay, amount, size, sdt, adress, date, status);
            Remove_Data(name);
            MessageBox.Show("Xác nhận nhận hàng thành công");
            DataFrame.ID += 1;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string name = lbName.Text;
            string brand = lbBrand.Text;
            int pay = Convert.ToInt32(txtPay.Text.Replace(",", ""));
            int amount = Convert.ToInt32(lbAmount.Text.Replace("x", ""));
            int size = Convert.ToInt32(lbSize.Text);
            int sdt = Convert.ToInt32(lbSDT.Text);
            string adress = lbAdress.Text;
            string status = "Hủy đơn";
            DateTime date = DateTime.Now;
            DataFrame.History.Rows.Add(DataFrame.ID, name, brand, pay, amount, size, sdt, adress, date, status);
            Remove_Data(name);
            MessageBox.Show("Xác nhận hủy đơn");
            DataFrame.ID += 1;
        }
    }
}
