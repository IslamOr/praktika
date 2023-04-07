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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace praktika.page.game
{
    /// <summary>
    /// Логика взаимодействия для game1.xaml
    /// </summary>
    public partial class game1 : Page
    {
        private Results _context = new Results();
        public game1()
        {
            InitializeComponent();
        }

        private void t1tb1_Checked(object sender, RoutedEventArgs e)
        {
           // t1tb1.IsChecked = (true);
            t1tb2.IsChecked = (false);
            t1tb3.IsChecked = (false);
            
        }

        private void t1tb2_Checked(object sender, RoutedEventArgs e)
        {
            t1tb1.IsChecked = (false);
            t1tb3.IsChecked = (false);
           
        }

        private void t1tb3_Checked(object sender, RoutedEventArgs e)
        {
            t1tb2.IsChecked = (false);
            t1tb1.IsChecked = (false);
            
        }

        private void t1tb4_Checked(object sender, RoutedEventArgs e)
        {
            t1tb2.IsChecked = (false);
            t1tb3.IsChecked = (false);
            t1tb1.IsChecked = (false);
           
        }

        private void t1tb5_Checked(object sender, RoutedEventArgs e)
        {
            t1tb2.IsChecked = (false);
            t1tb3.IsChecked = (false);
           ;
            t1tb1.IsChecked = (false);
        }

        private void t2tb1_Checked(object sender, RoutedEventArgs e)
        {
            t2tb2.IsChecked = (false);
            t2tb3.IsChecked = (false);
           
        }

        private void t2tb2_Checked(object sender, RoutedEventArgs e)
        {
            t2tb1.IsChecked = (false);
            t2tb3.IsChecked = (false);
            
        }

        private void t2tb3_Checked(object sender, RoutedEventArgs e)
        {
            t2tb2.IsChecked = (false);
            t2tb1.IsChecked = (false);
           
        }

        private void t2tb4_Checked(object sender, RoutedEventArgs e)
        {
            t2tb2.IsChecked = (false);
            t2tb3.IsChecked = (false);
            t2tb1.IsChecked = (false);
        }

        private void t2tb5_Checked(object sender, RoutedEventArgs e)
        {
            t2tb2.IsChecked = (false);
            t2tb3.IsChecked = (false);
            t2tb1.IsChecked = (false);
        }

        private void t3tb1_Checked(object sender, RoutedEventArgs e)
        {
            t3tb2.IsChecked = (false);
            t3tb3.IsChecked = (false);
        }

        private void t3tb2_Checked(object sender, RoutedEventArgs e)
        {
            t3tb1.IsChecked = (false);
            t3tb3.IsChecked = (false);
      
        }

        private void t3tb3_Checked(object sender, RoutedEventArgs e)
        {
            t3tb2.IsChecked = (false);
            t3tb1.IsChecked = (false);
           
        }

        private void t3tb4_Checked(object sender, RoutedEventArgs e)
        {
            t3tb2.IsChecked = (false);
            t3tb3.IsChecked = (false);
            t3tb1.IsChecked = (false);
        }

        private void t3tb5_Checked(object sender, RoutedEventArgs e)
        {
            t3tb2.IsChecked = (false);
            t3tb3.IsChecked = (false);
            t3tb1.IsChecked = (false);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (t1tb3.IsChecked == (true) && t2tb1.IsChecked == (true) && t3tb2.IsChecked == (true)) // (t2tb1.IsChecked == (true))
            {
           
                MessageBox.Show("Всё верно!");
                AppFrame.frameMain.Navigate(new game2());
            }
            else if (t1tb3.IsChecked == (false) && t2tb1.IsChecked == (true) && t3tb2.IsChecked == (true))
            {
             
                er1.Opacity = 100;
                er2.Opacity = 0;
                er3.Opacity = 0;
            }
            else if (t1tb3.IsChecked == (false) && t2tb1.IsChecked == (false) && t3tb2.IsChecked == (true))
            {
             
                er1.Opacity = 100;
                er2.Opacity = 100;
                er3.Opacity = 0;
            }
            else if (t1tb3.IsChecked == (false) && t2tb1.IsChecked == (true) && t3tb2.IsChecked == (false))
            {
                er1.Opacity = 100;
                er2.Opacity = 0;
                er3.Opacity = 100;
            }


            else if (t1tb3.IsChecked == (true) && t2tb1.IsChecked == (false) && t3tb2.IsChecked == (true))
            {
                er1.Opacity = 0;
                er2.Opacity = 100;
                er3.Opacity = 0;
            }
            else if (t1tb3.IsChecked == (true) && t2tb1.IsChecked == (true) && t3tb2.IsChecked == (false))
            {
                er1.Opacity = 0;
                er2.Opacity = 0;
                er3.Opacity = 100;

            }
            else if (t1tb3.IsChecked == (true) && t2tb1.IsChecked == (false) && t3tb2.IsChecked == (false))
            {
                er1.Opacity = 0;
                er3.Opacity = 100;
                er3.Opacity = 100;
            }

            else if (t1tb1.IsChecked == (false) && t1tb2.IsChecked == (false) && t1tb3.IsChecked == (false) &&
        (t2tb1.IsChecked == (false) && t2tb2.IsChecked == (false) && t2tb3.IsChecked == (false) &&
        (t3tb1.IsChecked == (false) && t3tb2.IsChecked == (false) && t3tb3.IsChecked == (false))))
            {
                er1.Opacity = 100;
                er2.Opacity = 100;
                er3.Opacity = 100;
            }
            else if (t1tb1.IsChecked == (false) && t1tb2.IsChecked == (false) && t1tb3.IsChecked == (false))
            {
                er1.Opacity = 100;
            }
            else if (t2tb1.IsChecked == (false) && t2tb2.IsChecked == (false) && t2tb3.IsChecked == (false))
            {
                er2.Opacity = 100;
            }
            else if (t3tb1.IsChecked == (false) && t3tb2.IsChecked == (false) && t3tb3.IsChecked == (false))
            {
                er3.Opacity = 100;
            }
            else
            {
                er1.Opacity = 100;
                er2.Opacity = 100;
                er3.Opacity = 100;
            }
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            t1tb1.IsChecked = (true);
            t1tb2.IsChecked = (false);
            t1tb3.IsChecked = (false);

            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 0;
            anim.To = 150;
            anim.Duration = TimeSpan.FromSeconds(0.2);
            anim.EasingFunction = new QuadraticEase();
            v1.BeginAnimation(WidthProperty, anim);

            if (v2.Width > 0) 
            {

                DoubleAnimation anim1 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v2.BeginAnimation(WidthProperty, anim);
            }
            else if (v3.Width > 0)
            {
                DoubleAnimation anim2 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v3.BeginAnimation(WidthProperty, anim);
            }
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            t1tb1.IsChecked = (false);
            t1tb2.IsChecked = (true);
            t1tb3.IsChecked = (false);

            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 0;
            anim.To = 150;
            anim.Duration = TimeSpan.FromSeconds(0.2);
            anim.EasingFunction = new QuadraticEase();
            v2.BeginAnimation(WidthProperty, anim);

            if (v1.Width > 0)
            {
                DoubleAnimation anim1 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v1.BeginAnimation(WidthProperty, anim);
            }
            else if (v3.Width > 0)
            {
                DoubleAnimation anim2 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v3.BeginAnimation(WidthProperty, anim);
            }
        }
        private void b3_Click(object sender, RoutedEventArgs e)
        {
            t1tb1.IsChecked = (false);
            t1tb2.IsChecked = (false);
            t1tb3.IsChecked = (true);

            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 0;
            anim.To = 150;
            anim.Duration = TimeSpan.FromSeconds(0.2);
            anim.EasingFunction = new QuadraticEase();
            v3.BeginAnimation(WidthProperty, anim);

            if (v1.Width > 0)
            {
                DoubleAnimation anim1 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v1.BeginAnimation(WidthProperty, anim);
            }
            else if (v2.Width > 0)
            {
                DoubleAnimation anim2 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v2.BeginAnimation(WidthProperty, anim);
            }
        }
        private void b4_Click(object sender, RoutedEventArgs e)
        {
            t2tb1.IsChecked = (true);
            t2tb2.IsChecked = (false);
            t2tb3.IsChecked = (false);

            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 0;
            anim.To = 150;
            anim.Duration = TimeSpan.FromSeconds(0.2);
            anim.EasingFunction = new QuadraticEase();
            v4.BeginAnimation(WidthProperty, anim);

            if (v5.Width > 0)
            {

                DoubleAnimation anim1 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v5.BeginAnimation(WidthProperty, anim);
            }
            else if (v6.Width > 0)
            {
                DoubleAnimation anim2 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v6.BeginAnimation(WidthProperty, anim);
            }
        }
        private void b5_Click(object sender, RoutedEventArgs e)
        {
            t2tb1.IsChecked = (false);
            t2tb2.IsChecked = (true);
            t2tb3.IsChecked = (false);

            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 0;
            anim.To = 150;
            anim.Duration = TimeSpan.FromSeconds(0.2);
            anim.EasingFunction = new QuadraticEase();
            v5.BeginAnimation(WidthProperty, anim);

            if (v4.Width > 0)
            {
                DoubleAnimation anim1 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v4.BeginAnimation(WidthProperty, anim);
            }
            else if (v6.Width > 0)
            {
                DoubleAnimation anim2 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v6.BeginAnimation(WidthProperty, anim);
            }
        }
        private void b6_Click(object sender, RoutedEventArgs e)
        {
            t2tb1.IsChecked = (false);
            t2tb2.IsChecked = (false);
            t2tb3.IsChecked = (true);

            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 0;
            anim.To = 150;
            anim.Duration = TimeSpan.FromSeconds(0.2);
            anim.EasingFunction = new QuadraticEase();
            v6.BeginAnimation(WidthProperty, anim);

            if (v4.Width > 0)
            {
                DoubleAnimation anim1 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v4.BeginAnimation(WidthProperty, anim);
            }
            else if (v5.Width > 0)
            {
                DoubleAnimation anim2 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v5.BeginAnimation(WidthProperty, anim);
            }
        }
        private void b7_Click(object sender, RoutedEventArgs e)
        {
            t3tb1.IsChecked = (true);
            t3tb2.IsChecked = (false);
            t3tb3.IsChecked = (false);

            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 0;
            anim.To = 150;
            anim.Duration = TimeSpan.FromSeconds(0.2);
            anim.EasingFunction = new QuadraticEase();
            v7.BeginAnimation(WidthProperty, anim);

            if (v8.Width > 0)
            {

                DoubleAnimation anim1 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v8.BeginAnimation(WidthProperty, anim);
            }
            else if (v9.Width > 0)
            {
                DoubleAnimation anim2 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v9.BeginAnimation(WidthProperty, anim);
            }
        }
        private void b8_Click(object sender, RoutedEventArgs e)
        {
            t3tb1.IsChecked = (false);
            t3tb2.IsChecked = (true);
            t3tb3.IsChecked = (false);

            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 0;
            anim.To = 150;
            anim.Duration = TimeSpan.FromSeconds(0.2);
            anim.EasingFunction = new QuadraticEase();
            v8.BeginAnimation(WidthProperty, anim);

            if (v7.Width > 0)
            {

                DoubleAnimation anim1 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v7.BeginAnimation(WidthProperty, anim);
            }
            else if (v9.Width > 0)
            {
                DoubleAnimation anim2 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v9.BeginAnimation(WidthProperty, anim);
            }
        }
        private void b9_Click(object sender, RoutedEventArgs e)
        {
            t3tb1.IsChecked = (false);
            t3tb2.IsChecked = (false);
            t3tb3.IsChecked = (true);

            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 0;
            anim.To = 150;
            anim.Duration = TimeSpan.FromSeconds(0.2);
            anim.EasingFunction = new QuadraticEase();
            v9.BeginAnimation(WidthProperty, anim);

            if (v8.Width > 0)
            {

                DoubleAnimation anim1 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v8.BeginAnimation(WidthProperty, anim);
            }
            else if (v7.Width > 0)
            {
                DoubleAnimation anim2 = new DoubleAnimation();
                anim.From = 150;
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.2);
                anim.EasingFunction = new QuadraticEase();
                v7.BeginAnimation(WidthProperty, anim);
            }
        }
    }
}
