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
        public string[] Photo { get; set; }
        public string[] Names { get; set; }
        public translatePage(string[] photo, string[] names)
        {
            
            InitializeComponent();
            //this.Theme = theme;
            this.Photo = photo;
            this.Names = names;
           

            image.Source = new BitmapImage(new Uri(Photo[i], UriKind.Relative));
        }
       
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Answer.Text.Trim() == Names[i])
                {
                    MessageBox.Show("All right!");
                }
                else
                {
                    string rightanswer = "No!\nRight answer: " + Names[i];
                    MessageBox.Show(rightanswer);
                }
                i++;
                Answer.Clear();
                if (i != Names.Length - 1) image.Source = new BitmapImage(new Uri(Photo[i], UriKind.Relative));
                else
                {
                    MessageBox.Show("Все!");
                    NavigationService.Navigate(new startPage());
                }
            }
        }

       
    }
}
