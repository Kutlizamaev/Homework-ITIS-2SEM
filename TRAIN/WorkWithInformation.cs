using System;
using System.Text.RegularExpressions;

namespace TRAIN
{
    class WorkWithInformation
    {
        public static string CauseOfLate()
        {
            Random rndm = new Random();
            int a = rndm.Next(1, 5);
            switch (a)
            {
                case 1: return "Опоздание нескольких пассажиров на поезд.";
                case 2: return "Авария на путях.";
                case 3: return "Отключение электричества.";
                case 4: return "Неисправность в поезде.";
                case 5: return "Пассажир применил стоп-кран.";
                default: return "";
            }

        }

        public static string Timing(string departureTime, string arrivalTime)
        {
            Random rndm = new Random();
            int rndmStart = rndm.Next(4);
            int rndmHour = rndm.Next(1, 24);
            int rndmMinute = rndm.Next(1, 60);

            int hourDep = Convert.ToInt32(departureTime.Remove(2, 3));
            int minuteDep = Convert.ToInt32(departureTime.Remove(0, 3));
            int hourArr = Convert.ToInt32(arrivalTime.Remove(2, 3));
            int minuteArr = Convert.ToInt32(arrivalTime.Remove(0, 3));

            string travelHour;
            string travelMinute;

            if (hourDep == hourArr && minuteDep == minuteArr)
            {
                travelHour = 24.ToString();
                travelMinute = 00.ToString();
            }

            if (hourArr == hourDep && minuteArr > minuteDep)
            {
                travelHour = 24.ToString();
                travelMinute = (minuteArr - minuteDep).ToString();
            }

            if (hourArr == hourDep && minuteArr < minuteDep)
            {
                travelHour = 23.ToString();
                travelMinute = (60 - minuteDep + minuteArr).ToString();
            }

            if (hourArr != hourDep && minuteDep > minuteArr)
            {
                travelHour = hourDep > hourArr ? (24 - hourDep + hourArr - 1).ToString() : (hourArr - hourDep - 1).ToString();
                travelMinute = (60 - minuteDep + minuteArr).ToString();
            }

            else
            {
                travelHour = hourDep > hourArr ? (24 - hourDep + hourArr).ToString() : (hourArr - hourDep).ToString();
                travelMinute = (minuteArr - minuteDep).ToString();
            }

            if (rndmStart == 2)
            {
                string causeLate = WorkWithInformation.CauseOfLate();
                travelHour = (rndmHour + hourArr).ToString();
                hourArr = (rndmHour + hourArr) % 24 > 0 ? (rndmHour + hourArr) % 24 : rndmHour + hourArr;
                minuteArr = (rndmMinute + minuteArr) % 60 > 0 ? (rndmMinute + minuteArr) % 60 : rndmMinute + minuteArr;
                if (travelHour.Length==1)
                {
                    travelHour = "0" + travelHour;
                }
                if (travelMinute.Length == 1)
                {
                    travelMinute = "0" + travelMinute;
                }
                return $"Время в пути: {travelHour}:{travelMinute}.\nНовое время прибытия: {hourArr}:{minuteArr}.\nОпоздание на {rndmHour}:{rndmMinute}.\nПричина опоздания: {causeLate}";
            }
            else
            {
                if (travelHour.Length == 1)
                {
                    travelHour = "0" + travelHour;
                }
                if (travelMinute.Length == 1)
                {
                    travelMinute = "0" + travelMinute;
                }
                return $"Время в пути: {travelHour}:{travelMinute}";
            }
        }

        /*public static bool CheckTime(string departureTime, string arrivalTime)
        {
            Regex mask = new Regex(@"([0-1]\d|2[0-4]):[0-5][0-9]");
            if (mask.IsMatch(departureTime) && mask.IsMatch(arrivalTime))
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }*/
    }
}
