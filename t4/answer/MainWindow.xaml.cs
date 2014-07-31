using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace answer
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

        public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = sender as ComboBox;
            var sel = combo.SelectedItem as ComboBoxItem;
            //if (sel.Content == null) { return; }
            //if (sel == null) { return; }
        }

        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            var combo = combo_name;
            var sel = combo.SelectedItem as ComboBoxItem;
            if (sel.Content == a.Content) 
            { 
                MessageBox.Show("aaa"); 
            }            
            else if (sel.Content == b.Content)
            { 
                MessageBox.Show("bbb"); 
            }           
            else if (sel == c) 
            {
                MessageBox.Show("ccc"); 
            }
            else 
            { 
                MessageBox.Show("error"); 
            }
        }
    }
}
