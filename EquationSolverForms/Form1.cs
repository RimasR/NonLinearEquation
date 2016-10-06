using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EquationSolverForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static double f(double x)
        {
            return Math.Log(x) + 2;
        }

        private static double df(double x)
        {
            return 1 / x;
        }

        private void buttonBisectionSolve_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            while (chart1.Series.Count > 0)
            {
                chart1.Series.RemoveAt(0);
            }
            int i = 1;
            double x = 10;
            double epsilon = 1e-9;
            double x0 = 0;
            double x1 = 0;
            double x2 = 0;
            double f0;
            double f1;
            double f2;
            int itermax = 200;

            if (!Double.TryParse(textBoxLower.Text, out x0))
            {
                textBox1.Text += "Blogas intervalo pradžios įvedimas! Patikrinkite įvedimą!";
                return;
            }
            if (!Double.TryParse(textBoxHigher.Text, out x1))
            {
                textBox1.Text += "Blogas intervalo pabaigos įvedimas! Patikrinkite įvedimą!";
                return;
            }

            if (f(x0) * f(x1) > 0)
            {
                textBox1.Text += "Cannot find root in this interval.\r\n";
                return;
            }
            string line;
            do
            {
                x2 = (x0 + x1) / 2;
                f0 = f(x0);
                f1 = f(x1);
                if (x1 - x0 < 2 * epsilon)
                {
                    textBox1.Text += $"apytikslis sprendinys: {x2}\r\n";
                }
                f2 = f(x2);
                if (f2 == 0.0)
                {
                    textBox1.Text += $"Tikslus sprendinys: {x2}\r\n";
                }

                line = $"Line{i}";

                chart1.Legends.Clear();
                chart1.Series.Add(line);
                chart1.Series[line].Points.AddXY(x0, -i);
                chart1.Series[line].Points.AddXY(x1, -i);
                chart1.Series[line].ChartType = SeriesChartType.Line;
                chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
                chart1.Series[line].BorderWidth = 5;
                chart1.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
                chart1.ChartAreas[0].AxisX.Interval = 0.5;

                textBox1.Text += $"Iteration: {i}, vidurio taskas {x2}\r\n";

                if (f0 * f2 < 0)
                {
                    x1 = x2;
                }
                else
                {
                    x0 = x2;
                }
                i++;
            }
            while (Math.Abs(f(x1)) > epsilon && i < itermax);
        }

        private void buttonSolveNewton_Click(object sender, EventArgs e)
        {
            textBoxNewton.Clear();
            textBoxNewton.ScrollBars = ScrollBars.Horizontal;
            double pradinisArtinys;
            double epselon;
            int iter = 1;
            int itermax = 50;
            double h;
            double x1 = 0;

            if (!Double.TryParse(textBoxNewtonsArtinys.Text, out pradinisArtinys))
            {
                textBoxNewton.Text += "Blogas pradinio artinio įvedimas! Patikrinkite įvedimą!\r\n";
                return;
            }

            if (!Double.TryParse(textBoxNewtonsEpsilon.Text, out epselon))
            {
                textBoxNewton.Text += "Blogas epselon įvedimas! Patikrinkite įvedimą!\r\n";
                return;
            }
            for (iter = 1; iter < itermax; iter++)
            {
                h = pradinisArtinys - f(pradinisArtinys) / df(pradinisArtinys);

                if (h < 0)
                {
                    textBoxNewton.Text += "Negalima surasti artinio.\r\n";
                    return;
                }

                if (Math.Abs(h - pradinisArtinys) < epselon)
                {
                    textBoxNewton.Text += $"Atsakymas: {h}\r\n";
                    return;
                }

                var line = $"Line{iter}";

                chart1.Legends.Clear();
                chart1.Series.Add(line);
                chart1.Series[line].Points.AddXY(pradinisArtinys, -iter);
                chart1.Series[line].ChartType = SeriesChartType.Point;
                chart1.ChartAreas[0].AxisX.IsMarginVisible = true;
                chart1.Series[line].BorderWidth = 10;
                chart1.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
                chart1.ChartAreas[0].AxisX.Interval = 0.01;

                textBoxNewton.Text += $"Iteracija: {iter}, artinys: {h}\r\n";

                pradinisArtinys = h;
            }
        }
    }
}