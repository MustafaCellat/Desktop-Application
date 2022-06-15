
namespace RadimRadiatorInterface
{
    partial class HomePageForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlHomePage = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.crclrMemberRates = new CircularProgressBar.CircularProgressBar();
            this.pnlHomePage.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHomePage
            // 
            this.pnlHomePage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.pnlHomePage.Controls.Add(this.panel3);
            this.pnlHomePage.Controls.Add(this.panel2);
            this.pnlHomePage.Controls.Add(this.panel1);
            this.pnlHomePage.Location = new System.Drawing.Point(0, 0);
            this.pnlHomePage.Name = "pnlHomePage";
            this.pnlHomePage.Size = new System.Drawing.Size(1020, 464);
            this.pnlHomePage.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.chart2);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 209);
            this.panel3.TabIndex = 2;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            chartArea6.AxisX.IsLabelAutoFit = false;
            chartArea6.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea6.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.Empty;
            chartArea6.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            chartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea6.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            chartArea6.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            chartArea6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            chartArea6.Name = "ChartArea1";
            chartArea6.Position.Auto = false;
            chartArea6.Position.Height = 93F;
            chartArea6.Position.Width = 72.7998F;
            chartArea6.Position.X = 3F;
            chartArea6.Position.Y = 3F;
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            legend6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend6.ForeColor = System.Drawing.Color.White;
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(3, 16);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            series6.CustomProperties = "PointWidth=0.4";
            series6.Legend = "Legend1";
            series6.Name = "En Fazla Kazanç Sağlayan Ürünler";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(990, 190);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(12, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 225);
            this.panel2.TabIndex = 1;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea5.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Empty;
            chartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            chartArea5.AxisX.MinorGrid.LineColor = System.Drawing.Color.DarkRed;
            chartArea5.AxisY.IsLabelAutoFit = false;
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea5.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            chartArea5.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            chartArea5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            legend5.BorderWidth = 0;
            legend5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend5.ForeColor = System.Drawing.Color.White;
            legend5.IsTextAutoFit = false;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(3, 9);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            series5.Legend = "Legend1";
            series5.Name = "Ürün Satış Adeti";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(577, 195);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.crclrMemberRates);
            this.panel1.Location = new System.Drawing.Point(611, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 225);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Siparişte Bulunanların Üyelik Durumu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crclrMemberRates
            // 
            this.crclrMemberRates.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.crclrMemberRates.AnimationSpeed = 500;
            this.crclrMemberRates.BackColor = System.Drawing.Color.Transparent;
            this.crclrMemberRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.crclrMemberRates.ForeColor = System.Drawing.Color.White;
            this.crclrMemberRates.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.crclrMemberRates.InnerMargin = 2;
            this.crclrMemberRates.InnerWidth = -1;
            this.crclrMemberRates.Location = new System.Drawing.Point(118, 45);
            this.crclrMemberRates.MarqueeAnimationSpeed = 2000;
            this.crclrMemberRates.Name = "crclrMemberRates";
            this.crclrMemberRates.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.crclrMemberRates.OuterMargin = -25;
            this.crclrMemberRates.OuterWidth = 26;
            this.crclrMemberRates.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.crclrMemberRates.ProgressWidth = 7;
            this.crclrMemberRates.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.crclrMemberRates.Size = new System.Drawing.Size(155, 159);
            this.crclrMemberRates.StartAngle = 270;
            this.crclrMemberRates.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.crclrMemberRates.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.crclrMemberRates.SubscriptText = "";
            this.crclrMemberRates.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.crclrMemberRates.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.crclrMemberRates.SuperscriptText = "";
            this.crclrMemberRates.TabIndex = 2;
            this.crclrMemberRates.TextMargin = new System.Windows.Forms.Padding(4, 8, 0, 0);
            this.crclrMemberRates.Value = 26;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 464);
            this.Controls.Add(this.pnlHomePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePageForm";
            this.Text = "HomePageForm";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            this.pnlHomePage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHomePage;
        private System.Windows.Forms.Panel panel1;
        private CircularProgressBar.CircularProgressBar crclrMemberRates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}