using System;

namespace PolymorphysmTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region Task1


            //Car car = new Car("Onur","Sari",15.2,100,60,20);

            //car.ShowInfo();
            //car.Drive(3);

            //Bycle byc = new Bycle("Honda", "CH-R", 15.2);
            //byc.ShowInfo();
            //#endregion
            #region Task2



            //Employee emp1 = new Employee("Onur Ismailov", 2000, "Programmer");
            //Employee emp2 = new Employee("Onur Ismailov", 2000, "Programmer");
            //Employee emp3 = new Employee("Onur Ismailov", 2000, "Programmer");
            //Employee emp4 = new Employee("Tural Aliyev", 2000, "Programmer");
            //Employee emp5 = new Employee("Tural Aliyev", 2000, "Programmer");
            //Employee emp6 = new Employee("Tural Aliyev", 2000, "Programmer");

            //Company comp = new Company("Linux", 5);

            //Company.AddEmploye(emp1);
            //Company.AddEmploye(emp2);
            //Company.AddEmploye(emp3);
            //Company.AddEmploye(emp4);
            //Company.AddEmploye(emp5);
            //Company.AddEmploye(emp6);

            //Employee[] arr = comp.GetEmploye();
            //Print(arr);


            //static void Print(Employee[] arr)
            //{
            //    foreach (var item in arr)
            //    {
            //        Console.Write($"No - {item.No}\nName - {item.FullName}\nSalary - {item.Salary}\nPosition {item.Position}\n");
            //    }
            //}








            #endregion
            #region Task3

            User user = new User("Onur Ismailov", "onurtis@code.edu.az", "King1234");
            user.ShowInfo();

            #endregion


        }
    }

}
