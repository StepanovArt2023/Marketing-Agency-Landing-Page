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
    /// Логика взаимодействия для Case.xaml
    /// </summary>
    public partial class Case : Page
    {
        public Case()
        {
            InitializeComponent();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Util.UtilFrame?.Navigate(new MainPage());
        }
    }
}
