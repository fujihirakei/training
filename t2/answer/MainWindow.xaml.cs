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

        void textbox_MouseDown(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Hello World!");
            e.Handled = true;
        }
        void textbox_MouseUp(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("HELLO WORLD!");
            e.Handled = true;
        }
        void textbox_MouseDoubleClick(object sender, RoutedEventArgs t)
        {
            MessageBox.Show("hello");
            t.Handled = true;

        }
    }
}
