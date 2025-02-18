﻿namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicity Typed Local Variable [var, dynamic]
            #region Var
            //var Name = "Ahmed";
            //Compiler will detect the variable data type
            //with initialize value in this variable
            //var Name02; //Invalid
            //var Name03 = null; //Invalid
            //Name = null; //valid
            #endregion

            #region Dynamic
            //dynamic name = "Ahmed";
            //name = 10;
            //name = true;

            //dynamic X; // not must be initialize
            //dynamic y = null; // can be initialize with null
            //CLR will detect the variable datatype
            //Based on it's last assigned value in runtime
            #endregion

            #endregion

            #region Extension Method
            int X = 123;
            //int Y = IntExtensions.Reverse(X);
            //Console.WriteLine(Y);

            //int y = X.Reverse();

            //long Y = X.Reverse();
            #endregion

            #region Anonymous Type
            //Employee employee = new Employee() { Id = 10, Name = "Ahmed", Salary = 10000 };
            var employee = new { Id = 10, Name = "Ahmed", Salary = 10000 }; //Anonymous Type 
            
            Console.WriteLine(employee.Id);
            Console.WriteLine(employee);
            //Console.WriteLine(employee.Age); //Invalid
            Console.WriteLine(employee.GetType().Name);
            //employee.Id = 10; //Invalid
            employee = new { Id = 20, employee.Name, employee.Salary };
            employee = employee with { Id = 30 };
            var employee02 = new { Id = 90, Name = "Amr", Salary = 100000 }; //Anonymous Type
            Console.WriteLine(employee02.GetType().Name);
            #endregion
        }
    }
}
