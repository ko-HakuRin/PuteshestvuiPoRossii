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
using System.Windows.Shapes;

namespace TravelAroundRussia.Views
{
    public partial class HotelsWindow : Window
    {
        public HotelsWindow()
        {
            InitializeComponent();
        }

        private void AddHotel_Click(object sender, RoutedEventArgs e)
        {
            new HotelInfoWindow().ShowDialog();
        }

        private void EditHotel_Click(object sender, RoutedEventArgs e)
        {
            new HotelInfoWindow().ShowDialog();
        }
    }
}
