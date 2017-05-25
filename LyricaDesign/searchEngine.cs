using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyricaDesign
{
    class searchEngine
    {
        public static List<LyricData> search(List<LyricData> list, string searchtype, string search)
        {
            List<LyricData> resultlist = new List<LyricData>();
            foreach (LyricData song in list)
            {
                switch (searchtype)
                {
                    case "Title":
                        if (song.Title.Contains(search))
                        {
                            resultlist.Add(song);
                        }; break;
                    case "Author":
                        if (song.Author.Contains(search))
                        {
                            resultlist.Add(song);
                        }; break;
                    case "Genre":
                        if (song.Genre.Contains(search))
                        {
                            resultlist.Add(song);
                        }; break;
                    case "Lyrics":
                        foreach (string line in song.Lyrics)
                        {
                            if (line.Contains(search))
                            {
                                resultlist.Add(song);
                                break;
                            }
                        }; break;
                    default: break;
                }
            }
            return resultlist;
        }
    }
}
