using System;
using System.Threading;

namespace Task11_new
{
    class Program
    {
        public static void Print(string[] points, int choose)
        {
            Console.Clear();
            for (int i = 0; i < points.Length; i++)
                Console.WriteLine("{0} {1}", points[i], i == choose ? "<<--" : "");
        }
        public static int Menu(string[] points)
        {

            Console.CursorVisible = false; // Чтобы не было мигающего курсора.
            int choose = 0;
            while (true) // Бесконечный цикл.
            {
                Print(points, choose);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow: choose--; break;
                    case ConsoleKey.DownArrow: choose++; break;

                    case ConsoleKey.Enter: Console.CursorVisible = true; return choose;
                }
                choose = (choose + points.Length) % points.Length; // Зацикливаем выбор.
            }
        }
        static void Main(string[] args)
        {
            Mask.Init();
            Path.Init();

            SearchInfoForThread MyInfo = new SearchInfoForThread();
            int i = 0;
            foreach (string mask in Mask.Masks)
            {
                MyInfo.Mask = mask;
                MyInfo.Path = Path.Paths[0];
                Thread myThread = new Thread(new ParameterizedThreadStart (FileSearch.FileSearchByMask));
                myThread.Name = "Thread " + i.ToString();
                myThread.Start(MyInfo);
                i++;

            }
            
            
            
           // FileSearch.FileSearchByMask(Path.Paths[0].ToString(), Mask.Masks[0].ToString());




            //string[] points = { "1) Добавить маску", "2) Добавить путь поиска", "3) Удалить маску", "4) Удалить путь поиска", "5) Начать поиск", "6) Выход" };
            //int choose = -1;
            //while (choose != 5)
            //{
            //    choose = Menu(points);

            //    Console.WriteLine($"Выбран пункт № { choose + 1}");

            //    switch (choose)
            //    {
            //        // Add Mask
            //        case 0:
            //            Console.WriteLine("Input new mask for search:");
            //            Mask.AddMask(Console.ReadLine());
            //        break;
            //        //Add Path
            //        case 1:

            //            Console.WriteLine("Input new path for search:");
            //            Path.AddPath(Console.ReadLine());                      
            //        break;
            //        //Delete mask
            //        case 2:
            //            Console.WriteLine("Avalaible masks for search:");
            //            Mask.PrintMasks();
            //            Mask.DeleteMask(Console.ReadLine());
            //        break;
            //        //Delete path
            //        case 3:
            //            Console.WriteLine("Avalaible paths for search:");
            //            Path.PrintPaths();
            //            Path.DeletePath(Console.ReadLine());
            //        break;
            //        // Search
            //        case 4:
            //            Console.WriteLine("Start new search");

            //            break;
            //        //Exit
            //        default:

            //            break;
            //    }

            //}


        }
    }
}
