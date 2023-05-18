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
using WpfApp12.Model;

namespace WpfApp12.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для DataBase.xaml
    /// </summary>
    public partial class DataBase : Page
    {
        public List<Appli> DatabaseUsers { get; private set; }
        public DataBase()
        {
            InitializeComponent();
            Read();
        }
        public void Read()
        {
            using (ApplicContext db = new ApplicContext())
            {
                DatabaseUsers = db.Applics.ToList();
                LVInfo.ItemsSource = DatabaseUsers;
            }
        }
        public void Create()
        {
            /*using (ApplicContext db = new ApplicContext())
            {
                var login = TbLogin.Text;
                var password = TbPassword.Text;
                var email = TbEmail.Text;

                try
                {
                    if (string.IsNullOrEmpty(login) ||
                        string.IsNullOrEmpty(password) ||
                        string.IsNullOrEmpty(email))
                    {
                        MessageBox.Show("Ошибки ввода данных",
                                        "Системное сообщение",
                                        MessageBoxButton.OK,
                                        MessageBoxImage.Error);
                    }
                    else
                    {
                        db.Users.Add(new User()
                        {
                            Login = login,
                            Password = password,
                            Email = email
                        });
                        db.SaveChanges();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(),
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                }
            }*/

        }
        private void BtnRead_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
