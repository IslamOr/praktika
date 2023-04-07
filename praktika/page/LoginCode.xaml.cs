using praktika.Cs;
using praktika.db;
using praktika.page.admin;
using praktika.page.game;
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

namespace praktika.page
{
    /// <summary>
    /// Логика взаимодействия для LoginCode.xaml
    /// </summary>
    public partial class LoginCode : Page
    {
        private preschoolEntities _context = new preschoolEntities();
        public LoginCode()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var userObj = _context.Users.FirstOrDefault(x => x.Password == txbLogin.Text);
                if (userObj == null)
                {
                    MessageBox.Show("Такого пользователя нет!", "Ошибка при авторизации!",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    switch (userObj.UserRole)
                    {
                        case 1:
                            MessageBox.Show("Здравствуйте! " + userObj.Name + ", войдите в аккаунт с помощью логина",
                            "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                        case 2:
                            AppFrame.frameMain.Navigate(new PageMenu());
                            break;
                        default:
                            MessageBox.Show("Данные не обнаружены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка " + Ex.Message.ToString() + "Критическая работа прилоения!",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new Login());
        }
    }
}

