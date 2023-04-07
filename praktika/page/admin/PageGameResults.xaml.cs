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
    /// Логика взаимодействия для PageGameResults.xaml
    /// </summary>
    public partial class PageGameResults : Page
    {
        public PageGameResults()
        {
            InitializeComponent();

            DG.ItemsSource = preschoolEntities.GetContext().Results.ToList();
        }
    }
}
