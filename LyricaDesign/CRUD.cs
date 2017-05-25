using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LyricaDesign
{
    class CRUD
    {
        public static void create_new_LyricData(string _title, string _author, string _genre, String[] _lyrics, String[] _transkatekyrics, List<LyricData> list)
        {
            int code = list.Count + 1;
            StreamWriter sw = new StreamWriter(new FileStream((code + ".txt").ToString(), FileMode.OpenOrCreate, FileAccess.Write));
            StreamWriter translatesw = new StreamWriter(new FileStream((code + "translate.txt").ToString(), FileMode.OpenOrCreate, FileAccess.Write));
            foreach (string line in _lyrics)
            {
                sw.WriteLine(line);
            }
            foreach(string tranlateline in _transkatekyrics)
            {
                translatesw.WriteLine(tranlateline);
            }
            sw.Close();
            translatesw.Close();
            list.Add(new LyricData(code, _title, _author, _genre));
        }

        public static LyricData read_lyricdata(int _code)
        {
            StreamReader lyricdatasr = new StreamReader("lyricdata.txt");
            while (!lyricdatasr.EndOfStream)
            {
                string[] read = lyricdatasr.ReadLine().Split('#');
                if (int.Parse(read[0]) == _code)
                {
                    LyricData song = new LyricData(int.Parse(read[0]), read[1], read[2], read[3]);
                    lyricdatasr.Close();
                    return song;
                }
            }
            return new LyricData();
        }

        public static void update_LyricData(int _code, string _title, string _author, string _genre, String[] _lyrics, String[] _translatelyrics, List<LyricData> list)
        {
            list[_code - 1].Title = _title;
            list[_code - 1].Author = _author;
            list[_code - 1].Genre = _genre;
            list[_code - 1].Lyrics.Clear();
            StreamWriter sw = new StreamWriter(new FileStream((_code + ".txt").ToString(), FileMode.OpenOrCreate, FileAccess.Write));
            StreamWriter translatesw = new StreamWriter(new FileStream((_code + "translate.txt").ToString(), FileMode.OpenOrCreate, FileAccess.Write));
            foreach (string line in _lyrics)
            {
                sw.WriteLine(line);
            }
            foreach (string tranlateline in _translatelyrics)
            {
                translatesw.WriteLine(tranlateline);
            }
            sw.Close();
            translatesw.Close();
        }

        public static void delete_LyricData(int _code, List<LyricData> list)
        {
            foreach (LyricData song in list)
            {
                if (song.Code == _code)
                {
                    list.Remove(song);
                }
            }
        }
    }
}
