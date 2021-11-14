using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OnlineShop
{
    public partial class Home : Form
    {
        //Interface -head code
        private Form activeForm;
        public Home()
        {
            InitializeComponent();
            DataFrame.Product = DataFrame.New_DataShoes();
            DataFrame.Order = DataFrame.New_DataOrder();
            DataFrame.History = DataFrame.New_DataHistory();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            original = this.Size;

            string url = Application.StartupPath + "\\Product\\datashoes.xlsx";
            DataTable DataShoes = DataFrame.Read_File(url);
            Load_Data(DataShoes);

            DataFrame.Shoes = DataShoes;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Size original;

        private void pctIcon_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void gunaBtnProduct_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void gunaBtnCart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cart(), sender);
        }

        private void gunaBtnHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new History(), sender);
        }


        private void pnlTile_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
                if (this.Location.Y <= 0)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.Size = original;
                }

                // Drag to side to split screen
                if (this.Location.X <= 0)
                {
                    this.Location = new Point(0, 0);
                    this.Size = new Size(SystemInformation.WorkingArea.Width / 2, SystemInformation.WorkingArea.Height);
                }
                else if (this.Location.X >= SystemInformation.WorkingArea.Width / 2)
                {
                    this.Location = new Point(SystemInformation.WorkingArea.Width / 2, 0);
                    this.Size = new Size(SystemInformation.WorkingArea.Width / 2, SystemInformation.WorkingArea.Height);
                }
                else
                {
                    this.Size = original;
                }
            }
        }

        private void pnlTile_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }



        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.gunaPnlForm.Controls.Add(childForm);
            this.gunaPnlForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        //Interface -tail code

        //Load dữ liệu
        private void Load_Data(DataTable Data)
        {
            int width = 5;
            int height = 5;
            Shoes oldShoes = new Shoes() { Width = 0, Location = new Point(0, 0) };
            int index = 0;
            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < width + 1; j++)
                {
                    try
                    {
                        DataRow row = Data.Rows[index];
                        string name = row["Name"].ToString();
                        string brand = row["Brand"].ToString();
                        int price = Convert.ToInt32(row["Price"]);
                        Shoes shoes = new Shoes()
                        {
                            Width = 220,
                            Height = 200,
                            Location = new Point(oldShoes.Location.X + oldShoes.Width + 20, oldShoes.Location.Y)

                        };

                        pnlProduct.Controls.Add(shoes);
                        index += 1;
                        try
                        {
                            string path_shoes = Application.StartupPath.Replace("\\", "/") + "/Product/Image/" + name + ".jfif";
                            string path_brand = Application.StartupPath.Replace("\\", "/") + "/Product/Brand/" + brand + ".jpg";
                            shoes.change_value(name, brand, price, Image.FromFile(path_shoes), Image.FromFile(path_brand));
                        }
                        catch
                        {
                            string path_shoes = Application.StartupPath.Replace("\\", "/") + "/Product/Image/" + name + ".jpg";
                            string path_brand = Application.StartupPath.Replace("\\", "/") + "/Product/Brand/" + brand + ".jpg";
                            shoes.change_value(name, brand, price, Image.FromFile(path_shoes), Image.FromFile(path_brand));
                        }
                        oldShoes = shoes;
                    }
                    catch { return; }
                }
                oldShoes.Location = new Point(0, oldShoes.Location.Y + 210);
                oldShoes.Width = 0;
                oldShoes.Height = 0;
                index -= 1;
            }
        }
        
        //Tìm kiếm theo tên
        private DataTable SearchTable(string s)
        {
            DataTable res = DataFrame.New_DataShoes();

            foreach(DataRow row in DataFrame.Shoes.Rows)
            {
                string name = row["Name"].ToString();
                if (name.Contains(s))
                    res.ImportRow(row);
            }

            return res;
        }

        private void gunTxtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable search = SearchTable(gunTxtSearch.Text);
            pnlProduct.Controls.Clear();
            Load_Data(search);
        }

        private void gunaPctAll_Click(object sender, EventArgs e)
        {
            pnlProduct.Controls.Clear();
            Load_Data(DataFrame.Shoes);
        }

        //Lọc nhãn hiệu
        private DataTable Brand_Filter()
        {
            DataTable res = DataFrame.New_DataShoes();

            List<string> lst_brand = new List<string> { };

            if (checkBoxNike.Checked)
                lst_brand.Add("nike");
            if (checkBoxConverse.Checked)
                lst_brand.Add("converse");
            if (checkBoxPuma.Checked)
                lst_brand.Add("puma");
            if (checkBoxAnanas.Checked)
                lst_brand.Add("ananas");

            bool all = !checkBoxNike.Checked && !checkBoxConverse.Checked && !checkBoxPuma.Checked && !checkBoxAnanas.Checked;
            if (all)
            {
                lst_brand = new List<string>{ "nike", "converse", "puma", "ananas" };
            }

            foreach (DataRow row in DataFrame.Shoes.Rows)
            {
                string brand = row["Brand"].ToString();
                if (lst_brand.Contains(brand))
                    res.ImportRow(row);
            }

            return res;
        }
        private void check_value(object sender, EventArgs e)
        {
            pnlProduct.Controls.Clear();
            Load_Data(Brand_Filter());
        }
    }
}