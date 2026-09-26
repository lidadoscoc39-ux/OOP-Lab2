using System;
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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            s.Text = string.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double xVal, yVal, zVal;

            if (!double.TryParse(x.Text, out xVal))
            {
                MessageBox.Show("Некоректне значення x!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(y.Text, out yVal))
            {
                MessageBox.Show("Некоректне значення y!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(z.Text, out zVal))
            {
                MessageBox.Show("Некоректне значення z!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Перевірка області визначення для логарифма (ln z суворо для z > 0)
            if (zVal <= 0)
            {
                MessageBox.Show("Значення z має бути більше за 0 (область визначення для ln z)!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Перевірка на ділення на нуль у внутрішньому знаменнику (x - y)
            if (xVal - yVal == 0)
            {
                MessageBox.Show("Помилка: ділення на нуль, оскільки x дорівнює y!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                // Обчислення за вашим варіантом
                double innerFraction = Math.Log(zVal) / (xVal - yVal);
                double numerator = (yVal - xVal) * (Math.Cos(yVal) - innerFraction);
                double denominator = 1.0 + Math.Pow(xVal - zVal, 2);

                double result = numerator / denominator;

                result = Math.Round(result, 3);
                s.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при обчисленні: " + ex.Message, "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}