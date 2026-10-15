using System;
using System.Reflection.Emit;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
            labelX1.Visibility = Visibility.Hidden;
            x1.Visibility = Visibility.Hidden;
            labelX2.Visibility = Visibility.Hidden;
            x2.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double aVal, bVal, cVal;

            
            labelX1.Visibility = Visibility.Hidden;
            x1.Visibility = Visibility.Hidden;
            labelX2.Visibility = Visibility.Hidden;
            x2.Visibility = Visibility.Hidden;
            x1.Text = string.Empty;
            x2.Text = string.Empty;
            d.Text = string.Empty;

            
            if (!double.TryParse(a.Text, out aVal))
            {
                MessageBox.Show("Помилка - некоректно введене значення a.");
                return;
            }
            if (!double.TryParse(b.Text, out bVal))
            {
                MessageBox.Show("Помилка - некоректно введене значення b.");
                return;
            }
            if (!double.TryParse(c.Text, out cVal))
            {
                MessageBox.Show("Помилка - некоректно введене значення c.");
                return;
            }

            
            if (aVal == 0)
            {
                MessageBox.Show("Це лінійне рівняння, а не квадратне (а = 0).");
                return;
            }

            
            double dVal = bVal * bVal - 4 * aVal * cVal;
            d.Text = dVal.ToString();

            
            if (dVal > 0)
            {
                double x1Val = (-bVal + Math.Sqrt(dVal)) / (2 * aVal);
                double x2Val = (-bVal - Math.Sqrt(dVal)) / (2 * aVal);

                
                labelX1.Visibility = Visibility.Visible;
                x1.Visibility = Visibility.Visible;
                labelX2.Visibility = Visibility.Visible;
                x2.Visibility = Visibility.Visible;

                x1.Text = x1Val.ToString("0.##");
                x2.Text = x2Val.ToString("0.##");
            }
            else if (dVal == 0)
            {
                double xVal = -bVal / (2 * aVal);

                
                labelX1.Visibility = Visibility.Visible;
                x1.Visibility = Visibility.Visible;
                

                x1.Text = xVal.ToString("0.##");
            }
            else
            {
                MessageBox.Show("Квадратне рівняння не має дійсних розв'язків (дискримінант від'ємний).");
            }
        }
    }
}