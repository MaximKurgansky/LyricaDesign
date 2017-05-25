using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace LyricaDesign
{
    class UserSerialization
    {
        public static void Serialize(User[] list)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }

        public static User[] Deserialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                return (User[])formatter.Deserialize(fs);
            }
        }
    }
}
