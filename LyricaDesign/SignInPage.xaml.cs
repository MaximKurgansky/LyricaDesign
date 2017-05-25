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
using System.IO;

namespace LyricaDesign
{
    /// <summary>
    /// Логика взаимодействия для SignInPage.xaml
    /// </summary>
    public partial class SignInPage : Page
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void SignInPageSignInButton_Click(object sender, RoutedEventArgs e)
        {
            User[] userlist = UserSerialization.Deserialize();
            bool found = false;
            foreach (User user in userlist)
            {
                if (user.Login == SignInPageLoginTextBox.Text && user.Password == SignInPagePasswordPasswordBox.Password)
                {
                    NavigationService.Navigate(Pages.SearchPage);
                    MainWindow.is_signedin = true;
                    found = true;
                }
            }
            if (!found)
            {
                MessageBox.Show("Incorrect login or password or user doesn't exist");
            }
        }

        private void SignInPageLabelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoadPage());
        }

        private void SignInPageCreateNewAccountButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateAccountPage());
        }

        private void SignInPageSignInButton_Enter(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyenter = new FontFamily("Jokerman");
            SignInPageSignInButton.FontFamily = fontfamilyenter;
        }

        private void SignInPageSignInButton_Leave(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyleave = new FontFamily("AR CARTER");
            SignInPageSignInButton.FontFamily = fontfamilyleave;
        }
    }
}
