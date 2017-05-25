using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LyricaDesign
{
    class LyricData
    {
        public int Code { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public List<string> Lyrics;
        public List<string> TranslateLyrics;

        public LyricData() { }

        public LyricData(int _code)
        {
            Code = _code;
            StreamReader sr = new StreamReader("lyricdata.txt");
            while(!sr.EndOfStream)
            {
                string[] input = sr.ReadLine().Split('#');
                if(int.Parse(input[0]) == _code)
                {
                    Title = input[1];
                    Author = input[2];
                    Genre = input[3];
                }
            }
            sr.Close();
            Lyrics = new List<string>();
            TranslateLyrics = new List<string>();
            StreamReader str = new StreamReader((_code + ".txt").ToString());
            StreamReader translatestr = new StreamReader((_code + "translate.txt").ToString());
            while (!str.EndOfStream)
            {
                Lyrics.Add(str.ReadLine());
            }
            while(!translatestr.EndOfStream)
            {
                TranslateLyrics.Add(translatestr.ReadLine());
            }
            str.Close();
            translatestr.Close();
        }

        public LyricData(int _code, string _title, string _author, string _genre)
        {
            Code = _code;
            Title = _title;
            Author = _author;
            Genre = _genre;
            Lyrics = new List<string>();
            StreamReader sr = new StreamReader((_code + ".txt").ToString());
            while (!sr.EndOfStream)
            {
                Lyrics.Add(sr.ReadLine());
            }
            sr.Close();
            TranslateLyrics = new List<string>();
            StreamReader translatestr = new StreamReader((_code + "translate.txt").ToString());
            while (!translatestr.EndOfStream)
            {
                TranslateLyrics.Add(translatestr.ReadLine());
            }
            translatestr.Close();
        }

        public string print()
        {
            return Code + " " + Title + " " + Author + " " + Genre;
        }

        public string printtofile()
        {
            return Code + "#" + Title + "#" + Author + "#" + Genre;
        }

        public string printsearch()
        {
            return Title + " " + Author + " " + Genre;
        }
    }
}
