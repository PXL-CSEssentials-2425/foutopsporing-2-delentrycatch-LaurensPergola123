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

namespace Centerparks_oef
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly int[] _numberOfDays = new int[] { 1, 2, 5, 7, 8, 12, 14, 21 };
        private string[,] _houseWithPrice = new string[5, 2] {
            { "2 personen", "80" },
            { "4 personen", "120" } ,
            { "4 personen lux", "140" } ,
            { "6 personen", "180" },
            { "8 personen", "200"}
        };
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (int day in _numberOfDays)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = day.ToString();
                comboBoxAantalDagen.Items.Add(comboBoxItem);
            }

            for (int i = 0; i < _houseWithPrice.GetLength(0); i++) 
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = _houseWithPrice[i, 0];
                comboBoxAantalPersonen.Items.Add(comboBoxItem);
            }

            
            
            
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxAantalDagen.SelectedIndex != -1 && comboBoxAantalPersonen.SelectedIndex != -1)
            {
                int prijsPerDag = int.Parse(_houseWithPrice[comboBoxAantalPersonen.SelectedIndex, 1]);
                int dagen = _numberOfDays[comboBoxAantalDagen.SelectedIndex];

                int result = prijsPerDag * dagen;

                resultTextBox.Text = result.ToString();

            }
        }
      

    }
}


