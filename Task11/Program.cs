using System;
using System.Collections.Generic;
using System.Threading;

namespace Task11
{
    class Program
    {

        

       
        static void Main(string[] args)
        {
                        // создаем новый поток
            Thread myThread = new Thread(new ThreadStart(Count));
           

            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Главный поток:");
                Console.WriteLine(i * i);
                if (i * i > 20)
                {
                    if (!myThread.IsAlive) myThread.Start(); // запускаем поток
                }

                Thread.Sleep(300);
            }

            Console.ReadLine();
           
        }

        public static void Count()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Второй поток:");
                Console.WriteLine(i * i);
                Thread.Sleep(400);
            }
            Console.WriteLine("Второй поток завершил работу:");
        }

       

    }
}
