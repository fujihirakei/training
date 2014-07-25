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

namespace answer2
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
        
        // RED を押すと"赤"を表示
        private void ButtonClicked_1(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("赤");
            e.Handled = true;
        }

        // GREEN を押すと"緑"を表示
        private void ButtonClicked_2(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("緑");
            e.Handled = true;
        }

        // BLUE を押すと"青"を表示
        private void ButtonClicked_3(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("青");
            e.Handled = true;
        }
     }
}
