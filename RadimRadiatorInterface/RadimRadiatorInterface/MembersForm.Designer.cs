
namespace RadimRadiatorInterface
{
    partial class MembersForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMembers = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgrwMembers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMemberNotCount = new System.Windows.Forms.Label();
            this.lblMemberCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crclrMemberRates = new CircularProgressBar.CircularProgressBar();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblMemberNot = new System.Windows.Forms.Label();
            this.pnlMembers.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwMembers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMembers
            // 
            this.pnlMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.pnlMembers.Controls.Add(this.panel4);
            this.pnlMembers.Controls.Add(this.panel2);
            this.pnlMembers.Controls.Add(this.panel1);
            this.pnlMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMembers.Location = new System.Drawing.Point(0, 0);
            this.pnlMembers.Name = "pnlMembers";
            this.pnlMembers.Size = new System.Drawing.Size(1020, 464);
            this.pnlMembers.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.chart2);
            this.panel4.Location = new System.Drawing.Point(517, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(479, 221);
            this.panel4.TabIndex = 8;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.chart2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart2.BorderlineColor = System.Drawing.Color.Empty;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(14, 15);
            this.chart2.Name = "chart2";
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series2.BackSecondaryColor = System.Drawing.Color.Red;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "dghnutGender";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(444, 189);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.dgrwMembers);
            this.panel2.Location = new System.Drawing.Point(23, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 199);
            this.panel2.TabIndex = 6;
            // 
            // dgrwMembers
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgrwMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgrwMembers.BackgroundColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(24, 4, 2, 4);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrwMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgrwMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrwMembers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgrwMembers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.dgrwMembers.Location = new System.Drawing.Point(13, 26);
            this.dgrwMembers.Name = "dgrwMembers";
            this.dgrwMembers.ReadOnly = true;
            this.dgrwMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrwMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgrwMembers.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgrwMembers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgrwMembers.RowTemplate.Height = 34;
            this.dgrwMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.dgrwMembers.Size = new System.Drawing.Size(945, 150);
            this.dgrwMembers.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.lblMemberNotCount);
            this.panel1.Controls.Add(this.lblMemberCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.crclrMemberRates);
            this.panel1.Controls.Add(this.lblMember);
            this.panel1.Controls.Add(this.lblMemberNot);
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 221);
            this.panel1.TabIndex = 5;
            // 
            // lblMemberNotCount
            // 
            this.lblMemberNotCount.AutoSize = true;
            this.lblMemberNotCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMemberNotCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(130)))), ((int)(((byte)(10)))));
            this.lblMemberNotCount.Location = new System.Drawing.Point(389, 167);
            this.lblMemberNotCount.Name = "lblMemberNotCount";
            this.lblMemberNotCount.Size = new System.Drawing.Size(41, 15);
            this.lblMemberNotCount.TabIndex = 5;
            this.lblMemberNotCount.Text = "label3";
            // 
            // lblMemberCount
            // 
            this.lblMemberCount.AutoSize = true;
            this.lblMemberCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMemberCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(205)))), ((int)(((byte)(30)))));
            this.lblMemberCount.Location = new System.Drawing.Point(389, 122);
            this.lblMemberCount.Name = "lblMemberCount";
            this.lblMemberCount.Size = new System.Drawing.Size(41, 15);
            this.lblMemberCount.TabIndex = 4;
            this.lblMemberCount.Text = "label2";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(229, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 64);
            this.label1.TabIndex = 3;
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
            this.crclrMemberRates.Location = new System.Drawing.Point(14, 15);
            this.crclrMemberRates.MarqueeAnimationSpeed = 2000;
            this.crclrMemberRates.Name = "crclrMemberRates";
            this.crclrMemberRates.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(10)))));
            this.crclrMemberRates.OuterMargin = -25;
            this.crclrMemberRates.OuterWidth = 26;
            this.crclrMemberRates.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(205)))), ((int)(((byte)(30)))));
            this.crclrMemberRates.ProgressWidth = 7;
            this.crclrMemberRates.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.crclrMemberRates.Size = new System.Drawing.Size(200, 200);
            this.crclrMemberRates.StartAngle = 270;
            this.crclrMemberRates.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.crclrMemberRates.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.crclrMemberRates.SubscriptText = "";
            this.crclrMemberRates.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.crclrMemberRates.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.crclrMemberRates.SuperscriptText = "";
            this.crclrMemberRates.TabIndex = 0;
            this.crclrMemberRates.TextMargin = new System.Windows.Forms.Padding(4, 8, 0, 0);
            this.crclrMemberRates.Value = 26;
            // 
            // lblMember
            // 
            this.lblMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.lblMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(205)))), ((int)(((byte)(30)))));
            this.lblMember.Location = new System.Drawing.Point(263, 122);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(110, 15);
            this.lblMember.TabIndex = 1;
            this.lblMember.Text = "Üye Olanlar            :";
            this.lblMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMemberNot
            // 
            this.lblMemberNot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.lblMemberNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMemberNot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(130)))), ((int)(((byte)(10)))));
            this.lblMemberNot.Location = new System.Drawing.Point(263, 165);
            this.lblMemberNot.Name = "lblMemberNot";
            this.lblMemberNot.Size = new System.Drawing.Size(110, 18);
            this.lblMemberNot.TabIndex = 2;
            this.lblMemberNot.Text = "Üye Olmayanlar    :";
            this.lblMemberNot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 464);
            this.Controls.Add(this.pnlMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MembersForm";
            this.Text = "MembersForm";
            this.Load += new System.EventHandler(this.MembersForm_Load);
            this.Resize += new System.EventHandler(this.MembersForm_Resize);
            this.pnlMembers.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwMembers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMembers;
        private System.Windows.Forms.DataGridView dgrwMembers;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label lblMemberNot;
        private CircularProgressBar.CircularProgressBar crclrMemberRates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMemberNotCount;
        private System.Windows.Forms.Label lblMemberCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        public System.Windows.Forms.Panel panel1;
    }
}