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
    /// Логика взаимодействия для cardsPage.xaml
    /// </summary>
    public partial class cardsPage : Page
    {
        string[] sourses = { "image/apple.jpg", "image/banana.jpg", "image/fruit.jpg", "image/kivi.jpg", "image/pineapple.jpg", "image/melon.jpg", "image/tomato.jpg",
                             "image/pumpkin.jpg", "image/pea.jpg", "image/lime.jpg", "image/corn.jpg", "image/cherry.jpg", "image/carrot.jpg"};
        string[] names = { "apple", "banana", "fruit", "kiwi", "pineapple", "melon", "tomato", "pumpkin", "pea", "lime", "corn", "cherry", "carrot"};
        int number = 1;
        public cardsPage(string theme)
        {
            InitializeComponent();

            myImage.Source = new BitmapImage(new Uri(sourses[0], UriKind.Relative));

            nextImage.Source = new BitmapImage(new Uri("image/next.png", UriKind.Relative));
            backImage.Source = new BitmapImage(new Uri("image/back.png", UriKind.Relative));

            ImageText.Text = names[0];
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            
            myImage.Source = new BitmapImage(new Uri(sourses[number], UriKind.Relative));
            ImageText.Text = names[number];
            number++;
            if (number >= sourses.Length) number = 0;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (number == 0) number = sourses.Length - 1;
            else --number;
            myImage.Source = new BitmapImage(new Uri(sourses[number], UriKind.Relative));
            ImageText.Text = names[number];
        }
    }
}
