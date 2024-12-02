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

namespace LAbo_combobox
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] comboItems = { "item1", "item2", "item3", "item4", "item5", };
            string[] listItems = { "item1", "item2", "item3", "item4", "item5", };

            foreach (string s in comboItems)
            {
                ComboBoxItem newItem = new ComboBoxItem();
                newItem.Content = s;
                firstComboBox.Items.Add(newItem);

            }

            foreach (string s in listItems)
            {
                ListBoxItem newItem = new ListBoxItem();
                newItem.Content = s;
                listBox.Items.Add(newItem);

            }
        }
            
        private void firstComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selected = (ComboBoxItem)firstComboBox.SelectedItem;
            comboLabel.Content = selected.Content;
        }  
        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        listBoxLabel.Content = string.Empty;
        foreach (object selected in listBox.SelectedItems)
        {

        }
        //ListBoxItem selected = listBox.SelectedItem as ListBoxItem;
        //listBoxLabel.Content = selected.Content;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.RemoveAt(listBox.Items.Count - 1);
        }
    }
}
