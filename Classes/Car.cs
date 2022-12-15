using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //Constructors
    public class Car //  a special member method that has the same as its class
    {
        private string makeInput;
        private string modelInput;
        private string yearInput;
        private string v;

        public Car()
        {
        }


        public Car(string makeInput, string modelInput, int yearInput)
        {
            Make = makeInput;
            Model = modelInput;
            Year = yearInput;
        }



        //Create a Make property of type string that is public
        public string Make { get; set; } //get = read   set = write

        //Create a Model property of type string that is public
        public string Model { get; set; }

        //Create a Year property of type int that is public
        public int Year { get; set; }

        //Create a bool statement if the care is driveable or not.
        public bool IsDrivable { get; set; } = true;




    }


}
