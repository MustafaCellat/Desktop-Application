
namespace RadimRadiatorInterface
{
    partial class Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iconTitle = new FontAwesome.Sharp.IconPictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHomePage = new FontAwesome.Sharp.IconButton();
            this.btnOrders = new FontAwesome.Sharp.IconButton();
            this.btnProducts = new FontAwesome.Sharp.IconButton();
            this.btnMembers = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconTitle)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconTitle
            // 
            this.iconTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.iconTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconTitle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTitle.IconSize = 36;
            this.iconTitle.Location = new System.Drawing.Point(6, 10);
            this.iconTitle.Name = "iconTitle";
            this.iconTitle.Size = new System.Drawing.Size(32, 32);
            this.iconTitle.TabIndex = 0;
            this.iconTitle.TabStop = false;
            this.iconTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconTitle_MouseDown);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.iconTitle);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1020, 45);
            this.panelTitleBar.TabIndex = 5;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.lblTitle.Location = new System.Drawing.Point(44, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(56, 13);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Ana Sayfa";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(930, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 45);
            this.btnMaximize.TabIndex = 7;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(975, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 45);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(885, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 45);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 125);
            this.panelLogo.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RadimRadiatorInterface.Properties.Resources.Hammam3;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnHomePage
            // 
            this.btnHomePage.FlatAppearance.BorderSize = 0;
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHomePage.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHomePage.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHomePage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHomePage.IconSize = 36;
            this.btnHomePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomePage.Location = new System.Drawing.Point(0, 128);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHomePage.Size = new System.Drawing.Size(200, 70);
            this.btnHomePage.TabIndex = 5;
            this.btnHomePage.Text = "Ana Sayfa";
            this.btnHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnOrders.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrders.IconSize = 36;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(0, 198);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOrders.Size = new System.Drawing.Size(200, 70);
            this.btnOrders.TabIndex = 6;
            this.btnOrders.Text = "Siparişler";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click_1);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnProducts.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProducts.IconSize = 36;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 268);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProducts.Size = new System.Drawing.Size(200, 70);
            this.btnProducts.TabIndex = 7;
            this.btnProducts.Text = "Ürünler";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click_1);
            // 
            // btnMembers
            // 
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMembers.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnMembers.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMembers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMembers.IconSize = 36;
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(0, 338);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMembers.Size = new System.Drawing.Size(200, 70);
            this.btnMembers.TabIndex = 8;
            this.btnMembers.Text = "Üyeler";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click_1);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panelMenu.Controls.Add(this.btnMembers);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.btnOrders);
            this.panelMenu.Controls.Add(this.btnHomePage);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 509);
            this.panelMenu.TabIndex = 4;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.panelMain.Location = new System.Drawing.Point(200, 45);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1020, 464);
            this.panelMain.TabIndex = 6;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 509);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelMain);
            this.Name = "Management";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconTitle)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconTitle;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnHomePage;
        private FontAwesome.Sharp.IconButton btnOrders;
        private FontAwesome.Sharp.IconButton btnProducts;
        private FontAwesome.Sharp.IconButton btnMembers;
        private System.Windows.Forms.Panel panelMenu;
        internal FontAwesome.Sharp.IconButton btnMaximize;
        public System.Windows.Forms.Panel panelMain;
    }
}

