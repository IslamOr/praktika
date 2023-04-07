using praktika.Cs;
using praktika.db;
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

namespace praktika.page.admin
{
    /// <summary>
    /// Логика взаимодействия для PageAddUser.xaml
    /// </summary>
    public partial class PageAddUser : Page
    {
        private Users _context = new Users();
        public PageAddUser()

        {
            InitializeComponent();

            cbRole.ItemsSource = preschoolEntities.GetContext().Role.ToList();
            cbRole.SelectedValuePath = "RoleID";
            cbRole.DisplayMemberPath = "RoleName";
            DataContext = _context;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (_context.UsersID == 0)
            {   
                preschoolEntities.GetContext().Users.Add(_context);
                try
                {
                    preschoolEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные добавлены!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString());
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }
    }
}


