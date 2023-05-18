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
using WpfApp12.Core;

namespace WpfApp12.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TbnArrow_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new Desktop1());
        }

        private void Case_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new Contact());
        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new Case());
        }

        private void Services_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new Services());
        }

        private void Application_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new Applic());
        }
    }
}
