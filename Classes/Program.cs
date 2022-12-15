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


            Car myCar = new Car();
            myCar.Year = 2001;
            myCar.Make = "Chevy";
            myCar.Model = "Impala";


            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "300zx",
                Year = 2023,
            };

            var chevy = new Car("Chevy", "Impala", 2001);

            var carList = new List<Car>() { myCar, mazda, chevy };

            foreach (var car in carList) // I think this is the problem.!!!!!!!
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
                Console.WriteLine();
            }



        }
    }
}
