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
    public partial class OrdersForm : Form
    {
        List<string> onayDurumu = new List<string>() { "Hepsi", "Onaylananlar", "Onaylanmayanlar" };
        List<string> uyelikDurumu = new List<string>() { "Hepsi", "Üyeler", "Üye Olmayanlar" };
        public OrdersForm()
        {
            InitializeComponent();
            DatagridviewSettings(dgrwOrders);
        }
        public void DatagridviewSettings(DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(32, 38, 60);
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(32, 38, 60);
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(62, 68, 90);
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(235, 68, 136);
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(62, 68, 90);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(235, 68, 136);
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
        List<OrderItem.OrderItemInformation> orderItemInformation = new List<OrderItem.OrderItemInformation>();
        List<Orders.OrdersInformation> ordersInformation = new List<Orders.OrdersInformation>();
        List<Products.ProductsInformation> productsInformation = new List<Products.ProductsInformation>();
        private void OrdersForm_Load(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Management.base_url);
                var response = client.GetAsync("/api/order_items?access_token=" + Management.IdeasoftToken).Result;
                var resultData = response.Content.ReadAsStringAsync().Result;
                orderItemInformation = JsonConvert.DeserializeObject<List<OrderItem.OrderItemInformation>>(resultData);
                var enFazlSatilan = orderItemInformation.OrderByDescending(x => x.productPrice).Take(5);
                foreach (var item in enFazlSatilan)
                {
                    chart1.Series["En Fazla Kazanç Sağlayan Ürünler"].Points.AddXY(item.productName, item.productPrice);
                }
                foreach (var item in enFazlSatilan)
                {
                    lbxProducts.Items.Add(item.productName + "    :");
                    lbxProducts.Items.Add(" ");
                    lbxQuantity.Items.Add(item.productPrice);
                    lbxQuantity.Items.Add(" ");
                }
            }
            cmbxApproved.DataSource = onayDurumu;
            cmbxMemberState.DataSource = uyelikDurumu;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Management.base_url);
                var response = client.GetAsync("/api/orders?access_token=" + Management.IdeasoftToken).Result;
                var resultData = response.Content.ReadAsStringAsync().Result;
                ordersInformation = JsonConvert.DeserializeObject<List<Orders.OrdersInformation>>(resultData);
                var kazanc = ordersInformation.OrderByDescending(x => x.generalAmount).Take(5);
                //foreach (var item in kazanc)
                //{
                //    var m = productsInformations.Where(x => x.sku == item.)
                //}
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Management.base_url);
                var response = client.GetAsync("/api/products?access_token=" + Management.IdeasoftToken).Result;
                var resultData = response.Content.ReadAsStringAsync().Result;
                productsInformation = JsonConvert.DeserializeObject<List<Products.ProductsInformation>>(resultData);
            }
            dgrwOrders.DataSource = ordersInformation;
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            cmbxApproved.DataSource = onayDurumu;
            cmbxMemberState.DataSource = uyelikDurumu;
            if (cmbxApproved.SelectedItem == "Onaylananlar" && cmbxMemberState.SelectedItem == "Üyeler")
            {
                var onayliUye = ordersInformation.Where(x => x.status == "approved" && x.memberGroupName == "Üyeler").ToList();
                dgrwOrders.DataSource = null;
                dgrwOrders.DataSource = onayliUye;
            }else if (cmbxApproved.SelectedItem == "Onaylananlar" && cmbxMemberState.SelectedItem == "Üye Olmayanlar")
            {
                var onayliUyeDegil = ordersInformation.Where(x => x.status == "approved" && x.memberGroupName == "Üyeliksiz alışveriş").ToList();
                dgrwOrders.DataSource = null;
                dgrwOrders.DataSource = onayliUyeDegil;
            }else if (cmbxApproved.SelectedItem == "Onaylanmayanlar" && cmbxMemberState.SelectedItem == "Üyeler")
            {
                var onaysizUye = ordersInformation.Where(x => x.status == "cancelled" && x.memberGroupName == "Üyeler").ToList();
                dgrwOrders.DataSource = null;
                dgrwOrders.DataSource = onaysizUye;
            }else if (cmbxApproved.SelectedItem == "Onaylanmayanlar" && cmbxMemberState.SelectedItem == "Üye Olmayanlar")
            {
                var onaysizUyeDegil = ordersInformation.Where(x => x.status == "cancelled" && x.memberGroupName == "Üyeliksiz alışveriş").ToList();
                dgrwOrders.DataSource = null;
                dgrwOrders.DataSource = onaysizUyeDegil;
            }else if (cmbxApproved.SelectedItem == "Hepsi" && cmbxMemberState.SelectedItem == "Üyeler")
            {
                var hepsiUye = ordersInformation.Where(x => x.memberGroupName == "Üyeler").ToList();
                dgrwOrders.DataSource = null;
                dgrwOrders.DataSource = hepsiUye;
            }else if (cmbxApproved.SelectedItem == "Hepsi" && cmbxMemberState.SelectedItem == "Üye Olmayanlar")
            {
                var hepsiUyeDegil = ordersInformation.Where(x => x.memberGroupName == "Üyeliksiz alışveriş").ToList();
                dgrwOrders.DataSource = null;
                dgrwOrders.DataSource = hepsiUyeDegil;
            }else if (cmbxApproved.SelectedItem == "Onaylananlar" && cmbxMemberState.SelectedItem == "Hepsi")
            {
                var hepsiUye = ordersInformation.Where(x => x.status == "approved").ToList();
                dgrwOrders.DataSource = null;
                dgrwOrders.DataSource = hepsiUye;
            }else if (cmbxApproved.SelectedItem == "Onaylanmayanlar" && cmbxMemberState.SelectedItem == "Hepsi")
            {
                var onaysizHepsi = ordersInformation.Where(x => x.status == "cancelled").ToList();
                dgrwOrders.DataSource = null;
                dgrwOrders.DataSource = onaysizHepsi;
            }
            else
            {
                dgrwOrders.DataSource = null;
                dgrwOrders.DataSource = ordersInformation;
            }
        }
    }
}
