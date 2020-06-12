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

            tbantwoord.Text = $"Het kleinste gemene veelvoud van {tbGetal1.Text} & {tbGetal2.Text} is 6 ";
        }

        private void btEinde_Click(object sender, RoutedEventArgs e)
        {

        }
        #region hulpfuncties
        // Return the least common multiple
        // (LCM) of two numbers.
        private long LCM(long a, long b)
        {
            return a * b / GCD(a, b);
        }
        #endregion
    }
}
