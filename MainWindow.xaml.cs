using System.Windows;

namespace Content
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

        private void ButtonDollar_Click(object sender, RoutedEventArgs e)
        {
            resDollar.Text = Calculate(rateDollar.Text, sumDollar.Text).ToString();
        }

        private void ButtonEuro_Click(object sender, RoutedEventArgs e)
        {
            resEuro.Text = Calculate(rateEuro.Text, sumEuro.Text).ToString();
        }

        private void ButtonHryvnia_Click(object sender, RoutedEventArgs e)
        {
            resHryvnia.Text = Calculate(rateHryvnia.Text, sumHryvnia.Text).ToString();
        }

        private void ButtonDram_Click(object sender, RoutedEventArgs e)
        {
            resDram.Text = Calculate(rateDram.Text, sumDram.Text).ToString();
        }

        private void ButtonInch_Click(object sender, RoutedEventArgs e)
        {
            resInch.Text = Calculate(0.0254, qtyInch.Text).ToString();
        }

        private void ButtonFoot_Click(object sender, RoutedEventArgs e)
        {
            resFoot.Text = Calculate(0.3048, qtyFoot.Text).ToString();
        }

        private void ButtonMile_Click(object sender, RoutedEventArgs e)
        {
            resMile.Text = Calculate(1609.344, qtyMile.Text).ToString();
        }

        private void ButtonVerst_Click(object sender, RoutedEventArgs e)
        {
            resVerst.Text = Calculate(1066.8, qtyVerst.Text).ToString();
        }

        private double? Calculate(string rateText, string qtyText)
        {
            if (double.TryParse(rateText, out double rate) && double.TryParse(qtyText, out double qty))
            {
                return rate * qty;
            }
            else
            {
                MessageBox.Show("Некорректный формат исходных данных.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return null;
            }
        }

        private double? Calculate(double rate, string qtyText) =>
            Calculate(rate.ToString(), qtyText);
    }
}