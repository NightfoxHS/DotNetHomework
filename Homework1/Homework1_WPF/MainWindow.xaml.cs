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

namespace Homework1_WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            exp_ComboBox.SelectedIndex = 0;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            float res = 0;
            ComboBoxItem sel_item = (ComboBoxItem)exp_ComboBox.SelectedItem;
            try
            {
                switch (Int32.Parse(sel_item.Tag.ToString()))
                {
                    case 0:
                        res = float.Parse(num1_TextBox.Text) + float.Parse(num2_TextBox.Text);
                        break;
                    case 1:
                        res = float.Parse(num1_TextBox.Text) - float.Parse(num2_TextBox.Text);
                        break;
                    case 2:
                        res = float.Parse(num1_TextBox.Text) * float.Parse(num2_TextBox.Text);
                        break;
                    case 3:
                        res = float.Parse(num1_TextBox.Text) / float.Parse(num2_TextBox.Text);
                        break;
                    case 4:
                        res = float.Parse(num1_TextBox.Text) % float.Parse(num2_TextBox.Text);
                        break;
                    default:
                        break;
                }
                res_Textbox.Text = res.ToString(); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter the correct number.");
            }
        }
    }
}
