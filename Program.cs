using System;
using System.Globalization;

namespace Static_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter valeu of ray: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Circunference: {0}", Calculator.Circunference(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: {0}", Calculator.Volume(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI value: {0}", Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}