using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prmPract1._2.types;

namespace prmPract1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Shop pyaterochka = new Shop();

        private void Form1_Load(object sender, EventArgs e)
        {
            pyaterochka.CreateProduct("Кола", 85, 200);
            pyaterochka.CreateProduct("Сок \"Добрый\"", 100, 50);
            pyaterochka.Sell("Кола");
            string content = $"{pyaterochka.WriteAllProducts()}{pyaterochka.getTotalProfit()}";
            products_label.Text = content;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string title = product_title_box.Text;
            decimal price = decimal.Parse(product_price_box.Text);
            int count = int.Parse(product_count_box.Text);

            if (string.IsNullOrWhiteSpace(title) || price <= 0 || count < 0)
            {
                MessageBox.Show("Введите коректные данные");
            }
            else
            {
                pyaterochka.CreateProduct(title, price, count);
                string content = $"{pyaterochka.WriteAllProducts()}{pyaterochka.getTotalProfit()}";
                products_label.Text = content;
            }
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            string title = product_buy_box.Text;

            if (string.IsNullOrWhiteSpace(title)) MessageBox.Show("Введите коректные данные!");
            else
            {
                string response = pyaterochka.Sell(title);
                response_label.Text = response;
                string content = $"{pyaterochka.WriteAllProducts()}{pyaterochka.getTotalProfit()}";
                products_label.Text = content;
            }
        }
    }
}