using System;
using System.Windows;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Lees de invoerwaarden
                double number = Convert.ToDouble(numberTextBox.Text);
                double divider = Convert.ToDouble(dividerTextBox.Text);

                // Controleer of de deler nul is
                if (divider == 0)
                {
                    throw new DivideByZeroException("De deler mag niet nul zijn.");
                }

                // Voer de berekening uit
                double result = number / divider;

                // Toon het resultaat
                resultTextBox.Text = result.ToString();
            }
            catch (FormatException)
            {
                // Als de invoer niet naar een getal kan worden geconverteerd
                MessageBox.Show("Voer een geldig getal in voor zowel het getal als de deler.", "Ongeldige invoer", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (DivideByZeroException ex)
            {
                // Als de deler nul is
                MessageBox.Show(ex.Message, "Rekenfout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (OverflowException)
            {
                // Als het getal te groot is
                MessageBox.Show("Voer een getal in dat binnen het toegestane bereik ligt.", "Getal te groot", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                // Algemene foutafhandeling
                MessageBox.Show($"Er is een onverwachte fout opgetreden: {ex.Message}", "Onverwachte fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
