using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LyricaDesign
{
    class LyricDataReadWrite
    {
        public static void ReadFile(List<LyricData> list)
        {
            StreamReader lyricdatasr = new StreamReader("lyricdata.txt");
            while (!lyricdatasr.EndOfStream)
            {
                string[] read = lyricdatasr.ReadLine().Split('#');
                list.Add(new LyricData(int.Parse(read[0]), read[1], read[2], read[3]));
            }
            lyricdatasr.Close();
        }

        public static void WriteFile(List<LyricData> list)
        {
            StreamWriter lyricdatasw = new StreamWriter(new FileStream("lyricdata.txt", FileMode.Open, FileAccess.ReadWrite));
            foreach (LyricData lyricdata in list)
            {
                lyricdatasw.WriteLine(lyricdata.printtofile());
            }
            lyricdatasw.Close();
        }
    }
}
