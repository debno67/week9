using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Cars
    {
        private string color;
        private bool isConvertible;
        private string model;
        private int speed;

        private string Color
        {

            get { return this.color; }
            set { this.color = value; }

        }

        private bool IsConvertible

        {

            get { return this.isConvertible; }
            set { this.isConvertible = value; }

        }

        private string Model

        {

            get { return this.model; }
            set { this.model = value; }

        }

        private int Speed
 
        {

            get { return this.speed; }
            set { this.speed = value; }

        }

        public Cars()

        {
        

            this.Color = "blue";
            this.IsConvertible = true;
            this.Model = "Altima";
            this.Speed = 60;

        }

        public Cars(string color, bool isConvertible, string model, int speed)

        {

            this.Color = color;
            this.IsConvertible = isConvertible;
            this.Model = model;
            this.Speed = speed;

        }

        public void Drive()

        {

            for (int i = 0; i <= speed; i += 5)
            {


                System.Console.WriteLine(i);
            }

                Console.WriteLine("Vrooommmmm");

        }
            

        public void Stop()
        {
            for (int j = 60; j >= 0; j-=5)
            {
                System.Console.WriteLine(j);

            }

            Console.WriteLine("Screech");

        }
        public void Appearance()
        {

            Console.WriteLine("Your car is" +  " " + color);
            Console.WriteLine("The model is" + " " + model);
        }
    }
}
