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

namespace SearchFactorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            vvodFactorial.MaxLength = 55;
            resultFactorial.IsReadOnly = true;
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n* Factorial(n - 1);
            }
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {


            if (vvodFactorial.Text == "")
            {
                MessageBox.Show("Не введено число!");
            }
            else
            {
                int n = Convert.ToInt32(vvodFactorial.Text);
                int result = Factorial(n);
                resultFactorial.Text = result.ToString();
            }

        }

        private void vvodFactorial_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    }
}
