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

namespace Lab2
{
    /// <summary>
    /// MainWindow.xaml.cs описывает поведение конкретного окна MainWindow.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumericButton_Click(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            if (but == null)
                return;
            String num = but.Name.Substring(but.Name.Length - 1);
            TextBox expr = this.FindName("Expr") as TextBox;
            if (expr == null)
                return;
            if (expr.Text == "0")
            {
                if (num != "0")
                {
                    expr.Text = num;
                }
            }
            else
            {
                expr.Text += num;
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            if (but == null)
                return;
            TextBox expr = this.FindName("Expr") as TextBox;
            if (expr == null)
                return;
            if (expr.Text.Length == 1)
            {
                expr.Text = "0";
            }
            else
            {
                expr.Text = expr.Text.Substring(0, expr.Text.Length - 1);
            }
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
