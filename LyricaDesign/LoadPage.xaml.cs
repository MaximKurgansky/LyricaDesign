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

namespace LyricaDesign
{
    /// <summary>
    /// Логика взаимодействия для LoadPage.xaml
    /// </summary>
    public partial class LoadPage : Page
    {
        public LoadPage()
        {
            InitializeComponent();
        }

        private void LoadPageStartButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SearchPage());
        }

        private void LoadPageSignInButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignInPage());
        }

        private void LoadPageStartButton_MouseEnter(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyenter = new FontFamily("Jokerman");
            LoadPageStartButton.FontFamily = fontfamilyenter;
        }

        private void LoadPageStartButton_MouseLeave(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyleave = new FontFamily("AR CARTER");
            LoadPageStartButton.FontFamily = fontfamilyleave; 
            
        }

        private void LoadPageSignInButton_Enter(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyenter = new FontFamily("Jokerman");
            LoadPageSignInButton.FontFamily = fontfamilyenter;
        }

        private void LoadPageSignInButton_Leave(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyleave = new FontFamily("AR CARTER");
            LoadPageSignInButton.FontFamily = fontfamilyleave;
        }
    }
}
