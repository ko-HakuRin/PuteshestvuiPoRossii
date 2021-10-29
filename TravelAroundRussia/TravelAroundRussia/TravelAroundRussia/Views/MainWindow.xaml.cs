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

namespace TravelAroundRussia.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenAuthWindow_Click(object sender, RoutedEventArgs e)
        {
            new AuthWindow().ShowDialog();
        }

        private void OpenToursWindow_Click(object sender, RoutedEventArgs e)
        {
            new ToursWindow().ShowDialog();

        }

        private void OpenHotelsWindow_Click(object sender, RoutedEventArgs e)
        {
            new HotelsWindow().ShowDialog();

        }

        private void OpenHotelInfo_Click(object sender, RoutedEventArgs e)
        {
            new HotelInfoWindow().ShowDialog();

        }
    }
}
