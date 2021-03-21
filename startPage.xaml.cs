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

namespace expand
{
    /// <summary>
    /// Логика взаимодействия для startPage.xaml
    /// </summary>
    public partial class startPage : Page
    {
        public startPage()
        {
            InitializeComponent();
        }

        private void Cards_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new selectPage("cards"));
        }

        private void Translate_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new selectPage("translate"));
        }

        private void TrueOrFalse_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new selectPage("trueOrFalse"));
        }

        private void PutACouple_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new selectPage("putACouple"));
        }
    }
}
