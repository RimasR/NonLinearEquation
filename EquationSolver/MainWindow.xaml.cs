using System;
using System.Windows;
namespace EquationSolver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static double f(double x)
        {
            return Math.Log(x) + 2;
        }

        private void newtonButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void bisectionButton_Click(object sender, RoutedEventArgs e)
        {
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

            textBox.Text += "Iveskite intervalo pradzios taska: ";
            if (!Double.TryParse(textBox1.Text, out x0))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                textBox.Text += "Blogas intervalo pradžios įvedimas! Patikrinkite įvedimą!";
            }

            textBox.Text += "Įveskite intervalo pabaigos taska: ";
            if (!Double.TryParse(textBox2.Text, out x1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                textBox.Text += "Blogas intervalo pabaigos įvedimas! Patikrinkite įvedimą!";
            }

            do
            {
                x2 = (x0 + x1) / 2;
                f0 = f(x0);
                f1 = f(x1);
                if (f0 * f1 > 0)
                {
                    textBox.Text += "Cannot find root in this interval.";
                    break;
                }
                if (x1 - x0 < 2 * epsilon)
                {
                    textBox.Text += $"apytikslis sprendinys: {x2}";
                }
                f2 = f(x2);
                if (f2 == 0.0)
                {
                    textBox.Text += $"Tikslus sprendinys: {x2}";
                }
                textBox.Text += $"Iteration: {i}, x0: {x0}, x1: {x1}, x2: {x2}, f0: {f0}, f1: {f1}, f2: {f2}";
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
    }
}