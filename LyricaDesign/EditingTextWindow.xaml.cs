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
    /// Логика взаимодействия для EditingTextWindow.xaml
    /// </summary>
    public partial class EditingTextWindow : Window
    {
        int code;
        public EditingTextWindow(int _code)
        {
            InitializeComponent();
            code = _code;
            LyricData song = new LyricData(_code);
            EditingTextWindowTitleTextBox.Text = song.Title;
            EditingTextWindowAuthorTextBox.Text = song.Author;
            EditingTextWindowGenreTextBox.Text = song.Genre;
            EditingTextWindowLyricsTextBox.Clear();
            foreach (String line in song.Lyrics)
            {
                EditingTextWindowLyricsTextBox.AppendText(line);
                EditingTextWindowLyricsTextBox.AppendText("\n");
            }
            foreach (String line in song.TranslateLyrics)
            {
                EditingTextWindowTranslationTextBox.AppendText(line);
                EditingTextWindowTranslationTextBox.AppendText("\n");
            }
        }

        private void EditingTextWindowSaveButton_Enter(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyenter = new FontFamily("Jokerman");
            EditingTextWindowSaveButton.FontFamily = fontfamilyenter;
        }

        private void EditingTextWindowSaveButton_Leave(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyleave = new FontFamily("AR CARTER");
            EditingTextWindowSaveButton.FontFamily = fontfamilyleave;
        }

        private void EditingTextWindowSaveButton_Click(object sender, RoutedEventArgs e)
        {
            List<LyricData> lyricdatalist = new List<LyricData>();
            LyricDataReadWrite.ReadFile(lyricdatalist);
            string[] lyricslist = EditingTextWindowLyricsTextBox.Text.Split('\n');
            string[] translatelyricslist = EditingTextWindowTranslationTextBox.Text.Split('\n');
            CRUD.update_LyricData(code, EditingTextWindowTitleTextBox.Text, EditingTextWindowAuthorTextBox.Text, EditingTextWindowGenreTextBox.Text, lyricslist, translatelyricslist, lyricdatalist);
            LyricDataReadWrite.WriteFile(lyricdatalist);
        }

        private void EditingTextWindowLabelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EditingTextWindowDeleteButton_Enter(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyenter = new FontFamily("Jokerman");
            EditingTextWindowDeleteButton.FontFamily = fontfamilyenter;
        }

        private void EditingTextWindowDeleteButton_Leave(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyleave = new FontFamily("AR CARTER");
            EditingTextWindowDeleteButton.FontFamily = fontfamilyleave;
        }
    }
}
