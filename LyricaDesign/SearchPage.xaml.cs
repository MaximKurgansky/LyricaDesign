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
    /// Логика взаимодействия для SearchPage.xaml
    /// </summary>
    /// 
    public partial class SearchPage : Page
    {
        List<LyricData> lyricdatalist = new List<LyricData>();

        public SearchPage()
        {
            InitializeComponent();
            LyricDataReadWrite.ReadFile(lyricdatalist);
        }

        private void SearchPageLabelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.LoadPage);
        }

        private void SearchPageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void SearchPageCreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.is_signedin)
            {
                CreateText createtextwindow = new CreateText();
                createtextwindow.Show();
            }
            else
            {
                MessageBox.Show("Create function is not available for not signed in users\nSign in to be able to use this function");
            }
        }

        private void SearchPageSearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
           
            //foreach (LyricData ld in searchEngine.search(lyricdatalist, SearchPageComboBox.Text , SearchPageSearchTextBox.Text))
            //{
                SearchPageDataGrid.ItemsSource = searchEngine.search(lyricdatalist, SearchPageComboBox.Text, SearchPageSearchTextBox.Text);
            //}
        }

        private void SearchPageOpenButton_Click(object sender, RoutedEventArgs e)
        {
            LyricData song  = (LyricData)SearchPageDataGrid.SelectedItem;
            OpenedResultWindow openedresultwd = new OpenedResultWindow(song.Code);
            openedresultwd.Show();
        }

        private void SearchPageOpenButton_Enter(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyenter = new FontFamily("Jokerman");
            SearchPageOpenButton.FontFamily = fontfamilyenter;
        }

        private void SearchPageOpenButton_Leave(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyleave = new FontFamily("AR CARTER");
            SearchPageOpenButton.FontFamily = fontfamilyleave;
        }

        private void SearchPageCreateButton_Enter(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyenter = new FontFamily("Jokerman");
            SearchPageCreateButton.FontFamily = fontfamilyenter;
        }

        private void SearchPageCreateButton_Leave(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyleave = new FontFamily("AR CARTER");
            SearchPageCreateButton.FontFamily = fontfamilyleave;
        }

        private void SearchPageUpdateButton_Enter(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyenter = new FontFamily("Jokerman");
            SearchPageUpdateButton.FontFamily = fontfamilyenter;
        }

        private void SearchPageUpdateButton_Leave(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyleave = new FontFamily("AR CARTER");
            SearchPageUpdateButton.FontFamily = fontfamilyleave;
        }

        private void SearchPageUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            lyricdatalist.Clear();
            LyricDataReadWrite.ReadFile(lyricdatalist);
        }
    }
}
