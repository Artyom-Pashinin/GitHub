using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace race
{
    class Car
    {
        public int speed;
        

        public Car()
        {
            speed = Program.r.Next(5, 10);
        }
    }
}
