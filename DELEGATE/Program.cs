using System;

namespace DELEGATE
{
    class Program
    {
        public static double LengthCircle(double r)
        {
            double length = 2 * Math.PI * r;
            Console.WriteLine($"Длина окружности: {length}");
            return length;
        }

        public static double AreaCircle(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Площадь круга: {area}");
            return area;
        }

        public static double Volume(double r)
        {
            double volume = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Объем шара: {volume}");
            return volume;
        }

        public static int RandomNum()
        {
            Random rndm = new Random();
            return rndm.Next(100);
        }

        delegate double Calculations(double r);
        delegate int RandomInt();
        delegate double AnonimMethod(RandomInt r, RandomInt a, RandomInt b);

        static void Main(string[] args)
        {
            Calculations del = LengthCircle;
            del += AreaCircle;
            del += Volume;
            del(10);

            RandomInt delFirst = RandomNum;
            RandomInt delSecond = RandomNum;
            RandomInt delThird = RandomNum;

            AnonimMethod anonimMethod = delegate(RandomInt delFirst, RandomInt delSecond, RandomInt delThird)
            {
                double a = Convert.ToDouble(delFirst());
                double b = Convert.ToDouble(delFirst());
                double c = Convert.ToDouble(delFirst());
                return (a + b + c) / 3;
            };

            Console.WriteLine("\nСреднее арифметическое 3 чисел: " + anonimMethod(delFirst, delSecond, delThird));
        }
    }
}
