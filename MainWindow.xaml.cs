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

namespace WpfCheckBox
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
        private void AllCheckChanged(object sender, RoutedEventArgs e)
        {
            bool state = (AllTopings.IsChecked == true);
            Salami.IsChecked =
             Mushroom.IsChecked =
             Mozzarella.IsChecked = state;

        }
        private void SingleCheckChanged(object sender, RoutedEventArgs e)
        {
            AllTopings.IsChecked = null;
            if (Salami.IsChecked == true &&
             Mushroom.IsChecked == true &&
             Mozzarella.IsChecked == true)
            {
                AllTopings.IsChecked = true;
            }

            if (Salami.IsChecked == false &&
             Mushroom.IsChecked == false &&
             Mozzarella.IsChecked == false)
            {
                AllTopings.IsChecked = false;
            }


        }


    }

   
}
