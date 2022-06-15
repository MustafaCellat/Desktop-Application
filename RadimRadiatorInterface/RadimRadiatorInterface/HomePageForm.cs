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
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }
        private void HomePageForm_Load(object sender, EventArgs e)
        {
            double uyeSayisi;
            double uyeOlmayanSayisi;
            double ortalama;
            List<OrderItem.OrderItemInformation> orderItemInformation = new List<OrderItem.OrderItemInformation>();
            List<Orders.OrdersInformation> ordersInformation = new List<Orders.OrdersInformation>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Management.base_url);
                var response = client.GetAsync("/api/order_items?access_token=" + Management.IdeasoftToken).Result;
                var resultData = response.Content.ReadAsStringAsync().Result;
                orderItemInformation = JsonConvert.DeserializeObject<List<OrderItem.OrderItemInformation>>(resultData);
                var enFazlSatilan = orderItemInformation.OrderByDescending(x => x.productPrice).Take(5);
                foreach (var item in enFazlSatilan)
                {
                    chart2.Series["En Fazla Kazanç Sağlayan Ürünler"].Points.AddXY(item.productName, item.productPrice);
                }
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Management.base_url);
                var response = client.GetAsync("/api/orders?access_token=" + Management.IdeasoftToken).Result;
                var resultData = response.Content.ReadAsStringAsync().Result;
                ordersInformation = JsonConvert.DeserializeObject<List<Orders.OrdersInformation>>(resultData);
                uyeSayisi = ordersInformation.Count(x => x.memberGroupName == "Üyeler");
                uyeOlmayanSayisi = ordersInformation.Count(x => x.memberGroupName == "Üyeliksiz alışveriş");
                ortalama = 100 * (uyeSayisi / (uyeSayisi + uyeOlmayanSayisi));
            }
            // Circular Bar
            crclrMemberRates.Minimum = 0;
            crclrMemberRates.Maximum = 100;
            crclrMemberRates.Text = (Convert.ToInt32(ortalama)).ToString() + "%";
            crclrMemberRates.Value = Convert.ToInt32(ortalama);
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Management.base_url);
                var response = client.GetAsync("/api/order_items?access_token=" + Management.IdeasoftToken).Result;
                var resultData = response.Content.ReadAsStringAsync().Result;
                orderItemInformation = JsonConvert.DeserializeObject<List<OrderItem.OrderItemInformation>>(resultData);
                var urunAdeti = orderItemInformation.OrderByDescending(x => x.productQuantity).Take(5);
                chart1.Series["Ürün Satış Adeti"].Color = Color.FromArgb(28, 199, 219);
                foreach (var urunadeti in urunAdeti.Reverse())
                {
                    chart1.Series["Ürün Satış Adeti"].Points.AddXY(urunadeti.productName, urunadeti.productQuantity);
                }
            }
        }
    }
}
