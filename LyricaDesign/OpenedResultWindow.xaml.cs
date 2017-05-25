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
    /// Логика взаимодействия для OpenedResultWindow.xaml
    /// </summary>
    public partial class OpenedResultWindow : Window
    {
        int code;
        public OpenedResultWindow(int _code)
        {
            InitializeComponent();
            code = _code;
            LyricData song = new LyricData(_code);
            OpenedResultWindowTitlelistBox.Items.Add(song.Title);
            OpenedResultWindowAuthorlistBox.Items.Add(song.Author);
            OpenedResultWindowGenrelistBox.Items.Add(song.Genre);
            foreach (String line in song.Lyrics)
            {
                OpenedResultWindowLyricsListBox.Items.Add(line);
            }
            foreach(String line in song.TranslateLyrics)
            {
                OpenedResultWindowTranslationListBox.Items.Add(line);
            }
            
        }

        private void OpenedResultWindowEditButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.is_signedin)
            {
                EditingTextWindow editingtextwin = new EditingTextWindow(code);
                editingtextwin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Edit function is not available for not signed in users\nSign in to be able to use this function");
            }
        }

        private void SearchPageLabelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OpenedResultWindowEditButton_Enter(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyenter = new FontFamily("Jokerman");
            OpenedResultWindowEditButton.FontFamily = fontfamilyenter;
        }

        private void OpenedResultWindowEditButton_Leave(object sender, MouseEventArgs e)
        {
            FontFamily fontfamilyleave = new FontFamily("AR CARTER");
            OpenedResultWindowEditButton.FontFamily = fontfamilyleave;
        }
    }
}
