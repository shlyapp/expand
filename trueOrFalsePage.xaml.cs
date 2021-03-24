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
    /// Логика взаимодействия для trueOrFalsePage.xaml
    /// </summary>
    public partial class trueOrFalsePage : Page
    {
        public string[] Photos { get; set; }

        public string[] Names { get; set; }

        int number = 1;

        public trueOrFalsePage(string[] photo, string[] names)
        {
            InitializeComponent();
            this.Photos = photo;
            this.Names = names;

            image.Source = new BitmapImage(new Uri(Photos[0], UriKind.Relative));
            text.Text = "this is " + Names[0] + " ?";
        }

        private void false_Click(object sender, RoutedEventArgs e)
        {
            image.Source = new BitmapImage(new Uri(Photos[number], UriKind.Relative));
            text.Text = "this is " + Names[number] + " ?";
            number++;
        }

        private void true_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
