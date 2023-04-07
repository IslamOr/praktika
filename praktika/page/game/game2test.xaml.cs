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
    /// Логика взаимодействия для game2test.xaml
    /// </summary>
    public partial class game2test : Page
    {
        public game2test()
        {
            InitializeComponent();
        }
        private void tbT_Drop(object sender, DragEventArgs e)
        {
            string str = (string)e.Data.GetData(DataFormats.Text);
            if (str == "Квадрат")
            {

                ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);
                ToolTip = ("Верно!");

            }
            else
            {

                ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);

                ToolTip = ("Неверно!");
            }
        }

        private void tbT2_Drop(object sender, DragEventArgs e)
        {
            string str = (string)e.Data.GetData(DataFormats.Text);
            if (str == "Треугольник")
            {

                ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);
                ToolTip = ("Верно!");

            }
            else
            {

                ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);

                ToolTip = ("Неверно!");
            }
        }
        private void tbT3_Drop(object sender, DragEventArgs e)
        {
            string str = (string)e.Data.GetData(DataFormats.Text);
            if (str == "Ромб")
            {

                ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);
                ToolTip = ("Верно!");

            }
            else
            {

                ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);

                ToolTip = ("Неверно!");
            }
        }

        private void tbT4_Drop(object sender, DragEventArgs e)
        {
            string str = (string)e.Data.GetData(DataFormats.Text);
            if (str == "Куб")
            {

                ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);
                ToolTip = ("Верно!");

            }
            else
            {

                ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);

                ToolTip = ("Неверно!");
            }
        }

        private void tb1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock lb1 = (TextBlock)sender;
            DragDrop.DoDragDrop(lb1, lb1.Text, DragDropEffects.Copy);
        }

        private void tb2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock lb1 = (TextBlock)sender;
            DragDrop.DoDragDrop(lb1, lb1.Text, DragDropEffects.Copy);
        }

        private void tb3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock lb1 = (TextBlock)sender;
            DragDrop.DoDragDrop(lb1, lb1.Text, DragDropEffects.Copy);
        }

        private void tb4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock lb1 = (TextBlock)sender;
            DragDrop.DoDragDrop(lb1, lb1.Text, DragDropEffects.Copy);
        }

        private void DragE(object sender, DragEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tbT.Text == "Квадрат" & (tbT1.Text == "Треугольник"))
            {
                MessageBox.Show("всё верно!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}