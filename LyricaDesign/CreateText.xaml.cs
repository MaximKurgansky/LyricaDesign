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
using System.Windows.Shapes;

namespace LyricaDesign
{
    /// <summary>
    /// Логика взаимодействия для CreateText.xaml
    /// </summary>
    public partial class CreateText : Window
    {
        public CreateText()
        {
            InitializeComponent();
        }

        private void CreateTextWindowCreateButton_Click(object sender, RoutedEventArgs e)
        {
            List<LyricData> lyricdatalist = new List<LyricData>();
            LyricDataReadWrite.ReadFile(lyricdatalist);
            string[] lyricslist = CreateTextWindowLyricsTextBox.Text.Split('\n');
            string[] translatelyricslist = CreateTextWindowTranslationTextBox.Text.Split('\n');
            CRUD.create_new_LyricData(CreateTextWindowTitleTextBox.Text, CreateTextWindowAuthorTextBox.Text, CreateTextWindowGenreTextBox.Text, lyricslist, translatelyricslist, lyricdatalist);
            LyricDataReadWrite.WriteFile(lyricdatalist);
        }

        private void SearchPageLabelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void CreateTextWindowCreateButton_Enter(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyenter = new FontFamily("Jokerman");
            CreateTextWindowCreateButton.FontFamily = fontfamilyenter;
        }

        private void CreateTextWindowCreateButton_Leave(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyleave = new FontFamily("AR CARTER");
            CreateTextWindowCreateButton.FontFamily = fontfamilyleave;
        }
    }
}
