using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PolymorphysmTask1
{
    class Company
    {

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                while (true)
                {
                    bool checkUpper = false;
                    bool checkLetter = false;
                    bool checkSpace = false;
                    bool checkDigit = false;

                    for (int i = 0; i < value.Length; i++)
                    {
                        if (char.IsUpper(value[i]))
                        {
                            checkUpper = true;
                        }
                        else if (char.IsDigit(value[i]))
                        {
                            checkDigit = true;
                        }
                        else if (char.IsLetter(value[i]))
                        {
                            checkLetter = true;
                        }
                        else if (char.IsWhiteSpace(value[i]))
                        {
                            checkSpace = true;
                        }
                    }
                    if (checkUpper && checkDigit && checkLetter && checkSpace)
                    {
                        _name = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Adi Duzgun Daxil edin");
                        value = Console.ReadLine();
                    }
                }


            }
        }
        public static int Limit;
        public static Employee[] Employe = new Employee[0];
        public Company(string name, int limit)
        {
            this._name = name;
            Limit = limit;

        }
        public static void AddEmploye(Employee arr)
        {
            if (Employe.Length < Limit)
            {
                Array.Resize(ref Employe, Employe.Length + 1);
                Employe[Employe.Length - 1] = arr;

            }
            else
            {
                Console.WriteLine("Yer Doludur");
            }
        }
        public Employee[] GetEmploye()
        {
            return Employe;
        }
        public static Employee SearchEmploye(string search)
        {
            foreach (var item in Employe)
            {
                if (item.FullName == search)
                {
                    return item;
                }
            }
            return new Employee("Not found", 0, "Not Found");
        }

    }
}
