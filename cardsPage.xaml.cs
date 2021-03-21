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
        string[] Photos;
        string[] Names;

        int number = 0;
        public cardsPage(string[] photo, string[] name)
        {
            InitializeComponent();

            this.Photos = photo;
            this.Names = name;

            nextImage.Source = new BitmapImage(new Uri("image/next.png", UriKind.Relative));
            backImage.Source = new BitmapImage(new Uri("image/back.png", UriKind.Relative));

            myImage.Source = new BitmapImage(new Uri(Photos[number], UriKind.Relative)); 

            ImageText.Text = Names[0];
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            
            
            number++;
            if (number >= Photos.Length) number = 0;
            myImage.Source = new BitmapImage(new Uri(Photos[number], UriKind.Relative));
            ImageText.Text = Photos[number];
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
