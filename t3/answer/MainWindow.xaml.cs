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
        void textbox_MouseUp(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(textbox1.Text);
            int b = int.Parse(textbox2.Text);
            int c = a + b;
            string d = c.ToString();
            MessageBox.Show(d);
            e.Handled = true;
        }
    }
}
