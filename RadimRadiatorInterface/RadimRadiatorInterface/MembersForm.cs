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
    public partial class MembersForm : Form
    {
        public MembersForm()
        {
            InitializeComponent();
            DatagridviewSettings(dgrwMembers);
            //Management management = new Management();
            //if (panel1.Size.Height > 464 && panel1.Size.Width > 1020)
            //{
            //    panel1.Size = new Size(800, 500);
            //}
        }
        public void DatagridviewSettings(DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(32, 38, 60);
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(32, 38, 60);
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(62, 68, 90);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(154, 205, 70);
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
        
        private void MembersForm_Load(object sender, EventArgs e)
        {
            //Üyelik Durumu
            double ortalama;
            double uyeSayisi;
            double uyeOlmayanSayisi;
            //Cinsiyet
            int erkek;
            int kadin;
            List<Members.MembersInformation> membersInformation = new List<Members.MembersInformation>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Management.base_url);
                var response = client.GetAsync("/api/members?access_token=" + Management.IdeasoftToken).Result;
                var resultData = response.Content.ReadAsStringAsync().Result;
                membersInformation = JsonConvert.DeserializeObject<List<Members.MembersInformation>>(resultData);
                erkek = membersInformation.Count(x => x.gender == "male");
                kadin = membersInformation.Count(x => x.gender == "female");
            }
            List<Orders.OrdersInformation> ordersInformation = new List<Orders.OrdersInformation>();
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
            lblMember.Text = "Üye olanlar            :";
            lblMemberNot.Text = "Üye Olmayanlar    :";
            lblMemberCount.Text = uyeSayisi.ToString();
            lblMemberNotCount.Text = uyeOlmayanSayisi.ToString();
            // Doughnut
            chart2.Series["dghnutGender"].IsValueShownAsLabel = true;
            chart2.Series["dghnutGender"].Points.AddXY("Erkek", erkek);
            chart2.Series["dghnutGender"].Points.AddXY("Kadın", kadin);
            chart2.Series["dghnutGender"].Points[0].Color = Color.FromArgb(28, 199, 219);
            chart2.Series["dghnutGender"].Points[1].Color = Color.FromArgb(255, 3, 231);

            dgrwMembers.DataSource = membersInformation;
        }
        private void MembersForm_Resize(object sender, EventArgs e)
        {
            //panel1.Height = this.Height - (panel1.Location.Y + 30);
            //panel1.Width = this.Width - (panel1.Location.X + 10);
            //panel2.Height = panel1.Height;
            //panel2.Width = panel1.Width;
            //panel4.Height = panel1.Height;
            //panel4.Width = panel4.Width;
        }
    }
}
