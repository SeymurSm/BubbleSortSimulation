using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BubbleSortSimulation
{
    public partial class BubbleSortForm : Form
    {
        private bool sorting = false;

        private int depthC = 0;
        private int opereations = 0;


        public BubbleSortForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();
            this.chart1.Titles.Add("Bubble Sort");
        }

        private void refreshBars(int[] arr)
        {

            this.chart1.Series.Clear();

            for (int k = 0; k < arr.Length; k++)
            {
                increase();
                System.Windows.Forms.DataVisualization.Charting.Series series = this.chart1.Series.Add(k.ToString());
                series.IsValueShownAsLabel = true;
                series["PixelPointWidth"] = "500";
                series.BorderColor = Color.Aqua;
                series.BorderWidth = 2;
                series.Points.Add(arr[k]);

            }
        }

        private void bubleSort(int[] arr)
        {
            refreshBars(arr);

            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2 - j; i++)
                {

                    bool isChanging = false;

                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        chart1.Series[i.ToString()].Points[0].Color = Color.Orange;
                        chart1.Series[i.ToString()].Points[0].BorderDashStyle = ChartDashStyle.Dash;

                        chart1.Series[(i + 1).ToString()].Points[0].Color = Color.Red;
                        chart1.Series[(i + 1).ToString()].Points[0].BorderDashStyle = ChartDashStyle.DashDotDot;
                        isChanging = true;


                    }
                    else if (arr[i] < arr[i + 1])
                    {

                        chart1.Series[(i + 1).ToString()].Points[0].Color = Color.Orange;
                        chart1.Series[(i + 1).ToString()].Points[0].BorderDashStyle = ChartDashStyle.Dash;

                        chart1.Series[(i).ToString()].Points[0].Color = Color.Red;
                        chart1.Series[(i).ToString()].Points[0].BorderDashStyle = ChartDashStyle.DashDotDot;
                    }
                    else
                    {
                        chart1.Series[(i + 1).ToString()].Points[0].Color = Color.Orange;
                        chart1.Series[(i + 1).ToString()].Points[0].BorderDashStyle = ChartDashStyle.Dash;

                        chart1.Series[(i).ToString()].Points[0].Color = Color.Orange;
                        chart1.Series[(i).ToString()].Points[0].BorderDashStyle = ChartDashStyle.DashDotDot;
                    }


                    for (int g = 0; g <= arr.Length - 2; g++)
                    {
                        increase();

                        if (g != i && g != i + 1)
                        {
                            if (g >= arr.Length - j)
                            {
                                chart1.Series[g.ToString()].Points[0].Color = Color.DarkBlue;

                            }
                            else
                            {
                                chart1.Series[g.ToString()].Points[0].Color = Color.Blue;

                            }
                        }
                    }

                    wait((trackBar.Maximum - trackBar.Value) * (trackBar.Maximum - trackBar.Value));

                    this.chart1.Series.Clear();

                    for (int k = 0; k < arr.Length; k++)
                    {
                        increase();

                        System.Windows.Forms.DataVisualization.Charting.Series series = this.chart1.Series.Add(k.ToString());
                        series.IsValueShownAsLabel = true;
                        series["PixelPointWidth"] = "500";
                        series.BorderColor = Color.Black;
                        series.BorderWidth = 2;
                        series.Points.Add(arr[k]);
                        if (k == i || k == i + 1)
                        {
                            if (isChanging && k == i)
                                chart1.Series[k.ToString()].LegendText = arr[k].ToString() + "<-- Smaller";
                            else if (isChanging && k == i + 1)
                                chart1.Series[k.ToString()].LegendText = arr[k].ToString() + "<-- Bigger";
                            else if (!isChanging && k == i)
                                chart1.Series[k.ToString()].LegendText = arr[k].ToString() + "<-- Bigger";
                            else if (!isChanging && k == i + 1)
                                chart1.Series[k.ToString()].LegendText = arr[k].ToString() + "<-- Smaller";
                        }
                        else
                        {
                            chart1.Series[k.ToString()].LegendText = arr[k].ToString();
                        }


                        if (k >= arr.Length - j)
                            series.Points[0].Color = Color.DarkBlue;
                        else
                            series.Points[0].Color = Color.Blue;


                    }

                    wait(400);
                    complexityText.Text = "Complexity: " + opereations + " computation";
                }
            }
            setInfoText("Sorting has finished");

            complexityText.Text = "Complexity: " + opereations + " computation  ~ O(n^3)   (n^2 'bubble sort' *n UI)      n=" + arr.Length.ToString();
        }

        private void increase()
        {
            opereations += 1;
        }

        private void Invoke(string v1, int v2)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sorting = false;

        }

        private void play_Click(object sender, EventArgs e)
        {
            sorting = true;

        }

        private void setErrorText(string text)
        {
            this.info.ForeColor = Color.Red;
            this.info.Text = text;
        }

        private void setWarningText(string text)
        {
            this.info.ForeColor = Color.Orange;
            this.info.Text = text;
        }

        private void setInfoText(string text)
        {
            this.info.ForeColor = Color.AliceBlue;
            this.info.Text = text; ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opereations = 0;
            setErrorText("");
            sorting = true;
            chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            chart1.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
            if (checkBox.Checked)
                bubleSort(generateRandomArray());

            else
            {

                if (this.textBox1.Text == "")
                {
                    setErrorText("Activate 1st or 2nd ");
                }
                else
                {
                    string[] inputArr = this.textBox1.Text.Split(',');
                    int[] unsortedRecords = new int[inputArr.Length];
                    for (int i = 0; i < unsortedRecords.Length; i++)
                    {
                        try
                        {
                            int.TryParse(inputArr[i], out unsortedRecords[i]);
                        }
                        catch (Exception e1)
                        {
                            setErrorText("Input integers divided by comma");
                        }

                    }
                    if (unsortedRecords.Length > 30)
                        setWarningText("Rakamların sayısı çok olduğu için arayüzde iyi gözükmeyebilir");
                    bubleSort(unsortedRecords);
                }
            }
        }


        private int[] generateRandomArray()
        {
            int Min = 0;
            int Max = 100;

            int[] randomArr = new int[20];

            Random randNum = new Random();
            for (int i = 0; i < randomArr.Length; i++)
            {
                randomArr[i] = randNum.Next(Min, Max);
            }

            return randomArr;
        }

        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
                textBox1.Enabled = false;
            else
                textBox1.Enabled = true;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            speedInfo.Text = ((trackBar.Maximum - trackBar.Value) * (trackBar.Maximum - trackBar.Value)).ToString() + " milliseconds for every iteration";
        }

        private void speedInfo_Click(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (view.Checked)
                chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            else
                chart1.ChartAreas[0].Area3DStyle.Enable3D = false;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

