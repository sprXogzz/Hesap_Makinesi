using MathNet.Numerics.Differentiation;
using MathNet.Numerics.Integration;
using MathNet.Symbolics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Expr = MathNet.Symbolics.Expression;



namespace ogimak
{
    public partial class Form1 : Form
    {
        double sayi1, sayi2, islem, deger, islemler, toplam;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")

            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "1";

            }
            else
            {
                if (deger == 1)
                {
                    textBox1.Text = "";
                    textBox1.Text = textBox1.Text + "1";
                    deger = 0;

                }
                else
                {
                    textBox1.Text = textBox1.Text + "1";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "2";
            }
            else
            {
                if (deger == 1)
                {
                    textBox1.Text = "";
                    textBox1.Text = textBox1.Text + "2";
                    deger = 0;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "2";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "3";
            }
            else
            {
                if (deger == 1)
                {
                    textBox1.Text = "";

                    textBox1.Text = textBox1.Text + "3";

                    deger = 0;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "3";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "4";
            }
            else
            {
                if (deger == 1)
                {
                    textBox1.Text = "";
                    textBox1.Text = textBox1.Text + "4";
                    deger = 0;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "4";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "5";
            }
            else
            {
                if (deger == 1)
                {
                    textBox1.Text = "";
                    textBox1.Text = textBox1.Text + "5";
                    deger = 0;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "5";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "6";
            }
            else
            {
                if (deger == 1)
                {
                    textBox1.Text = "";
                    textBox1.Text = textBox1.Text + "6";
                    deger = 0;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "6";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "8";
            }
            else
            {
                if (deger == 1)
                {
                    textBox1.Text = "";
                    textBox1.Text = textBox1.Text + "8";
                    deger = 0;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "8";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "7";
            }
            else
            {
                if (deger == 1)
                {
                    textBox1.Text = "";
                    textBox1.Text = textBox1.Text + "7";
                    deger = 0;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "7";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "9";
            }
            else
            {
                if (deger == 1)
                {
                    textBox1.Text = "";
                    textBox1.Text = textBox1.Text + "9";
                    deger = 0;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "9";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {

            }
            else
            {
                if (deger == 1)
                {
                    textBox1.Text = "";
                    textBox1.Text = textBox1.Text + "0";
                    deger = 0;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "0";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double sayi, carpim;
            sayi = Convert.ToInt32(textBox1.Text);
            carpim = sayi * -1;
            textBox1.Text = carpim.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = 1;
            deger = 1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(textBox1.Text);
            if (islem == 1)
            {
                islemler = sayi2 + sayi1;
            }

            if (islem == 2)
            {
                islemler = sayi1 - sayi2;
            }

            if (islem == 3)
            {
                islemler = sayi1 * sayi2;
            }

            if (islem == 4)
            {
                islemler = sayi1 / sayi2;
            }

            textBox1.Text = islemler.ToString();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = 2;
            deger = 1;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = 3;
            deger = 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = 4;
            deger = 1;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sayi1 = 0;
            sayi2 = 0;
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = Math.Sin(a * Math.PI / 180);   // derece --->> radyan
            textBox1.Text = b.ToString();
            button24.Text = "sin";






        }

        private void button21_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = Math.Sqrt(a);
            textBox1.Text = b.ToString();
            button24.Text = "sqrt";
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show(
                "Hangi grafiği çizmek istiyorsun?\nEvet = X^2\nHayır = X^3\nİptal = |X| ve √X",
                "Grafik Seçimi",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Minimum = -5;
            chart1.ChartAreas[0].AxisX.Maximum = 5;
            chart1.ChartAreas[0].AxisY.Minimum = -5;
            chart1.ChartAreas[0].AxisY.Maximum = 5;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisY.Crossing = 0;

            double start = -5;
            double end = 5;
            double step = 0.1;

            if (result == DialogResult.Yes) // X^2
            {
                Series s = new Series("X^2");
                s.ChartType = SeriesChartType.Line;
                s.Color = Color.Red;
                for (double x = start; x <= end; x += step)
                    s.Points.AddXY(x, Math.Pow(x, 2));
                chart1.Series.Add(s);
            }
            else if (result == DialogResult.No) // X^3
            {
                Series s = new Series("X^3");
                s.ChartType = SeriesChartType.Line;
                s.Color = Color.Blue;
                for (double x = start; x <= end; x += step)
                    s.Points.AddXY(x, Math.Pow(x, 3));
                chart1.Series.Add(s);
            }
            else if (result == DialogResult.Cancel) 
            {
                Series s1 = new Series("|X|");
                s1.ChartType = SeriesChartType.Line;
                s1.Color = Color.Green;
                for (double x = start; x <= end; x += step)
                    s1.Points.AddXY(x, Math.Abs(x));
                chart1.Series.Add(s1);

                Series s2 = new Series("√X");
                s2.ChartType = SeriesChartType.Line;
                s2.Color = Color.Orange;
                for (double x = 0; x <= end; x += step)
                    s2.Points.AddXY(x, Math.Sqrt(x));
                chart1.Series.Add(s2);
            }

            chart1.Legends[0].Docking = Docking.Top;
            chart1.ChartAreas[0].AxisX.Title = "X";
            chart1.ChartAreas[0].AxisY.Title = "Y";
        }


        private double NumericalDerivative(Func<double, double> f, double x, double h = 1e-5)
        {
            return (f(x + h) - f(x - h)) / (2 * h);
        }

        private void buttonDerivativeIntegral_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text; // Örn: "x^3 + 2*x"
                var expr = Infix.ParseOrThrow(input);

                // Sayısal fonksiyon
                Func<double, double> f = val =>
                {
                    var dict = new Dictionary<string, FloatingPoint> { { "x", (FloatingPoint)val } };
                    var eval = Evaluate.Evaluate(dict, expr);
                    return eval.RealValue; 
                };

                // Kullanıcıya seçenek
                DialogResult secim = MessageBox.Show(
                    "Türev almak için 'Yes', İntegral için 'No' tuşuna basın.",
                    "Türev mi İntegral mi?",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (secim == DialogResult.Yes) // Türev
                {
                    double x0 = 1.0; // türev alınacak nokta
                    double result = NumericalDerivative(f, x0);
                    textBox1.Text = result.ToString("F5") + $" (sayısal türev x={x0})";
                }
                else if (secim == DialogResult.No) // İntegral
                {
                    double result = MathNet.Numerics.Integration.DoubleExponentialTransformation.Integrate(f, 0.0, 1.0, 1e-6);
                    textBox1.Text = result.ToString("F5") + " (sayısal integral 0→1)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hatalı ifade", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = Math.Cos(a * Math.PI / 180);  // dereceyi radyana çeviriyo
            textBox1.Text = b.ToString();
            button24.Text = "cos";

        }

        private void button26_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            int faktoriyel = 1;
            for (int i = sayi; i > 1; i--)
            {
                faktoriyel = faktoriyel * i;
            }
            textBox1.Text = faktoriyel.ToString();




        }

        private void button27_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = Math.Tan(a * Math.PI / 180);   // dereceyi radyana çeviriyo
            textBox1.Text = b.ToString();
            button24.Text = "tan";

        }

        private void button23_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = Math.Log10(a);
            textBox1.Text = b.ToString();
            button23.Text = "Log10";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double a, b;
            if (textBox1.Text == "e")
                a = Math.E;  // e sabiti
            else
                a = Convert.ToDouble(textBox1.Text);

            b = Math.Log(a);  // doğal log (ln)
            textBox1.Text = b.ToString();
            button22.Text = "log";

        }



    }


}








