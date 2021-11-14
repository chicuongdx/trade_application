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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            Load_Data(DataFrame.Order);
        }

        private void tbControlOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_List(DataFrame.History);
        }

        private void Load_Data(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                string name = row["Name"].ToString();
                string brand = row["Brand"].ToString();
                int pay = Convert.ToInt32(row["Pay"]);
                int amount = Convert.ToInt32(row["Amount"]);
                int size = Convert.ToInt32(row["Size"]);
                int sdt = Convert.ToInt32(row["SDT"]);
                string adress = row["Adress"].ToString();

                Order item = new Order()
                {
                    Dock = DockStyle.Top,

                };
                try
                {
                    string path_shoes = Application.StartupPath.Replace("\\", "/") + "/Product/Image/" + name + ".jfif";
                    string path_brand = Application.StartupPath.Replace("\\", "/") + "/Product/Brand/" + brand + ".jpg";
                    item.change_value(name, brand, pay, amount, size, sdt, adress, Image.FromFile(path_shoes));
                }
                catch
                {
                    string path_shoes = Application.StartupPath.Replace("\\", "/") + "/Product/Image/" + name + ".jpg";
                    string path_brand = Application.StartupPath.Replace("\\", "/") + "/Product/Brand/" + brand + ".jpg";
                    item.change_value(name, brand, pay, amount, size, sdt, adress, Image.FromFile(path_shoes));
                }
                pageOrder.Controls.Add(item);
            }
        }

        //Page lịch sử hoá đơn

        private int Count_Status(DataTable table, string s)
        {
            int res = 0;
            foreach (DataRow row in table.Rows)
            {
                string str = row["Status"].ToString();
                if (s == str)
                    res++;
            }
            return res;
        }
        private void Load_List(DataTable table)
        {
            
            lstViewOrder.View = View.Details;

            lstViewOrder.Clear();

            lstViewOrder.Columns.Add("ID", 50);
            lstViewOrder.Columns.Add("Tên hàng", 200);
            lstViewOrder.Columns.Add("Hiệu", 80);
            lstViewOrder.Columns.Add("Số lượng", 80);
            lstViewOrder.Columns.Add("Size", 50);
            lstViewOrder.Columns.Add("Số điện thoại", 150);
            lstViewOrder.Columns.Add("Địa chỉ", 250);
            lstViewOrder.Columns.Add("Thanh toán (VND)", 100);
            lstViewOrder.Columns.Add("Ngày", 150);
            lstViewOrder.Columns.Add("Trạng thái", 200);
            foreach(DataRow row in table.Rows)
            {
                int ID = Convert.ToInt32(row["ID"]);
                string name = row["Name"].ToString();
                string brand = row["Brand"].ToString();
                int pay = Convert.ToInt32(row["Pay"]);
                int amount = Convert.ToInt32(row["Amount"]);
                int size = Convert.ToInt32(row["Size"]);
                int sdt = Convert.ToInt32(row["SDT"]);
                string address = row["Adress"].ToString();
                DateTime date = (DateTime)row["Date"];
                string status = row["Status"].ToString();
                Item_Add(ID, name, brand, amount, size, sdt, address, pay, date, status);
            }
            Sum_Pay(table);
            string num_buy = Count_Status(table, "Đã nhận hàng").ToString();
            string num_dele = Count_Status(table, "Hủy đơn").ToString();
            lbBuy.Text = num_buy;
            lbDelete.Text = num_dele;
        }
        private void Item_Add(int ID, string name, string brand, int num, int size, int sdt, string address, int pay, DateTime time, string status)
        {
            ListViewItem temp = new ListViewItem(ID.ToString());
            temp.SubItems.Add(name);
            temp.SubItems.Add(brand);
            temp.SubItems.Add(num.ToString());
            temp.SubItems.Add(size.ToString());
            temp.SubItems.Add(sdt.ToString());
            temp.SubItems.Add(address);
            temp.SubItems.Add(string.Format("{0:N}", pay).Replace(".00", ""));

            //dd/mm/yyyy
            string date = time.Day + "/" + time.Month + "/" + time.Year;
            temp.SubItems.Add(date);
            temp.SubItems.Add(status);

            lstViewOrder.Items.Add(temp);
        }

        //buy again
        private bool in_Table(string name, DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                string row_name = row["Name"].ToString();
                if (row_name == name)
                {
                    return true;
                }
            }
            return false;
        }
        private void BuyAgain(ListViewItem item)
        {
            string name = item.SubItems[1].Text;
            string brand = item.SubItems[2].Text;
            DataRow row = DataFrame.Shoes.Select("Name='" + name + "'")[0];
            int price = Convert.ToInt32(row["Price"]);

            bool check = in_Table(name, DataFrame.Product);
            if (!check)
                DataFrame.Product.Rows.Add(name, brand, price);
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lstViewOrder.SelectedItems.Count; i++)
                {
                    ListViewItem item = lstViewOrder.SelectedItems[i];
                    BuyAgain(item);
                    MessageBox.Show("Đã thêm vào giỏ hàng");
                }
            }
            catch { MessageBox.Show("Vui lòng chọn đơn!"); }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_List(DataFrame.History);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string time1 = dateFrom.Value.Month + "/" + dateFrom.Value.Day + "/" + dateFrom.Value.Year;
            string time2 = dateTo.Value.Month + "/" + dateTo.Value.Day + "/" + dateTo.Value.Year;

            DataRow[] dr = DataFrame.History.Select("Date >= #" + time1 + "# AND Date <= #" + time2 + "#");
            DataTable table = DataFrame.New_DataHistory();

            foreach(DataRow row in dr)
            {
                table.ImportRow(row);
            }
            Load_List(table);

        }
        private void Sum_Pay(DataTable table)
        {
            int sum = 0;
            foreach (DataRow row in table.Rows)
            {
                if (row["Status"].ToString() == "Đã nhận hàng")
                {
                    int money = Convert.ToInt32(row["Pay"]);
                    sum += money;
                }
            }
            string myMoney = string.Format("{0:N}", sum).Replace(".00", "") + "VND";
            txtSum.Text = myMoney;
        }
    }
}
