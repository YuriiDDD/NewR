using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_new
{
    public static class Mask
    {
        public static List<string> Masks = new();

        public static void AddMask(string mask)
        {
            if (!Masks.Contains(mask))
                Masks.Add(mask);

        }
        public static void DeleteMask(string mask)
        {
            if (Masks.Contains(mask))
                Masks.Remove(mask);

        }

        public static void PrintMasks()
        {
            if (Masks.Count > 0)
                foreach (string m in Masks)
                {
                    Console.WriteLine(m);

                }

        }
        public static void Init()

        {
           
            Masks.Add("*.doc");
            Masks.Add("*.txt");
            Masks.Add("*.docx");


        }

       
    }
}
