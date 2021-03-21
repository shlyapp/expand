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
    /// Логика взаимодействия для selectPage.xaml
    /// </summary>
    public partial class selectPage : Page
    {
        string nextpage;

        string 
        public selectPage(string nextPage)
        {
            InitializeComponent();
            nextpage = nextPage;
        }

        private void animals_Click(object sender, RoutedEventArgs e)
        {
            if (nextpage == "cards") NavigationService.Navigate(new cardsPage("animals"));
            if (nextpage == "translate") NavigationService.Navigate(new translatePage("animals"));
            if (nextpage == "trueOrFalse") NavigationService.Navigate(new trueOrFalsePage("animals"));
            if (nextpage == "putACouple") NavigationService.Navigate(new putACouplePage("animals"));
        }

        private void fruit_Click(object sender, RoutedEventArgs e)
        {
            if (nextpage == "cards") NavigationService.Navigate(new cardsPage("fruit"));
            if (nextpage == "translate") NavigationService.Navigate(new translatePage("fruit"));
            if (nextpage == "trueOrFalse") NavigationService.Navigate(new trueOrFalsePage("fruit"));
            if (nextpage == "putACouple") NavigationService.Navigate(new putACouplePage("fruit"));
        }

        private void school_Click(object sender, RoutedEventArgs e)
        {
            if (nextpage == "cards") NavigationService.Navigate(new cardsPage("school"));
            if (nextpage == "translate") NavigationService.Navigate(new translatePage("school"));
            if (nextpage == "trueOrFalse") NavigationService.Navigate(new trueOrFalsePage("school"));
            if (nextpage == "putACouple") NavigationService.Navigate(new putACouplePage("school"));
        }

        private void music_Click(object sender, RoutedEventArgs e)
        {
            if (nextpage == "cards") NavigationService.Navigate(new cardsPage("music"));
            if (nextpage == "translate") NavigationService.Navigate(new translatePage("music"));
            if (nextpage == "trueOrFalse") NavigationService.Navigate(new trueOrFalsePage("music"));
            if (nextpage == "putACouple") NavigationService.Navigate(new putACouplePage("music"));
        }
    }
}
