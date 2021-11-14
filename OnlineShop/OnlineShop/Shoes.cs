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
    public partial class Shoes : UserControl
    {
        public Shoes()
        {
            InitializeComponent();
        }

        public void change_value(string name,string br,int price, Image img, Image brand)
        {
            lbBrand.Text = br;
            lbName.Text = name;
            string money = string.Format("{0:N}", price).Replace(".00", "");
            lbPrice.Text = money + "VND";
            pctImg.BackgroundImage = img;
            pctBrand.BackgroundImage = brand;
        }

        public string get_name()
        {
            return lbName.Text;
        }

        public int get_price()
        {
            return Convert.ToInt32(lbPrice.Text.Replace(".","").Replace("VND", ""));
        }

        private bool in_Table(string name, DataTable table)
        {
            foreach(DataRow row in table.Rows)
            {
                string row_name = row["Name"].ToString();
                if (row_name == name)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string name = lbName.Text;
            string brand = lbBrand.Text;
            int price = Convert.ToInt32(lbPrice.Text.Replace("VND","").Replace(",",""));

            bool check = in_Table(name, DataFrame.Product);
            if (!check)
                DataFrame.Product.Rows.Add(name, brand, price);
        }
    }
}
