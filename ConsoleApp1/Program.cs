namespace ConsoleApp1
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

            #region LINQ
            //Stands For Language Integrated Query
            // +40 Extension Methods
            //Extension methods for built in interface [IEnumerable]
            //found at class [Enumerable]
            //you can use "linq operations" against data [stored in sequence]
            //regardless the source of data [SQL, Oracle, MySQL]
            #region Sequence
            //the object from class that implement built in interface [IEnumerable]
            //1. Local [static L2O, XML L2Xml]
            //2. Remote [from database L2EF]

            #endregion

            List <int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var oddNumber = Numbers.Where(N => N % 2 == 1);

            foreach (var number in oddNumber)
            {
                Console.WriteLine(number);
            }
            #endregion

            #region LINQ Syntax
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //1. Fluent Syntax
            //1.1 use linq operator as => static method through "Enumerable" class 
            var OddNum = Enumerable.Where(numbers, N => N % 2 != 0);

            //1.2 use linq operator as => Extension method
            OddNum = numbers.Where(N => N % 2 != 0);

            //2. Query Syntax
            oddNumber = from N in numbers where N % 2 != 0 select N;
            foreach (var number in OddNum)
            {
                Console.WriteLine(number);
            }

            #endregion

            #region LINQ Excution Way
            #region Deffered Execution
            List<int> Nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var OddNumbers = Enumerable.Where(numbers, N => N % 2 != 0);
            Numbers.AddRange(new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, });
            foreach (var number in Numbers)
            {
                Console.WriteLine(number);
            }
            #endregion

            #region Immediate Execution
            List<int> Nums1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var OddNumbers1 = Enumerable.Where(numbers, N => N % 2 != 0).ToList();
            Numbers.AddRange(new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, });
            foreach (var number in Numbers)
            {
                Console.WriteLine(number);
            }
            #endregion
            #endregion
        }
    }
}
