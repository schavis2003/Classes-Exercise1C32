using System.Xml.Schema;

namespace Classes
{
    public class Program
    {
        private static string makeInput;
        private static string modelInput;
        private static string yearInput;

        public static IEnumerable<string> car { get; private set; }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            Car myCar = new Car(makeInput, modelInput, yearInput);
            {
                myCar.Make = "GMC";
                myCar.Model = "Denali";
                myCar.Year = 2023;
            }

            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "300zx",
                Year = 2023,
            };

            var chevy = new Car($"Chevy, Impala, 2001");

            var carLIst = new List<Car>() { myCar, mazda, chevy };

            foreach (string car in car)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }



        }
    }
}
