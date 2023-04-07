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

namespace praktika.page.game
{
    /// <summary>
    /// Логика взаимодействия для game2.xaml
    /// </summary>
    public partial class game2 : Page
    {
        public static Image global_sender;
        public game2()
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

        private void f1_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
            Image f1 = sender as Image;
           global_sender = f1;
            DragDrop.DoDragDrop(f1, f1.Source, DragDropEffects.Copy);
            {
                end();
            }
        }
        private void bf1_Click(object sender, RoutedEventArgs e)
        {
         {
                MessageBox.Show("Всё верно!");
                AppFrame.frameMain.Navigate(new PageMenu());
         }
        }
        private void i1_Drop(object sender, DragEventArgs e)
        {         
            drop(sender, e);
        }

        private void i1_DragEnter(object sender, DragEventArgs e)
        {
            dragent(sender, e);
        }

        private void i2_Drop(object sender, DragEventArgs e)
        {
            drop(sender, e);
        }

        private void i2_DragEnter(object sender, DragEventArgs e)
        {
            dragent(sender, e);

        }

        private void i3_Drop(object sender, DragEventArgs e)
        {
            drop(sender, e);
        }

        private void i3_DragEnter(object sender, DragEventArgs e)
        {
            dragent(sender, e);
        }

        private void i4_Drop(object sender, DragEventArgs e)
        {
            drop(sender, e);
        }

        private void i4_DragEnter(object sender, DragEventArgs e)
        {
            dragent(sender, e);
        }

        private void i5_Drop(object sender, DragEventArgs e)
        {
            drop(sender, e);
        }

        private void i5_DragEnter(object sender, DragEventArgs e)
        {
            dragent(sender, e);
        }

        private void i6_Drop(object sender, DragEventArgs e)
        {
            drop(sender, e);
        }

        private void i6_DragEnter(object sender, DragEventArgs e)
        {
            dragent(sender, e);
        }


        private void f2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image f2 = sender as Image;
            global_sender = f2;
            DragDrop.DoDragDrop(f2, f2.Source, DragDropEffects.Copy);
            {
                end();
            }
        }

        private void f3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image f3 = sender as Image;
            global_sender = f3;
            DragDrop.DoDragDrop(f3, f3.Source, DragDropEffects.Copy);
            {
                end();
            }
        }

        private void f4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image f4 = sender as Image;
            global_sender = f4;
            DragDrop.DoDragDrop(f4, f4.Source, DragDropEffects.Copy);
            {
                end();
            }
        }

        private void f5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image f5 = sender as Image;
            global_sender = f5;
            DragDrop.DoDragDrop(f5, f5.Source, DragDropEffects.Copy);
            {
                end();
            }
        }

        private void f6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image f6 = sender as Image;
            global_sender = f6;
            DragDrop.DoDragDrop(f6, f6.Source, DragDropEffects.Copy);
            {
                end();
            }
        }

        private void bn1_Click(object sender, RoutedEventArgs e)
        {
            n1.Opacity = 0;
            no1.Opacity = 100;
        }

        private void bn2_Click(object sender, RoutedEventArgs e)
        {
            n2.Opacity = 0;
            no2.Opacity = 100;
        }

        private void bn3_Click(object sender, RoutedEventArgs e)
        {
            n3.Opacity = 0;
            no3.Opacity = 100;
         
        }

        private void end()
        {
            if (i1 == f1 & i1 == f2 & i1 == f3 & i1 == f4 & i1 == f5 & i1 == f6 & i1.Source == f1.Source)
            {
                b1.Opacity = 0;
                b2.Opacity = 100;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Всё верно!");
            AppFrame.frameMain.Navigate(new game3());
        }
    }
}
      
