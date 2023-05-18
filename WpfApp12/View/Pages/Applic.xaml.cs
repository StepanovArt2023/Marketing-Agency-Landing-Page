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
using WpfApp12.Model;

namespace WpfApp12.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Applic.xaml
    /// </summary>
    public partial class Applic : Page
    {
        private ApplicContext? _db = new ApplicContext();
        private Appli _appli = new Appli();
        public Applic()
        {
            InitializeComponent();

            _db = new ApplicContext();
        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new Case());
        }

        private void OHAS_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new Case());
        }

        private void Ysl_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new Services());
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Util.UtilFrame?.Navigate(new MainPage());
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (TbnName.Text == "admin")
            {
                Util.UtilFrame?.Navigate(new DataBase());
            }else if (string.IsNullOrEmpty(TbnName.Text) ||
                string.IsNullOrEmpty(TbnEmail.Text) ||
                string.IsNullOrEmpty(TbnPhone.Text) ||
                string.IsNullOrEmpty(TbnInfo.Text))
            {
                MessageBox.Show("Не все данные введены",
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                try
                {

                    _appli.Name = TbnName.Text;
                    _appli.Email = TbnEmail.Text;
                    _appli.Phone = TbnPhone.Text;
                    _appli.info = TbnInfo.Text;



                    MessageBox.Show("Заявка отправлена на рассмотрение",
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);

                    _db?.Applics.Add(_appli);
                    _db?.SaveChanges();

                    TbnName.Text = String.Empty;
                    TbnEmail.Text = String.Empty;
                    TbnPhone.Text = String.Empty;
                    TbnInfo.Text = String.Empty;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(),
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
                }
            }
        }
    }
}
