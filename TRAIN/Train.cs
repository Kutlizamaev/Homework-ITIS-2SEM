using System;
using System.IO;
using System.Text.RegularExpressions;

namespace TRAIN
{
    class Train
    {
        public string nameTrain;
        public string pointOfDeparture;
        public string arrivalPoint;
        public string timeDep;
        public string timeArr;
        public string[] coaches;

        public Train(string name, string[] c, string pointOfDep, string arrPoint,string timeD,string timeA)
        {
            nameTrain = name;
            pointOfDeparture = pointOfDep;
            arrivalPoint = arrPoint;
            coaches = c;
            timeDep = timeD;
            timeArr = timeA;
        }

        public static void Information(Train a) 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Поезд {a.nameTrain} отправляется из {a.pointOfDeparture} в {a.arrivalPoint}.\n");
            Console.Write($"Время отправления: {a.timeDep}. Примерное время прибытия: {a.timeArr}.\n");
            Console.Write(WorkWithInformation.Timing(a.timeDep, a.timeArr));
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
