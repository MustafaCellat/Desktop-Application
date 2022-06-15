
namespace RadimRadiatorInterface
{
    partial class OrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMemberState = new System.Windows.Forms.Label();
            this.cmbxMemberState = new System.Windows.Forms.ComboBox();
            this.lblApproved = new System.Windows.Forms.Label();
            this.cmbxApproved = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgrwOrders = new System.Windows.Forms.DataGridView();
            this.pnlMostOrder = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbxProducts = new System.Windows.Forms.ListBox();
            this.lbxQuantity = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwOrders)).BeginInit();
            this.pnlMostOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlMostOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 464);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.lblMemberState);
            this.panel2.Controls.Add(this.cmbxMemberState);
            this.panel2.Controls.Add(this.lblApproved);
            this.panel2.Controls.Add(this.cmbxApproved);
            this.panel2.Controls.Add(this.btnQuery);
            this.panel2.Controls.Add(this.dgrwOrders);
            this.panel2.Location = new System.Drawing.Point(26, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 208);
            this.panel2.TabIndex = 4;
            // 
            // lblMemberState
            // 
            this.lblMemberState.AutoSize = true;
            this.lblMemberState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMemberState.ForeColor = System.Drawing.Color.White;
            this.lblMemberState.Location = new System.Drawing.Point(274, 11);
            this.lblMemberState.Name = "lblMemberState";
            this.lblMemberState.Size = new System.Drawing.Size(88, 15);
            this.lblMemberState.TabIndex = 10;
            this.lblMemberState.Text = "Üyelik Durumu";
            // 
            // cmbxMemberState
            // 
            this.cmbxMemberState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMemberState.FormattingEnabled = true;
            this.cmbxMemberState.Location = new System.Drawing.Point(368, 8);
            this.cmbxMemberState.Name = "cmbxMemberState";
            this.cmbxMemberState.Size = new System.Drawing.Size(121, 21);
            this.cmbxMemberState.TabIndex = 9;
            // 
            // lblApproved
            // 
            this.lblApproved.AutoSize = true;
            this.lblApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblApproved.ForeColor = System.Drawing.Color.White;
            this.lblApproved.Location = new System.Drawing.Point(21, 11);
            this.lblApproved.Name = "lblApproved";
            this.lblApproved.Size = new System.Drawing.Size(93, 15);
            this.lblApproved.TabIndex = 8;
            this.lblApproved.Text = "Sipariş Durumu";
            // 
            // cmbxApproved
            // 
            this.cmbxApproved.BackColor = System.Drawing.SystemColors.Window;
            this.cmbxApproved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxApproved.ForeColor = System.Drawing.Color.Black;
            this.cmbxApproved.FormattingEnabled = true;
            this.cmbxApproved.Location = new System.Drawing.Point(120, 8);
            this.cmbxApproved.Name = "cmbxApproved";
            this.cmbxApproved.Size = new System.Drawing.Size(121, 21);
            this.cmbxApproved.TabIndex = 7;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(3)))), ((int)(((byte)(231)))));
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(528, 8);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "Ara";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgrwOrders
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgrwOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrwOrders.BackgroundColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(24, 4, 2, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrwOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrwOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgrwOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.dgrwOrders.Location = new System.Drawing.Point(24, 35);
            this.dgrwOrders.Name = "dgrwOrders";
            this.dgrwOrders.ReadOnly = true;
            this.dgrwOrders.RowTemplate.Height = 34;
            this.dgrwOrders.Size = new System.Drawing.Size(922, 170);
            this.dgrwOrders.TabIndex = 0;
            // 
            // pnlMostOrder
            // 
            this.pnlMostOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.pnlMostOrder.Controls.Add(this.panel4);
            this.pnlMostOrder.Controls.Add(this.chart1);
            this.pnlMostOrder.Location = new System.Drawing.Point(26, 12);
            this.pnlMostOrder.Name = "pnlMostOrder";
            this.pnlMostOrder.Size = new System.Drawing.Size(971, 226);
            this.pnlMostOrder.TabIndex = 2;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(3)))), ((int)(((byte)(231)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Empty;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(3)))), ((int)(((byte)(231)))));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(3)))), ((int)(((byte)(231)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(3)))), ((int)(((byte)(231)))));
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(3)))), ((int)(((byte)(231)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(24, 17);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(3)))), ((int)(((byte)(231)))));
            series1.CustomProperties = "PointWidth=0.5";
            series1.Legend = "Legend1";
            series1.Name = "En Fazla Kazanç Sağlayan Ürünler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(693, 203);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.lbxProducts);
            this.panel4.Controls.Add(this.lbxQuantity);
            this.panel4.Location = new System.Drawing.Point(519, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(427, 171);
            this.panel4.TabIndex = 6;
            // 
            // lbxProducts
            // 
            this.lbxProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.lbxProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(181)))));
            this.lbxProducts.FormattingEnabled = true;
            this.lbxProducts.ItemHeight = 15;
            this.lbxProducts.Location = new System.Drawing.Point(26, 12);
            this.lbxProducts.Name = "lbxProducts";
            this.lbxProducts.Size = new System.Drawing.Size(279, 150);
            this.lbxProducts.TabIndex = 1;
            // 
            // lbxQuantity
            // 
            this.lbxQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.lbxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(181)))));
            this.lbxQuantity.FormattingEnabled = true;
            this.lbxQuantity.ItemHeight = 15;
            this.lbxQuantity.Location = new System.Drawing.Point(311, 12);
            this.lbxQuantity.Name = "lbxQuantity";
            this.lbxQuantity.Size = new System.Drawing.Size(112, 150);
            this.lbxQuantity.TabIndex = 0;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1020, 464);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwOrders)).EndInit();
            this.pnlMostOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgrwOrders;
        private System.Windows.Forms.Panel pnlMostOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cmbxApproved;
        private System.Windows.Forms.Label lblApproved;
        private System.Windows.Forms.Label lblMemberState;
        private System.Windows.Forms.ComboBox cmbxMemberState;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox lbxProducts;
        private System.Windows.Forms.ListBox lbxQuantity;
    }
}