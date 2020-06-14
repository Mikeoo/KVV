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

namespace KVV
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

        private void btBereken_Click(object sender, RoutedEventArgs e)
        {
            if (cbOntbinden.IsChecked == true)
            {
                tbantwoord.Text = $" Grootste gemene deler van {tbGetal1.Text} & {tbGetal2.Text} is {GCD(Convert.ToInt32(tbGetal1.Text), Convert.ToInt32(tbGetal2.Text))} !";

            }
            else
            {
                tbantwoord.Text = $" Kleinste gemene veelvoud van {tbGetal1.Text} & {tbGetal2.Text} is {LCM(Convert.ToInt32(tbGetal1.Text), Convert.ToInt32(tbGetal2.Text))} !";
            }
        }

        private void btEinde_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        #region hulpfuncties

        public int GCD(int i, int j)
        {
            int a = Math.Abs(i);
            int b = Math.Abs(j);

            // Pull out remainders.
            for (; ; )
            {
                int remainder = a % b;
                if (remainder == 0) return b;
                a = b;
                b = remainder;
            };
        }

        private int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }
        #endregion
    }

}
