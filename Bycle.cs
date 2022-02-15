using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphysmTask1
{
    class Bycle : Vehicle
    {

        public Bycle(string brand,string color,double millage):base(brand,color,millage)
        {

        }
        public override void Drive(double a)
        {
            Millage += (int)a;
        }
        public override void ShowInfo()
        {
            Console.Write("\nIt is a Bycle Info:\n");
            base.ShowInfo();
            Console.WriteLine();
        }



        }
}
