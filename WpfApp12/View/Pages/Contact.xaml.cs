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
    /// Логика взаимодействия для Contact.xaml
    /// </summary>
    public partial class Contact : Page
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Util.UtilFrame?.Navigate(new MainPage());
        }
    }
}
