using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;

namespace CarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars myCars = new Cars();
            myCars.Drive();
            myCars.Stop();
            myCars.Appearance();
        }
    }
}

