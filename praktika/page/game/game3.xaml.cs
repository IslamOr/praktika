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

namespace praktika.page.game
{
    /// <summary>
    /// Логика взаимодействия для game3.xaml
    /// </summary>
    public partial class game3 : Page

    {
        private preschoolEntities _context = new preschoolEntities();
        public static Image global_sender;
        public game3()
        {
            InitializeComponent();
        }
        private void drop(object sender, DragEventArgs e)
        {
            ((Image)sender).Source = global_sender.Source;
        }
        private void dragent(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.Copy;
        }
        private void i1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image i1 = sender as Image;
            global_sender = i1;
            DragDrop.DoDragDrop(i1, i1.Source, DragDropEffects.Copy);
        }

        private void i3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image i3 = sender as Image;
            global_sender = i3;
            DragDrop.DoDragDrop(i3, i3.Source, DragDropEffects.Copy);
        }

        private void i2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image i2 = sender as Image;
            global_sender = i2;
            DragDrop.DoDragDrop(i2, i2.Source, DragDropEffects.Copy);
        }

        private void i4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image i4 = sender as Image;
            global_sender = i4;
            DragDrop.DoDragDrop(i4, i4.Source, DragDropEffects.Copy);
        }

        private void i5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image i5 = sender as Image;
            global_sender = i5;
            DragDrop.DoDragDrop(i5, i5.Source, DragDropEffects.Copy);
        }
        private void i6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image i6 = sender as Image;
            global_sender = i6;
            DragDrop.DoDragDrop(i6, i6.Source, DragDropEffects.Copy);
        }
        private void i01_DragEnter(object sender, DragEventArgs e)
        {
            dragent(sender, e);
        }

        private void i01_Drop(object sender, DragEventArgs e)
        {
            drop(sender, e);
        }

        private void i02_DragEnter(object sender, DragEventArgs e)
        {
            dragent(sender, e);
        }

        private void i02_Drop(object sender, DragEventArgs e)
        {
            drop(sender, e);           
        }

        private void i03_DragEnter(object sender, DragEventArgs e)
        {
            dragent(sender, e);
        }

        private void i03_Drop(object sender, DragEventArgs e)
        {
            drop(sender, e);           
        }
        private void i04_DragEnter(object sender, DragEventArgs e)
        {
            dragent(sender, e);
        }
        private void i04_Drop(object sender, DragEventArgs e)
        {
            drop(sender, e);
        }
        private void i05_DragEnter(object sender, DragEventArgs e)
        {
            dragent(sender, e);
        }
        private void i05_Drop(object sender, DragEventArgs e)
        {
            drop(sender, e);
        }
        private void i06_DragEnter(object sender, DragEventArgs e)
        {
            dragent(sender, e);
        }
        private void i06_Drop(object sender, DragEventArgs e)
        {
            drop(sender, e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Всё верно!");
            AppFrame.frameMain.Navigate(new PageMenu());
        }
    }
}
