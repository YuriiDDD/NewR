using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task11_new
{
    class FileSearch
    {

        public static void FileSearchByMask (string Path, string Mask)
        {
           
            //Список всех файлов с искомой маской

            string[] Files = null ;

            try
            {
                // Получаем список файлов
                Files = Directory.GetFiles(Path, Mask, SearchOption.AllDirectories);
            }
            catch
            {
               

            }

            Console.WriteLine("Search parameters: " + Path + Mask);
            PrintFiles(Files);


        }
        public static void FileSearchByMask(object x)
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            
            SearchInfoForThread Info = (SearchInfoForThread) x;
            Console.WriteLine(Info.Mask);
            string[] Files = null;

            try
            {
                // Получаем список файлов
                Files = Directory.GetFiles(Info.Path, Info.Mask, SearchOption.AllDirectories);
            }
            catch
            {
                

            }

            PrintFiles(Files);
         


        }



        public static void PrintFiles(string[] Files)
        {
            if (Files.Length > 0)
            {
                foreach (string f in Files)
                    Console.WriteLine(f);
            }
            else
            {
                Console.WriteLine("Nothing found");
            }
        
        }


    }
}
