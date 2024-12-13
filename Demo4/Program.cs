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

            #region Functions
            int x = 8, y = 2;
            Program.Sum(x, y);
            Program.Sub(x, y);
            Program.Mul(x, y);
            Program.Div(x, y);
            Program.mod(x, y);
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

    }
}
