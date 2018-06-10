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

namespace Kalendarz
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        DateTime thisMonth = DateTime.Today;
        int m = 0;

        public MainWindow()
        {

            InitializeComponent();

            month1.Content = thisMonth.ToString("y");

            TextBlock[] days = new TextBlock[31];

            int daysInMonth = 31;
            int k = 1;

            for (int i = 0; i < daysInMonth; i++)
            {

                for (int j = 0; j < 7; j++)
                {
                    days[i] = new TextBlock();
                    days[i].Text = Convert.ToString(i + 1);
                    days[i].TextAlignment = TextAlignment.Center;
                    days[i].VerticalAlignment = VerticalAlignment.Center;
                    gridCalendar.Children.Add(days[i]);
                    Grid.SetColumn(days[i], j);
                    Grid.SetRow(days[i], k + 1);

                    i++;
                }
                k++;
            }
        }

        private void Lewo(object sender, RoutedEventArgs e)
        {

            m--;
            month1.Content = thisMonth.AddMonths(m).ToString("y");


        }

        private void Prawo(object sender, RoutedEventArgs e)
        {

            m++;
            month1.Content = thisMonth.AddMonths(m).ToString("y");

        }
    }
}