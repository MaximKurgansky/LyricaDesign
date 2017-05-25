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
    /// Логика взаимодействия для CreateAccountPage.xaml
    /// </summary>
    public partial class CreateAccountPage : Page
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        private void CreateAccountPageLabelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoadPage());
        }

        private void CreteAccountPageCreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            User[] userlist = UserSerialization.Deserialize();
            if (Auth_Checker.is_logincorrect(CreateAccountPageLoginTextBox.Text) && Auth_Checker.is_passcorrect(CreateAccountPagePasswordTextBox.Text))
            {
                MessageBox.Show("User created");
                Array.Resize(ref userlist, userlist.Length + 1);
                userlist[userlist.Length-1] = new User(CreateAccountPageLoginTextBox.Text, CreateAccountPagePasswordTextBox.Text);
                UserSerialization.Serialize(userlist);
                NavigationService.Navigate(new SignInPage());
            }
            else
            {
                MessageBox.Show("Wrong login or password format\nLogin must be at least 4 characters\nPassword must be at least 6 characters and have at least 1 digit");
            }
            
        }

        private void CreateAccountPageCreateAccountButton_Enter(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyenter = new FontFamily("Jokerman");
            CreateAccountPageCreateAccountButton.FontFamily = fontfamilyenter;
            CreateAccountPageCreateAccountButton.FontSize = 33;
        }

        private void CreateAccountPageCreateAccountButton_Leave(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyleave = new FontFamily("AR CARTER");
            CreateAccountPageCreateAccountButton.FontFamily = fontfamilyleave;
            CreateAccountPageCreateAccountButton.FontSize = 48;
        }
    }
}
