using praktika.Cs;
using praktika.db;
using praktika.page;
using praktika.page.admin;
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

namespace praktika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private preschoolEntities _context = new preschoolEntities();
        public MainWindow()
        {
            InitializeComponent();

            AppFrame.frameMain = FrmMain;
          FrmMain.Navigate(new LoginCode());
           // FrmMain.Navigate(new PagePreschoolers());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // AppFrame.frameMain.GoBack();
            // FrmMain.Navigate(new LoginCode());
           // FrmMain.Navigate(new PagePreschoolers());
        }
    }
}
