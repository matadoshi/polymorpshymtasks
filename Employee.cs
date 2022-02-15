using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphysmTask1
{
    class Employee
    {
        private readonly int counter = 0;
        public int No;

        public string FullName;
        public int Salary;
        public string Position;

        public Employee(string fullname, int salary, string position)
        {

            FullName = fullname;
            Salary = salary;
            Position = position;
            counter++;
            No = counter;

        }



    }
}
