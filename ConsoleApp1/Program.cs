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
            

        }
    }
}
