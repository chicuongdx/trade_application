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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            Load_Data(DataFrame.Product);
        }

        private void Load_Data(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                string name = row["Name"].ToString();
                string brand = row["Brand"].ToString();
                int price = Convert.ToInt32(row["Price"]);
                Product item = new Product()
                {
                    Dock = DockStyle.Top,

                };
                try
                {
                    string path_shoes = Application.StartupPath.Replace("\\", "/") + "/Product/Image/" + name + ".jfif";
                    string path_brand = Application.StartupPath.Replace("\\", "/") + "/Product/Brand/" + brand + ".jpg";
                    item.change_value(name, brand, price, Image.FromFile(path_shoes));
                }
                catch
                {
                    string path_shoes = Application.StartupPath.Replace("\\", "/") + "/Product/Image/" + name + ".jpg";
                    string path_brand = Application.StartupPath.Replace("\\", "/") + "/Product/Brand/" + brand + ".jpg";
                    item.change_value(name, brand, price, Image.FromFile(path_shoes));
                }
                pnlControl.Controls.Add(item);
                item.ButtonClick += Item_Click;
            }
        }

        //menu pay
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtAmount.Text = (Convert.ToInt32(txtAmount.Text) + 1).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text != "1")
            {
                txtAmount.Text = (Convert.ToInt32(txtAmount.Text) - 1).ToString();
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int amount = Convert.ToInt32(txtAmount.Text);
                string select = "Name='" + lbName.Text + "'";
                DataRow row = DataFrame.Shoes.Select(select)[0];

                int price = Convert.ToInt32(row["Price"]);

                string pay = string.Format("{0:N}", (amount * price)).Replace(".00", "") + "VND";
                lbPay.Text = pay;
            }
            catch { }
        }

        //choose item
        public static string Var_Name { get; set; }

        private void Item_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txtAmount.Text);
            string select = "Name='" + Var_Name + "'";
            DataRow row = DataFrame.Shoes.Select(select)[0];

            int price = Convert.ToInt32(row["Price"]);

            string pay = string.Format("{0:N}", (amount * price)).Replace(".00", "") + "VND";
            string path_shoes = "";
            try
            {
                path_shoes = Application.StartupPath.Replace("\\", "/") + "/Product/Image/" + Var_Name + ".jfif";
                pctImg.BackgroundImage = Image.FromFile(path_shoes);
            }
            catch
            {
                path_shoes = Application.StartupPath.Replace("\\", "/") + "/Product/Image/" + Var_Name + ".jpg";
                pctImg.BackgroundImage = Image.FromFile(path_shoes);
            }
            lbName.Text = Var_Name;
            lbBrand.Text = row["Brand"].ToString();
            lbPay.Text = pay;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (numSize.Value < 34)
                MessageBox.Show("Vui lòng chọn size lớn hơn");
            else
            {
                try
                {
                    string name = lbName.Text;
                    string brand = lbBrand.Text;
                    int pay = Convert.ToInt32(lbPay.Text.Replace("VND", "").Replace(",", ""));
                    int amount = Convert.ToInt32(txtAmount.Text);
                    int size = Convert.ToInt32(numSize.Value);
                    int sdt = Convert.ToInt32(txtPhone.Text);
                    string adress = txtAdress.Text;
                    DataFrame.Order.Rows.Add(name, brand, pay, amount, size, sdt, adress);
                    MessageBox.Show("Đặt hàng thành công - " + lbName.Text);

                    string s = "Name='" + lbName.Text + "'";
                    DataRow row = DataFrame.Product.Select(s)[0];
                    row.Delete();
                    DataFrame.Product.AcceptChanges();
                    pnlControl.Controls.Clear();
                    Load_Data(DataFrame.Product);

                    lbName.Text = "Name";
                    lbBrand.Text = "Brand";
                    pctImg.BackgroundImage = null;
                }
                catch { MessageBox.Show("- Hãy chọn hàng.\n- Điền đầy đủ thông tin!"); }
            }
        }


        private int Sale_Ser(string code)
        {
            List<string> code50 = new List<string>
            { "THUGSTOOLS", "PROFESSIONALTOOLS", "NUTTERTOOLS", "ASPIRINE", "GESUNDHEIT", "IFIWEREARICHMAN", "PRECIOUSPROTECTION", "GUNSGUNSGUNS", "FANNYMAGNET", "YOUWONTTAKEMEALIVE", "LEAVEMEALONE", "CANTTAKEITANYMORE"};
            List<string> code25 = new List<string>
            { "DEEPFRIEDMARSBARS", "PROGRAMMER", "STILLLIKEDRESSINGUP", "CERTAINDEATH", "HOPINGIRL", "CHEATSHAVEBEENCRACKED", "LOOKLIKELANCE", "MYSONISALAWYER", "LOOKLIKEHILARY", "ROCKANDROLLMAN ", "WELOVEOURDICK", "ONEARMEDBANDIT", "IDONTHAVETHEMONEYSONNY", "FOXYLITTLETHING"};
            List<string> code10 = new List<string>
            { "PANZER", "GIVEUSATANK", "TRAVELINSTYLE", "GETTHEREQUICKLY", "GETTHEREFAST", "GETTHEREVERYFASTINDEED", "GETTHEREAMAZINGLYFAST", "THELASTRIDE", "ROCKANDROLLCAR", "RUBBISHCAR", "BETTERTHANWALKING", "LOADSOFLITTLETHINGS", "AIRSHIP", "BIGBANG", "MIAMITRAFFIC", "AHAIRDRESSERSCAR", "IWANTITPAINTEDBLACK"};

            int Sale = 100;
            if (code50.Contains(code))
            {
                Sale = 50;
            }
            if (code25.Contains(code))
            {
                Sale = 75;
            }
            if (code10.Contains(code))
            {
                Sale = 90;
            }
            return Sale;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int Sale = Sale_Ser(txtCode.Text);
            int money = Convert.ToInt32(lbPay.Text.Replace(",", "").Replace("VND", "")); ;
            int pay = money * Sale / 100;
            lbPay.Text = string.Format("{0:N}", pay).Replace(".00", "") + "VND";

            lbSale.Text = "-" + (100 - Sale).ToString() + "%";
        }
    }
}
