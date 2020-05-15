namespace BubbleSortSimulation
{
    partial class BubbleSortForm
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.speedInfo = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.complexityText = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackSecondaryColor = System.Drawing.Color.Blue;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            this.chart1.BorderlineWidth = 4;
            this.chart1.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chart1.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            this.chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend2.BackColor = System.Drawing.Color.White;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 125);
            this.chart1.Margin = new System.Windows.Forms.Padding(20);
            this.chart1.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.chart1.Name = "chart1";
            this.chart1.Padding = new System.Windows.Forms.Padding(20);
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(754, 340);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // sort
            // 
            this.sort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sort.Location = new System.Drawing.Point(689, 515);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(75, 23);
            this.sort.TabIndex = 1;
            this.sort.Text = "Sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. Input integers separated by comma";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 52);
            this.textBox1.MaximumSize = new System.Drawing.Size(400, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 60);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox
            // 
            this.checkBox.Location = new System.Drawing.Point(369, 53);
            this.checkBox.MaximumSize = new System.Drawing.Size(300, 300);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(146, 40);
            this.checkBox.TabIndex = 7;
            this.checkBox.Text = "2. Random numbers (min 0 max 100, 20 numbers)";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // trackBar
            // 
            this.trackBar.AutoSize = false;
            this.trackBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar.Location = new System.Drawing.Point(565, 57);
            this.trackBar.Maximum = 40;
            this.trackBar.Name = "trackBar";
            this.trackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar.RightToLeftLayout = true;
            this.trackBar.Size = new System.Drawing.Size(201, 45);
            this.trackBar.TabIndex = 10;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(330, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "or";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // speedInfo
            // 
            this.speedInfo.Location = new System.Drawing.Point(572, 94);
            this.speedInfo.Name = "speedInfo";
            this.speedInfo.Size = new System.Drawing.Size(194, 30);
            this.speedInfo.TabIndex = 13;
            this.speedInfo.Text = "Speed info";
            this.speedInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.speedInfo.Click += new System.EventHandler(this.speedInfo_Click);
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reset.Location = new System.Drawing.Point(608, 515);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 14;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Orange;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(139, 485);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4);
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Bigger";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(190, 485);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(4);
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Smaller";
            // 
            // complexityText
            // 
            this.complexityText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.complexityText.AutoSize = true;
            this.complexityText.BackColor = System.Drawing.Color.Snow;
            this.complexityText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.complexityText.Location = new System.Drawing.Point(245, 485);
            this.complexityText.Name = "complexityText";
            this.complexityText.Padding = new System.Windows.Forms.Padding(4);
            this.complexityText.Size = new System.Drawing.Size(80, 21);
            this.complexityText.TabIndex = 17;
            this.complexityText.Text = "Complexity : 0";
            // 
            // info
            // 
            this.info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(268, 522);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 13);
            this.info.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkBlue;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(87, 485);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(4);
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sorted";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Blue;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 485);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(4);
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Non-Sorted";
            // 
            // view
            // 
            this.view.AutoSize = true;
            this.view.Location = new System.Drawing.Point(121, 13);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(66, 17);
            this.view.TabIndex = 21;
            this.view.Text = "3D View";
            this.view.UseVisualStyleBackColor = true;
            this.view.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BubbleSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 547);
            this.Controls.Add(this.view);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.info);
            this.Controls.Add(this.complexityText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.speedInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.chart1);
            this.Name = "BubbleSortForm";
            this.Text = "Bubble Sort simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label speedInfo;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label complexityText;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox view;
    }
}

