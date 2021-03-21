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
    
    public partial class translatePage : Page
    {
        int i = 0;
        //public string Theme { get; set; }
        public string[] Value { get; set; }
        public string[] Source { get; set; }
        public translatePage(string theme)
        {
            
            InitializeComponent();
            //this.Theme = theme;

            if (theme == "fruit")
            {
                this.Source = new string[] {"image/fruit/apple.jpg", "image/fruit/banana.jpg", "image/fruit/fruit.jpg", "image/fruit/kivi.jpg", "image/fruit/pineapple.jpg", "image/fruit/melon.jpg", "image/fruit/tomato.jpg",
                             "image/fruit/pumpkin.jpg", "image/fruit/pea.jpg", "image/fruit/lime.jpg", "image/fruit/corn.jpg", "image/fruit/cherry.jpg", "image/fruit/carrot.jpg"};
                this.Value = new string[] { "apple", "banana", "fruit", "kiwi", "pineapple", "melon", "tomato", "pumpkin", "pea", "lime", "corn", "cherry", "carrot" };
            }
            else if (theme == "animals")
            {
                this.Source = new string[] { };
                this.Value = new string[] { };
            }
            else if (theme == "school")
            {
                this.Source = new string[] { };
                this.Value = new string[] { };
            }
            else if (theme == "music")
            {
                this.Source = new string[] { };
                this.Value = new string[] { };
            }

            image.Source = new BitmapImage(new Uri(Source[i], UriKind.Relative));
        }
       
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Answer.Text.Trim() == Value[i])
                {
                    MessageBox.Show("All right!");
                }
                else
                {
                    string rightanswer = "No!\nRight answer: " + Value[i];
                    MessageBox.Show(rightanswer);
                }
                i++;
                Answer.Clear();
                if (i != Value.Length - 1) image.Source = new BitmapImage(new Uri(Source[i], UriKind.Relative));
                else
                {
                    MessageBox.Show("Все!");
                    NavigationService.Navigate(new startPage());
                }
            }
        }

       
    }
}
