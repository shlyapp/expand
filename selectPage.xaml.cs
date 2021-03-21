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

        // source files

        string[] photoFilesAnimals = { "image/animals/cat.jpg", "image/animals/cow.jpg", "image/animals/dog.jpg", "image/animals/elephant.jpg", "image/animals/fish.jpg",
        "image/animals/hamster.jpg", "image/animals/horse.jpg", "image/animals/mouse.jpg", "image/animals/pig.jpg", "image/animals/sheep.jpg", "image/animals/wolf.jpg"};
        string[] namesAnimals = { "cat", "cow", "dog", "elephant", "fish", "hamster", "horse", "mouse", "pig", "sheep", "wolf"};

        string[] photoFilesFruit = { "image/apple.jpg", "image/banana.jpg", "image/fruit.jpg", "image/kivi.jpg", "image/pineapple.jpg", "image/melon.jpg", "image/tomato.jpg",
        "image/pumpkin.jpg", "image/pea.jpg", "image/lime.jpg", "image/corn.jpg", "image/cherry.jpg", "image/carrot.jpg" };
        string[] namesFruit = { "apple", "banana", "fruit", "kiwi", "pineapple", "melon", "tomato", "pumpkin", "pea", "lime", "corn", "cherry", "carrot" };

        string[] photoFilesSchool = { };
        string[] namesSchool = { };

        string[] photoFilesMusic = { };
        string[] namesMusic = { };

        public selectPage(string nextPage)
        {
            InitializeComponent();
            nextpage = nextPage;
        }

        private void animals_Click(object sender, RoutedEventArgs e)
        {
            if (nextpage == "cards") NavigationService.Navigate(new cardsPage("animals"));
            if (nextpage == "translate") NavigationService.Navigate(new translatePage(photoFilesAnimals, namesAnimals));
            if (nextpage == "trueOrFalse") NavigationService.Navigate(new trueOrFalsePage("animals"));
            if (nextpage == "putACouple") NavigationService.Navigate(new putACouplePage("animals"));
        }

        private void fruit_Click(object sender, RoutedEventArgs e)
        {
            if (nextpage == "cards") NavigationService.Navigate(new cardsPage("fruit"));
            if (nextpage == "translate") NavigationService.Navigate(new translatePage(photoFilesFruit, namesFruit));
            if (nextpage == "trueOrFalse") NavigationService.Navigate(new trueOrFalsePage("fruit"));
            if (nextpage == "putACouple") NavigationService.Navigate(new putACouplePage("fruit"));
        }

        private void school_Click(object sender, RoutedEventArgs e)
        {
            if (nextpage == "cards") NavigationService.Navigate(new cardsPage("school"));
            if (nextpage == "translate") NavigationService.Navigate(new translatePage(photoFilesSchool, namesSchool));
            if (nextpage == "trueOrFalse") NavigationService.Navigate(new trueOrFalsePage("school"));
            if (nextpage == "putACouple") NavigationService.Navigate(new putACouplePage("school"));
        }

        private void music_Click(object sender, RoutedEventArgs e)
        {
            if (nextpage == "cards") NavigationService.Navigate(new cardsPage("music"));
            if (nextpage == "translate") NavigationService.Navigate(new translatePage(photoFilesMusic, namesMusic));
            if (nextpage == "trueOrFalse") NavigationService.Navigate(new trueOrFalsePage("music"));
            if (nextpage == "putACouple") NavigationService.Navigate(new putACouplePage("music"));
        }
    }
}
