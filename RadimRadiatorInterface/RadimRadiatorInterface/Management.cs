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
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace RadimRadiatorInterface
{
    public partial class Management : Form
    {
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect,
        //    int nTopRect,
        //    int nRightRect,
        //    int nBottomRect,
        //    int nWidthEllipse,
        //    int nHeightEllipse
        //);
        public const string IdeasoftToken = "MDc0MTkyM2IyZmExZmIwZmU0YzhmY2I0ZjQ0Y2FhZGI5ZmIxMzE2MzMyOTZmY2VkYTNlMjY5MzRlOWI1MjE2YQ";
        public const string base_url = "http://hammamonline.myideasoft.com";
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentOpenedForm;
        public Management()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 70);
            panelMenu.Controls.Add(leftBorderBtn);
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(28, 199, 219);
            public static Color color2 = Color.FromArgb(235, 48, 116);
            public static Color color3 = Color.FromArgb(255, 152, 0);
            public static Color color4 = Color.FromArgb(154, 205, 30);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(39, 49, 70);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Left border button ayarları
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Titles
                iconTitle.IconChar = currentBtn.IconChar;
                iconTitle.IconColor = color;
                lblTitle.Text = currentBtn.Text;
                lblTitle.ForeColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(22, 27, 46);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenForm (Form childForm)
        {
            if (currentOpenedForm != null)
            {
                currentOpenedForm.Close();
            }
            currentOpenedForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void Management_Load(object sender, EventArgs e)
        {
            btnHomePage.PerformClick();
            btnHomePage.Font = new Font(btnHomePage.Font.FontFamily, 8);
            btnOrders.Font = new Font(btnOrders.Font.FontFamily, 8);
            btnProducts.Font = new Font(btnProducts.Font.FontFamily, 8);
            btnMembers.Font = new Font(btnMembers.Font.FontFamily, 8);
            lblTitle.Font = new Font(lblTitle.Font.FontFamily, 8);
        }
        // Üst Kısmı Override etme
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenForm(new HomePageForm());
        }

        private void btnOrders_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenForm(new OrdersForm());
        }

        private void btnProducts_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenForm(new ProductsForm());
        }

        private void btnMembers_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenForm(new MembersForm());
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else 
            {
                WindowState = FormWindowState.Normal;
                Size = new Size(1236, 548);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
