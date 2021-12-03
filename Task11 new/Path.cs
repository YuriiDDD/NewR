using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_new
{
    public static class Path
    {
        public static List<string> Paths = new List<string>();

        public static void AddPath(string mask)
        {
            if (!Paths.Contains(mask))
                Paths.Add(mask);

        }
        public static void DeletePath(string mask)
        {
            if (Paths.Contains(mask))
                Paths.Remove(mask);

        }

        public static void PrintPaths()
        {
            if (Paths.Count > 0)
                foreach (string m in Paths)
                {
                    Console.WriteLine(m);

                }

        }

        public static void Init()
        {
            //Paths.Add(@"C:\Users\3213897\source\repos\12");
            Paths.Add(@"C:\Users\3213897\OneDrive - Jabil");

        }
    }
}
