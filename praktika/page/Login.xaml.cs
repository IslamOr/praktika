using praktika.Cs;
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
using praktika.db;
using praktika.page.game;
using praktika.page.admin;

namespace praktika.page
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        private preschoolEntities _context = new preschoolEntities();

        public Login()
        {
            InitializeComponent();
        }  
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = _context.Users.FirstOrDefault(x => x.Login == txbLogin.Text && x.Password == txbPass.Password);
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
                            AppFrame.frameMain.Navigate(new PageAdmin());
                            break;
                        case 2:
                            AppFrame.frameMain.Navigate(new PageMenu());
                            UserId.Id = userObj.UsersID;
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
            AppFrame.frameMain.Navigate(new LoginCode());
        }
    }
}

