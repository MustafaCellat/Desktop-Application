using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RadimRadiatorInterface
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            DatagridviewSettings(dgrwProducts);
        }
        public void DatagridviewSettings(DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(32, 38, 60);
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(32, 38, 60);
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(62, 68, 90);
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 152, 0);
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(62, 68, 90);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 152, 0);
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 21, 38);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(28, 199, 219);
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(62, 68, 90);
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.BackgroundColor = Color.FromArgb(32, 38, 60);
            dataGridView.ForeColor = Color.White;
        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            List<ProductToCategories.ProductToCategoriesInformation> productToCategoriesInformation = new List<ProductToCategories.ProductToCategoriesInformation>();
            List<Products.ProductsInformation> productsInformation = new List<Products.ProductsInformation>();
            List<OrderItem.OrderItemInformation> orderItemInformation = new List<OrderItem.OrderItemInformation>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Management.base_url);
                var response = client.GetAsync("/api/product_to_categories?access_token=" + Management.IdeasoftToken).Result;
                var resultData = response.Content.ReadAsStringAsync().Result;
                productToCategoriesInformation = JsonConvert.DeserializeObject<List<ProductToCategories.ProductToCategoriesInformation>>(resultData);
            }
            //dgrwCategory.DataSource = productToCategoriesInformation;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Management.base_url);
                var response = client.GetAsync("/api/products?access_token=" + Management.IdeasoftToken).Result;
                var resultData = response.Content.ReadAsStringAsync().Result;
                productsInformation = JsonConvert.DeserializeObject<List<Products.ProductsInformation>>(resultData);
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Management.base_url);
                var response = client.GetAsync("/api/order_items?access_token=" + Management.IdeasoftToken).Result;
                var resultData = response.Content.ReadAsStringAsync().Result;
                orderItemInformation = JsonConvert.DeserializeObject<List<OrderItem.OrderItemInformation>>(resultData);
                var urunAdeti = orderItemInformation.OrderByDescending(x => x.productQuantity).Take(5);
                // CHART
                chart1.Series["Ürün Satış Adeti"].Color = Color.FromArgb(255, 152, 0);
                foreach (var urunadeti in urunAdeti.Reverse())
                {
                    chart1.Series["Ürün Satış Adeti"].Points.AddXY(urunadeti.productName, urunadeti.productQuantity);
                }
                foreach (var urunadeti in urunAdeti)
                {
                    lbxProducts.Items.Add(urunadeti.productName + "    :");
                    lbxProducts.Items.Add(" ");
                    lbxQuantity.Items.Add(urunadeti.productQuantity);
                    lbxQuantity.Items.Add(" ");
                }
            }
            // PİE
            chart2.Series["Ürün Kategorisi"].IsValueShownAsLabel = true;
            foreach (var urunKategorisi in productToCategoriesInformation)
            {
                var urunAdi = productsInformation.Where(x => x.id == urunKategorisi.id).ToList();
                foreach (var urunadi in urunAdi)
                {
                    chart2.Series["Ürün Kategorisi"].Points.AddXY(urunadi.name, 3);
                    break;
                }
            }

            dgrwProducts.DataSource = productsInformation;
            //dgrwOrderItems.DataSource = orderItemInformation;
        }
    }
}
