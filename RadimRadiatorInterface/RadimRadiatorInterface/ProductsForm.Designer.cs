
namespace RadimRadiatorInterface
{
    partial class ProductsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbxProducts = new System.Windows.Forms.ListBox();
            this.lbxQuantity = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgrwProducts = new System.Windows.Forms.DataGridView();
            this.pnlProducts.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProducts
            // 
            this.pnlProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.pnlProducts.Controls.Add(this.panel3);
            this.pnlProducts.Controls.Add(this.panel2);
            this.pnlProducts.Controls.Add(this.panel1);
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProducts.Location = new System.Drawing.Point(0, 0);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(1020, 464);
            this.pnlProducts.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.chart2);
            this.panel3.Location = new System.Drawing.Point(12, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 199);
            this.panel3.TabIndex = 4;
            // 
            // chart2
            // 
            this.chart2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.Title = "Ürün Kategorileri";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend1.TitleForeColor = System.Drawing.Color.White;
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(15, 16);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Ürün Kategorisi";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(293, 164);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(12, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 212);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.lbxProducts);
            this.panel4.Controls.Add(this.lbxQuantity);
            this.panel4.Location = new System.Drawing.Point(660, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 165);
            this.panel4.TabIndex = 5;
            // 
            // lbxProducts
            // 
            this.lbxProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.lbxProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lbxProducts.FormattingEnabled = true;
            this.lbxProducts.ItemHeight = 15;
            this.lbxProducts.Location = new System.Drawing.Point(12, 12);
            this.lbxProducts.Name = "lbxProducts";
            this.lbxProducts.Size = new System.Drawing.Size(223, 150);
            this.lbxProducts.TabIndex = 1;
            // 
            // lbxQuantity
            // 
            this.lbxQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.lbxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lbxQuantity.FormattingEnabled = true;
            this.lbxQuantity.ItemHeight = 15;
            this.lbxQuantity.Location = new System.Drawing.Point(251, 12);
            this.lbxQuantity.Name = "lbxQuantity";
            this.lbxQuantity.Size = new System.Drawing.Size(82, 150);
            this.lbxQuantity.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Empty;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.DarkRed;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.Interval = 0D;
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            legend2.BorderWidth = 0;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(18, 16);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Ürün Satış Adeti";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(794, 193);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.dgrwProducts);
            this.panel1.Location = new System.Drawing.Point(355, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 199);
            this.panel1.TabIndex = 1;
            // 
            // dgrwProducts
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.dgrwProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(24, 4, 2, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrwProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrwProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgrwProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.dgrwProducts.Location = new System.Drawing.Point(17, 27);
            this.dgrwProducts.Name = "dgrwProducts";
            this.dgrwProducts.RowTemplate.Height = 34;
            this.dgrwProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.dgrwProducts.Size = new System.Drawing.Size(617, 141);
            this.dgrwProducts.TabIndex = 0;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 464);
            this.Controls.Add(this.pnlProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.pnlProducts.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.DataGridView dgrwProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox lbxProducts;
        private System.Windows.Forms.ListBox lbxQuantity;
    }
}