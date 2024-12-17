using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region string vs StringBuilder
            ////String
            //string str = "hello ";
            //Console.WriteLine(str.GetHashCode());
            //str += "World";
            //Console.WriteLine(str.GetHashCode());

            ////String Builder
            //StringBuilder sb = new StringBuilder("Welcome ");
            //Console.WriteLine(sb.GetHashCode());
            //sb.Append("route");
            //Console.WriteLine(sb.GetHashCode());
            #endregion

            #region one D array
            //int[] arr1 = new int[5];
            //int[] arr2 = new int[5] {1,2,3,4,5};
            //int[] arr3 = { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"the length of array is {arr3.Length}");
            //Console.WriteLine($"the Dimentions of array is {arr3.Rank}");
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.WriteLine(arr3[i]);
            //}
            //foreach (var item in arr3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region two D array
            //int[,] Arr2D = new int[2, 2] { { 1,2 }, { 3,4 } };
            //for (int i = 0; i < 2; i++)
            //{
            //    for (Int32 j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine(Arr2D[i,j]);
            //    }
            //}
            #endregion

            #region Judged_Array
            //int[][] Numbers = new int[3][];
            //Numbers[0] =new int[]{ 1};
            //Numbers[1] = new int[] { 2,3 };
            //Numbers[2] = new int[] { 4,5,6 };

            //for (int i = 0; i < 3; i++)
            //{
            //    for (Int32 j = 0; j < Numbers[i].Length; j++)
            //    {
            //        Console.Write(Numbers[i][j]+" ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Functions
            //int x = 8, y = 2;
            //Program.Sum(x, y);
            //Program.Sub(x, y);
            //Program.Mul(x, y);
            //Program.Div(x, y);
            //Program.mod(x, y);
            #endregion

            #region  passing value by value and by reference

            //Passing Value By Value =>send variable value to method and any change on it during
            //method not affect the real variable
            //example: 
            //int x = 3, y = 7;
            //Console.WriteLine($"Before Swap X= {x}");
            //Console.WriteLine($"Before Swap Y= {y}");
            //Program.swap(x, y);
            //Console.WriteLine($"After Swap X= {x}");
            //Console.WriteLine($"After Swap Y= {y}");

            //Passing Value By Reference =>send variable Address to method and any change on it during
            //method will affect the real variable
            //example:
            //int x = 3, y = 7;
            //Console.WriteLine($"Before Swap X= {x}");
            //Console.WriteLine($"Before Swap Y= {y}");
            //Program.swap(ref x, ref y);
            //Console.WriteLine($"After Swap X= {x}");
            //Console.WriteLine($"After Swap Y= {y}");
            #endregion

            #region passing Reference by value and by reference

            //Passing Reference By Value =>send for example an array to the method and this method 
            //take acopy of array address in heap so if i change the array address (reference)
            //the real array will be affected
            //but if i changes the array data the real array not affected
            //example
            //int[] x = { 1, 2 }, y = { 5, 7 };
            //Console.WriteLine("Before Swap X= ");
            //foreach (var item in x) Console.WriteLine(item);
            //Console.WriteLine("Before Swap Y= ");
            //foreach (var item in y) Console.WriteLine(item);

            //Program.swap(x, y);
            //Console.WriteLine("After Swap X= ");
            //foreach (var item in x) Console.WriteLine(item);
            //Console.WriteLine("After Swap Y= ");
            //foreach (var item in y) Console.WriteLine(item);

            //Passing Reference By Reference =>send Array real address in the stack
            //so if i change the array reference or data the real array will be affected
            //example
            //int[] x = { 1, 2 }, y = { 5, 7 };
            //Console.WriteLine("Before Swap X= ");
            //foreach (var item in x) Console.WriteLine(item);
            //Console.WriteLine("Before Swap Y= ");
            //foreach (var item in y) Console.WriteLine(item);

            //Program.swap(ref x, ref y);
            //Console.WriteLine("After Swap X= ");
            //foreach (var item in x) Console.WriteLine(item);
            //Console.WriteLine("After Swap Y= ");
            //foreach (var item in y) Console.WriteLine(item);
            #endregion

            #region Passing by out
            //int x = 8, y = 4, sum, sub;
            //Program.sum_sub(x, y,out sum,out sub);
            //Console.WriteLine($"The Summition is :{sum}");
            //Console.WriteLine($"The Subtraction is :{sub}");
            #endregion

            #region Boxing vs UnBoxing

            //Boxing =>casting from value type to reference type(implicit casting)
            //int x = 5;
            //object o = x;
            //Console.WriteLine(o);
            //UnBoxing =>casting from reference type to value type(explicit casting)
            //object o = new object();
            //o = 76;
            //int x =(int) o;
            //Console.WriteLine(x);
            #endregion

            #region Exception Handling & protective code
            try
            {
                int[] myArr = {1,2,3};
                myArr[100] = 76;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            int num;
            bool flag;
            do
            {
                Console.WriteLine("please enter number");
                flag = int.TryParse(Console.ReadLine(), out num);
            }while (!flag);
            Console.WriteLine($"Your Number Is {num}");
            #endregion

        }
        static void Sum(int x, int y) {
            Console.WriteLine($"The Summition OF {x} and {y} is {x+y}");
        }
        static void Sub(int x, int y)
        {
            Console.WriteLine($"The Subtraction OF {x} and {y} is {x - y}");
        }
        static void Mul(int x, int y)
        {
            Console.WriteLine($"The Multiplication OF {x} and {y} is {x * y}");
        }
        static void Div(int x, int y)
        {
            Console.WriteLine($"The Division OF {x} and {y} is {x / y}");
        }
        static void mod(int x, int y)
        {
            Console.WriteLine($"The Modilus OF {x} and {y} is {x % y}");
        }
        static void swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void swap(int[] x, int[] y)
        {
            int[] temp = x;
            x = y;
            y = temp;
        }
        static void swap(ref int[] x, ref int[] y)
        {
            int[] temp = x;
            x = y;
            y = temp;
        }
        static void sum_sub(int num1,int num2,out int Sum,out int Sub)
        {
            Sum = num1 + num2;
            Sub = num1 - num2;
        }
    }
}
