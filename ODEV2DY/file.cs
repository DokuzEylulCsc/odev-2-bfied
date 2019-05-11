using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ODEV2DY
{
    class Dosya
    {
        public static bool universitevarmi()
        {
            if (File.Exists(@".\universite.txt")) return true;
            else return false;
        }

        public static int satirsayisi(string a)
        {
            int say = 0;
            using (StreamReader sr = new StreamReader(a))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    say += 1;
                }
            }
            return say;
        }

        public static string[] oku(string a)
        {
            int say = satirsayisi(a);
            string[] array = new string[say];
            using (StreamReader sr = new StreamReader(a))
            {
                for(int i=0;i<say;i++)
                {
                    array[i] = sr.ReadLine();
                }
            }
            return array;
        }

        public static void yaz(string a, string b)
        {
            StreamWriter Yaz = new StreamWriter(b, append: true);
            Yaz.WriteLine(a);
            Yaz.Close();
        }

        public static void ustuneyaz(string a, string b)
        {
            StreamWriter Yaz = new StreamWriter(b, append: false);
            Yaz.WriteLine(a);
            Yaz.Close();
        }



    }
}
