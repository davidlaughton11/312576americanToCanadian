/*David Laughton
 * April 10th, 2019
 * To trainslate from american to canadian.
 */

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

namespace _312576j22002
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //input
            string textIn = txtInput.Text;
            if (txtInput.Text == "quit!")
            {
                App.Current.MainWindow.Close();
            }
            //to find the length and if it contains a vowel
            else if (txtInput.Text.Length >= 4 && (textIn.Contains("a") || textIn.Contains("e") 
                || textIn.Contains("i") || textIn.Contains("o") || textIn.Contains("u") || textIn.Contains("y")))
            {
               textIn = textIn.Replace("or", "our"); Console.WriteLine(textIn);
            }
            //output
            string output = textIn;
            lblOutput.Content = output;
            
        }
    }
}
