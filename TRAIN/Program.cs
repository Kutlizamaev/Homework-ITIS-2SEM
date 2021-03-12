using System;

namespace TRAIN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Введите количество поездов: ");
            int countTrain = Convert.ToInt32(Console.ReadLine());
            Index trains = new Index(countTrain);

            for (int i = 0; i < countTrain; i++)
            {
                Console.Clear();
                Console.Write("Введите название поезда: ");
                string nameTrain = Console.ReadLine();
                Console.Write("Введите количество вагонов: ");
                int countCoaches = Convert.ToInt32(Console.ReadLine());
                string[] coaches = new string[countCoaches]; 
                Console.Write("Введите точку отправления: ");
                string pointOfDeparture = Console.ReadLine();
                Console.Write("Введите точку прибытия: ");
                string arrivalPoint = Console.ReadLine();
                Console.Write("Время отправления: ");
                string timeDep = Console.ReadLine();
                Console.Write("Время прибытия: ");
                string timeArr = Console.ReadLine();

                for (int j = 0; j < countCoaches; j++)
                {
                    Console.Write($"Введите название {j+1} вагона: ");
                    coaches[j] = Console.ReadLine();
                }

                trains[i] = new Train(nameTrain, coaches, pointOfDeparture, arrivalPoint, timeDep, timeArr);
            }

            Console.Clear();
            Console.Write($"Какой из {countTrain} поездов вас интересует: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Train.Information(trains[n - 1]);
        }
    }
}
