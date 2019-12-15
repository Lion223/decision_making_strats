using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VGLB_L
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        String fileArr;
        int i = 0, j = 0;
        int[,] arr = new int[3, 3];
        int[] arr0 = new int[3];
        int[] arr1 = new int[3];
        int[] arr2 = new int[3];
        double crit, p1, p2, p3;

        public MainForm()
        {
            InitializeComponent();
        }

        private void RefreshTb()
        {
            vald0.ForeColor = SystemColors.ControlText;
            vald1.ForeColor = SystemColors.ControlText;
            vald2.ForeColor = SystemColors.ControlText;
            gurvic0.ForeColor = SystemColors.ControlText;
            gurvic1.ForeColor = SystemColors.ControlText;
            gurvic2.ForeColor = SystemColors.ControlText;
            laplas0.ForeColor = SystemColors.ControlText;
            laplas1.ForeColor = SystemColors.ControlText;
            laplas2.ForeColor = SystemColors.ControlText;
            bayla0.ForeColor = SystemColors.ControlText;
            bayla1.ForeColor = SystemColors.ControlText;
            bayla2.ForeColor = SystemColors.ControlText;

            vald0.Clear();
            vald1.Clear();
            vald2.Clear();
            gurvic0.Clear();
            gurvic1.Clear();
            gurvic2.Clear();
            laplas0.Clear();
            laplas1.Clear();
            laplas2.Clear();
            bayla0.Clear();
            bayla1.Clear();
            bayla2.Clear();
        }

        private void Vald()
        {
            int min0 = 0, min1 = 0, min2 = 0;

            min0 = arr0.Min();
            min1 = arr1.Min();
            min2 = arr2.Min();

            vald0.Text = min0.ToString();
            vald1.Text = min1.ToString();
            vald2.Text = min2.ToString();

            if (min0 > min1 && min0 > min2)
            {
                resTb.Text += "Vald - A1" + Environment.NewLine;
                vald0.ForeColor = Color.Red;
            }
            else if (min1 > min0 && min1 > min2)
            {
                resTb.Text += "Vald - A2" + Environment.NewLine;
                vald1.ForeColor = Color.Red;
            }
            else if (min2 > min0 && min2 > min1)
            {
                resTb.Text += "Vald - A3" + Environment.NewLine;
                vald2.ForeColor = Color.Red;
            }
        }

        private void Gurvic()
        {
            int min0 = 0, min1 = 0, min2 = 0;
            int max0 = 0, max1 = 0, max2 = 0;
            double h0 = 0, h1 = 0, h2 = 0;

            min0 = arr0.Min();
            min1 = arr1.Min();
            min2 = arr2.Min();

            max0 = arr0.Max();
            max1 = arr1.Max();
            max2 = arr2.Max();

            h0 = crit * min0 + (1 - crit) * max0;
            h1 = crit * min1 + (1 - crit) * max1;
            h2 = crit * min2 + (1 - crit) * max2;

            gurvic0.Text = h0.ToString();
            gurvic1.Text = h1.ToString();
            gurvic2.Text = h2.ToString();

            if (h0 > h1 && h0 > h2)
            {
                resTb.Text += "Gurvic - A1" + Environment.NewLine;
                gurvic0.ForeColor = Color.Red;
            }
            else if (h1 > h0 && h1 > h2)
            {
                resTb.Text += "Gurvic - A2" + Environment.NewLine;
                gurvic1.ForeColor = Color.Red;
            }
            else if (h2 > h0 && h2 > h1)
            {
                resTb.Text += "Gurvic - A3" + Environment.NewLine;
                gurvic2.ForeColor = Color.Red;
            }
        }

        private void Laplas()
        {
            double sum0 = 0, sum1 = 0, sum2 = 0;

            sum0 = arr0.Sum() / 3;
            sum1 = arr1.Sum() / 3;
            sum2 = arr2.Sum() / 3;

            laplas0.Text = sum0.ToString();
            laplas1.Text = sum1.ToString();
            laplas2.Text = sum2.ToString();

            if (sum0 > sum1 && sum0 > sum2)
            {
                resTb.Text += "Laplas - A1" + Environment.NewLine;
                laplas0.ForeColor = Color.Red;
            }
            else if (sum1 > sum0 && sum1 > sum2)
            {
                resTb.Text += "Laplas - A2" + Environment.NewLine;
                laplas1.ForeColor = Color.Red;
            }
            else if (sum2 > sum0 && sum2 > sum1)
            {
                resTb.Text += "Laplas - A3" + Environment.NewLine;
                laplas2.ForeColor = Color.Red;
            }
        }

        private void BayesLaplas()
        {
            double sum0 = 0, sum1 = 0, sum2 = 0;

            sum0 = arr0[0] * p1 +
                   arr0[1] * p2 +
                   arr0[2] * p3;

            sum1 = arr1[0] * p1 +
                   arr1[1] * p2 +
                   arr1[2] * p3;

            sum2 = arr2[0] * p1 +
                   arr2[1] * p2 +
                   arr2[2] * p3;

            bayla0.Text = sum0.ToString();
            bayla1.Text = sum1.ToString();
            bayla2.Text = sum2.ToString();

            if (sum0 > sum1 && sum0 > sum2)
            {
                resTb.Text += "Bayes-Laplas - A1" + Environment.NewLine;
                bayla0.ForeColor = Color.Red;
            }
            else if (sum1 > sum0 && sum1 > sum2)
            {
                resTb.Text += "Bayes-Laplas - A2" + Environment.NewLine;
                bayla1.ForeColor = Color.Red;
            }
            else if (sum2 > sum0 && sum2 > sum1)
            {
                resTb.Text += "Bayes-Laplas - A3" + Environment.NewLine;
                bayla2.ForeColor = Color.Red;
            }
        }

        private void optTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.Handled = true;
        }

        private void ch1Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.Handled = true;
        }

        private void ch2Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.Handled = true;
        }

        private void ch3Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.Handled = true;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileLbl.Text = ofd.SafeFileName;
                fileArr = File.ReadAllText(ofd.FileName);
                RefreshTb();
                resTb.Clear();

                i = 0;
                foreach (var row in fileArr.Split('\n'))
                {
                    j = 0;
                    foreach (var col in row.Trim().Split(' '))
                    {
                        arr[i, j] = int.Parse(col.Trim());
                        j++;
                    }
                    i++;
                }

                arr00.Text = arr[0, 0].ToString();
                arr01.Text = arr[0, 1].ToString();
                arr02.Text = arr[0, 2].ToString();
                arr10.Text = arr[1, 0].ToString();
                arr11.Text = arr[1, 1].ToString();
                arr12.Text = arr[1, 2].ToString();
                arr20.Text = arr[2, 0].ToString();
                arr21.Text = arr[2, 1].ToString();
                arr22.Text = arr[2, 2].ToString();

                Buffer.BlockCopy(arr, 4 * 3 * 0, arr0, 0, 4 * 3);
                Buffer.BlockCopy(arr, 4 * 3 * 1, arr1, 0, 4 * 3);
                Buffer.BlockCopy(arr, 4 * 3 * 2, arr2, 0, 4 * 3);
            }

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            crit = double.Parse(optTb.Text, System.Globalization.CultureInfo.InvariantCulture);
            p1 = double.Parse(ch1Tb.Text, System.Globalization.CultureInfo.InvariantCulture);
            p2 = double.Parse(ch1Tb.Text, System.Globalization.CultureInfo.InvariantCulture);
            p3 = double.Parse(ch1Tb.Text, System.Globalization.CultureInfo.InvariantCulture);
            resTb.Text = "Optimal strategies:" + Environment.NewLine;

            RefreshTb();
            Vald();
            Gurvic();
            Laplas();
            BayesLaplas();
        }
    }
}
