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
using System.Data;

namespace WPFCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach(UIElement el in MainRoot.Children)
            {
                if(el is Button)
                {
                    ((Button)el).Click += Button_click;
                }
            }
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (str.Contains("AC"))
                textlabel.Text = "";
            else if( str == "=")
            {
                string value = new DataTable().Compute(textlabel.Text, null).ToString();
                textlabel.Text +=  "=" + value;
            }
            else
                textlabel.Text += str;
            // BorderBrush = "#FF707070"
            //((Button)e.OriginalSource).BorderBrush = "FF707070";
            



        }
    }
}

