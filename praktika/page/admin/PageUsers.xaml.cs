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
    /// Логика взаимодействия для PageUsers.xaml
    /// </summary>
    public partial class PageUsers : Page
    {
        private preschoolEntities _context = new preschoolEntities();
        public PageUsers()
        {
            InitializeComponent();
            preschoolEntities.GetContext();
            DG.ItemsSource = preschoolEntities.GetContext().Users.ToList();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var PreschForDel = DG.SelectedItems.Cast<Users>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить данные? ({PreschForDel.Count()})", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) 
            {
                try
                {
                    preschoolEntities.GetContext().Users.RemoveRange(PreschForDel);
                    preschoolEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DG.ItemsSource = preschoolEntities.GetContext().Users.ToList();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString());
                }
            }
        }

        private void ButtAdd_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new PageAddUser());
        }
        private void ButtRef_Click(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = preschoolEntities.GetContext().Results.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var cur = preschoolEntities.GetContext().Users.ToList();
            cur = cur.Where(x => x.Surname.ToLower().Contains(txb.Text.ToLower())).ToList();
            DG.ItemsSource = cur.ToList();
        }
    }
}
