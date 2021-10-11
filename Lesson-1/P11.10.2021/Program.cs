using System;


namespace P11._10._2021
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "test";
            string b = "TEST";
            if (a.ToUpper()==b)
            {
                Console.WriteLine("beraberdi");
            }
            else
            {
                Console.WriteLine("deyil");
            }


            #region Calculation program
            //Console.WriteLine("Enter the action to");
            //Console.WriteLine("1 for Addition");
            //Console.WriteLine("2 for Subtraction");
            //Console.WriteLine("3 for Multiplication");
            //Console.WriteLine("4 for Division");

            //int action = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter  1st input");
            //int input1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter  2nd input");
            //int input2 = Convert.ToInt32(Console.ReadLine());
            //int result = 0;
            //switch (action)
            //{
            //    case 1:
            //        {
            //            result = Addition(input1, input2);
            //            break;
            //        }
            //    case 2:
            //        {
            //            result = Subtraction(input1, input2);
            //            break;
            //        }
            //    case 3:
            //        {
            //            result = Multiplication(input1, input2);
            //            break;
            //        }
            //    case 4:
            //        {
            //            result = Division(input1, input2);
            //            break;
            //        }
            //    default:
            //        Console.WriteLine("Wrong action! try again");
            //        break;
            //}
            //Console.WriteLine("Result "+result);
            #endregion
        }

        #region Calculation program
        public static int Addition(int input1,int input2)
        {
            int result = input1 + input2;
            return result;
        }

        public static int Subtraction(int input1,int input2)
        {
            int result = input1 - input2;
            return result;
        }
        public static int Multiplication(int input1, int input2)
        {
            int result = input1 * input2;
            return result;
        }
        public static int Division(int input1, int input2)
        {
            int result = input1 / input2;
            return result;
        }
        #endregion
    }
}
