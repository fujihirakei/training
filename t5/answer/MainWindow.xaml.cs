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

        public void ButtonClicked(object sender, RoutedEventArgs e)
        {
            var combo = Operation;
            var sel = combo.SelectedItem as ComboBoxItem;                      

            try
            {
                double t1 = double.Parse(text1.Text);
                double t2 = double.Parse(text2.Text);

                if (sel == a1)
                {
                    double f1 = t1 + t2;
                    string f2 = f1.ToString();
                    MessageBox.Show(f2);
                }
                else if (sel == a2)
                {
                    double f1 = t1 - t2;
                    string f2 = f1.ToString();
                    MessageBox.Show(f2);
                }
                else if (sel == a3)
                {
                    double f1 = t1 * t2;
                    string f2 = f1.ToString();
                    MessageBox.Show(f2);
                }
                else if (sel == a4)
                {
                    double f1 = t1 / t2;
                    string f2 = f1.ToString();
                    MessageBox.Show(f2);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error");
            }
            
        }

    }
}
