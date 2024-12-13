using System.Threading;
using System;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using System.Reflection.Metadata;
using System.Buffers.Text;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ////1 - Create a program that asks the user to input three points(x1, y1), 
            ////    (x2, y2), and(x3, y3), and determines whether these points lie on a single 
            ////    straight line.

            //int[,] points=new int[3,2];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Please enter the Value of X" + (i + 1));
            //    bool flag1 = int.TryParse(Console.ReadLine(), out points[i,0]);

            //    Console.WriteLine("Please enter the Value of y" + (i + 1));
            //    bool flag2 = int.TryParse(Console.ReadLine(), out points[i,1]);
            //}

            //bool IsStraight = StraightLine(points);
            //if (IsStraight)
            //    Console.WriteLine("these points lie on a single straight line.");
            //else
            //    Console.WriteLine("these points lie on different lines.");
            #endregion

            #region Q2
            ////2 - Within a company, the efficiency of workers is evaluated based on the duration 
            ////    required to complete a specific task.A worker's efficiency level is determined 
            ////    as follows: 
            ////- If the worker completes the job within 2 to 3 hours, they are considered 
            ////    highly efficient.
            ////- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            ////- If the worker takes 4 to 5 hours, they are provided with training to enhance 
            ////    their speed.
            ////- If the worker takes more than 5 hours, they are required to leave the company.
            ////To calculate the efficiency of a worker, the time taken for the task is obtained 
            ////    via user input from the keyboard.

            //double hours;
            //Console.WriteLine("Please enter the number of hours you spent in the task");
            //bool flag = double.TryParse(Console.ReadLine(), out hours);
            //if (flag) 
            //    Program.WorkersEfficiency(hours);
            #endregion

            #region Q3
            ////3 - .Write a program that prints an identity matrix using for loop, 
            ////    in other words takes a value n from the user and shows the identity 
            ////    table of size n * n.

            //int size;
            //Console.WriteLine("Please enter the size of identity matrix");
            //bool flag = int.TryParse(Console.ReadLine(), out size);
            //if (flag)
            //    Program.IdentityMatrix(size);
            #endregion

            #region Q20
            ////20 - Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] MyArray = { 9, 8, 4, 5, 3, 1 };
            //Console.WriteLine($"Your Array Summition Is {ArraySum(MyArray)}");
            #endregion

            #region Q21
            ////21 - Write a program in C# Sharp to merge two arrays of the same size 
            ////    sorted in ascending order.

            //int[] arr1 = { 8, 3, 6, 1, 9 };
            //int[] arr2 = { 5, 2, 1, 4, 7 };
            //int[] MergedArray = Program.MergeArrays(arr1, arr2);
            //int[] SortedArray = Program.SortArrAsc(MergedArray);
            //for (int i = 0; i < SortedArray.Length; i++)
            //{
            //    Console.WriteLine(SortedArray[i]);
            //}
            #endregion

            #region Q22
            ////22 - Write a program in C# Sharp to count the frequency of each element 
            ////    of an array.

            //int[] repeatedArr = { 3, 5, 6, 3, 6, 5, 8, 3, 1, 6, 8, 9, 0, 3 };
            //Program.CountElements(repeatedArr);
            #endregion

            #region Q23
            ////23 - Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] Array23 = { 3, 6, 2, 7, 4, 20, 10, 9, 15, 8, 1 };
            //Program.Max_Min(Array23);
            #endregion

            #region Q24
            ////24 - Write a program in C# Sharp to find the second largest element in an array.

            //int[] Array24 = { 13, 15, 35, 30, 20 };
            //int SecMax=Program.SecondMax(Array24);
            //Console.WriteLine();
            //Console.WriteLine($"The Second Largest Element is {SecMax}");
            #endregion

            #region Q25
            ////25 -.Consider an Array of Integer values with size N, having values as
            //// in this Example
            ////700056750753
            ////write a program find the longest distance between Two equal cells.In this example.
            ////                The distance is measured by the number Of cells- for example, 
            ////    the distance between the first and the fourth cell is 2(cell 2 and cell 3).
            ////In the example above, the longest distance is between the first 7 and the
            ////10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            ////And the 10th 7s.
            ////Note:
            ////-Array values will be taken from the user
            ////-If you have input like 1111111 then the distance is the number of
            ////Cells between the first and the last cell.

            //Console.WriteLine("Please Enter Numbers to get Longest Distance 'ex:700056750753'");
            //int[] Array25= Console.ReadLine().Select(c => c - '0').ToArray();
            //Program.LongestDistance(Array25);
            #endregion

            #region Q26
            ////26 - Given a list of space separated words, reverse the order of the words.
            ////    Input: this is a test       Output: test a is this
            ////    Input: all your base        Output: base your all
            ////    Input: Word Output: Word
            ////    Note : 
            ////    Check the Split Function(Member in String Class) Output will be a 
            ////    Single Console.WriteLine Statement

            //Console.WriteLine("Please enter Statement to reverse");
            //Console.WriteLine(Program.ReverseWords(Console.ReadLine()));
            #endregion

            #region Q27
            ////27 - Write a program to create two multidimensional arrays of same size.
            ////    Accept value from user and store them in first array. Now copy all 
            ////    the elements of first array on second array and print second array.

            //int[,] FirstArr = GetArrayFromUser();
            //int[,] SecondArr = FirstArr;
            //PrintArray(SecondArr);
            #endregion

            #region Q28
            ////28 - Write a Program to Print One Dimensional Array in Reverse Order

            //int[] Array28 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //Program.ReverseArray<int>(Array28);
            #endregion

            /*Functions*/

            #region Q1 Functions
            ////1- Explain the difference between passing(Value type parameters) by value 
            ////    and by reference then write a suitable c# example.

            //Passing Value By Value =>send variable value to method and any change on it during
            //method not affect the real variable
            //ex: Swap(int x,int y);

            //Passing Value By Reference =>send variable Address to method and any change on it during
            //method will affect the real variable
            //ex: Swap(ref int x,ref int y);
            #endregion

            #region Q2 Functions
            ////2- Explain the difference between passing(Reference type parameters) by value 
            ////    and by reference then write a suitable c# example.

            //Passing Reference By Value =>send for example an array to the method and this method 
            //take acopy of array address in heap so if i change the array address (reference)
            //the real array will be affected
            //but if i changes the array data the real array not affected
            //ex: Swap(int[] x,in[] y);

            //Passing Reference By Reference =>send Array real address in the stack
            //so if i change the array reference or data the real array will be affected
            //ex: Swap(ref int[] x,ref in[] y);
            #endregion

            #region Q3 Functions
            ////3- Write a c# Function that accept 4 parameters from user and return 
            ////    result of summation and subtracting of two numbers

            //int[] ParamArr = new int[4];
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine($"Please enter Number{i+1} Value");
            //    bool flag = int.TryParse(Console.ReadLine(), out ParamArr[i]);
            //}
            //Program.GetSumSub(ParamArr);
            #endregion

            #region Q4 Functions
            ////4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            ////Output should be like
            ////Enter a number: 25
            ////The sum of the digits of the number 25 is: 7

            //Console.Write("Please Enter a number to calculate digits: ");
            //string Number = Console.ReadLine();
            //int sum=Program.DigitsSum(Number);
            //Console.WriteLine($"The sum of the digits of the number {Number} is: {sum}");
            #endregion

            #region Q5 Functions
            ////5- Create a function named "IsPrime", which receives an integer number and 
            ////    retuns true if it is prime, or false if it is not:

            //int num;
            //Console.Write("Please Insert a Number to check if Prime or not: ");
            //bool flag = int.TryParse(Console.ReadLine(), out num);
            //if (flag)
            //{
            //    Console.WriteLine(IsPrime(num));
            //}
            #endregion

            #region Q6 Functions
            ////6- Create a function named MinMaxArray, to return the minimum 
            ////    and maximum values stored in an array, using reference parameters

            //int[] Array6 = { 9, 4, 7, 0, 4, 2, 7, 1, 8 };
            //Program.MinMaxArray(Array6);
            #endregion

            #region Q7 Functions
            ////7- Create an iterative(non-recursive) function to calculate the 
            ////    factorial of the number specified as parameter

            //int num;
            //Console.Write("Please Insert a Number to get factorial: ");
            //bool flag = int.TryParse(Console.ReadLine(), out num);
            //if (flag)
            //{
            //    int result = Program.GetFactorial(num);
            //    Console.WriteLine($"The Factorial of {num} is {result}");
            //}
            #endregion

            #region Q8 Functions
            ////8- Create a function named "ChangeChar" to modify a letter in 
            ////    a certain position(0 based) of a string, replacing it with a different letter

            //string NewStr= Program.ChangeChar("Hello Ziena", 6, 'D');
            //Console.WriteLine(NewStr);
            #endregion
        }

        //Q1 function
        static bool StraightLine(int[,] Points)
        {
            for (int i = 0; i < 2; i++)
            {
                bool flag = false;
                for (Int32 j = 0; j < 2; j++)
                {
                    if (Points[j, i] != Points[j + 1, i])
                    {
                        flag = false;
                        break;
                    }
                    else
                        flag = true;
                }
                if (flag)
                    return true;
            }
            return false;
    }

        //Q2 function
        static void WorkersEfficiency(double hours)
        {
            if (hours >= 2 && hours <= 3)
                Console.WriteLine("highly efficient");
            else if (hours > 3 && hours <= 4)
                Console.WriteLine("You should increase your speed");
            else if (hours > 4 && hours <= 5)
                Console.WriteLine("You should take a training to enhance your speed.");
            else if (hours > 5)
                Console.WriteLine("Sorry you should leave the company");
            else
                Console.WriteLine("Please insert avalid hours number");
        }

        //Q3 function
        static void IdentityMatrix(int size)
        {
            Console.Clear();
            for (int i = 0; i < size; i++)
            {
                for (Int32 j = 0; j < size; j++)
                {
                    Console.Write(j + 1 + " ");
                }
                Console.WriteLine();
            }
        }

        //Q20 function
        static int ArraySum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        //Q21 function
        static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] mergedArray = new int[arr1.Length + arr2.Length];
            int index = 0;

            //merge the two arrays into one array
            for (Int32 j = 0; j < arr1.Length; j++)
            {
                mergedArray[index] = arr1[j];
                index++;
            }
            for (Int32 j = 0; j < arr2.Length; j++)
            {
                mergedArray[index] = arr2[j];
                index++;
            }
            //sort the merged array ascending

            return mergedArray;
        }
        static int[] SortArrAsc(int[] arr)
        {
            //Sort given unsorted array
            int count = 0;
            do
            {
                count = (arr.Length) - 1;
                for (int i = 0; i < (arr.Length) - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                    else
                    {
                        count--;
                    }
                }
            } while (count != 0);
            return arr;
        }

        //Q22 function
        static void CountElements(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                if(arr[i] != -1)
                {
                    for (Int32 j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i].Equals(arr[j]))
                        {
                            count++;
                            arr[j] = -1;
                        }
                    }
                    Console.WriteLine($"{arr[i]} frequent {count} times");
                }

            }
        }

        //Q23 function
        static void Max_Min(int[] arr)
        {
            int max = arr[0], min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > max)
                    max = arr[i];
                else if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine($"The Maximum Element is {max}");
            Console.WriteLine($"The Manimum Element is {min}");
        }

        //Q23 function
        static int SecondMax(int[] arr)
        {
            int max = arr[0], SecMax = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    SecMax = max;
                    max = arr[i];
                }
                else if (arr[i] > SecMax)
                    SecMax = arr[i];
            }
            return SecMax;
        }

        //Q25 function
        static void LongestDistance(int[] arr)
        {
            int Distance = 0,DisNum=0,First=0,Last=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != -1)
                {
                    for (Int32 j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            int CurrDis = (j - i) - 1;
                            if (CurrDis > Distance)
                            {
                                Distance = CurrDis;
                                DisNum = arr[i];
                                First = i + 1;
                                Last = j + 1;
                            }
                            arr[j] = -1;
                        }
                    }
                }

            }
            Console.WriteLine($"the longest distance is between the {First}th {DisNum} and the {Last}th {DisNum}, with a distance of {Distance} cells");
        }

        //Q26 function 
        static string ReverseWords(string statement)
        {
            string ReverseStr = "";
            string[] words = statement.Split(" ");
            for (int i = (words.Length)-1; i >= 0; i--)
            {
                ReverseStr += words[i] + " ";
            }
            return ReverseStr;
        }

        //Q27 function
        static int[,] GetArrayFromUser()
        {
            Console.WriteLine("Please insert number of rows in your Array");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Please insert number of Columns in your Array");
            int Cols = int.Parse(Console.ReadLine());

            int[,] UserArr = new int[rows, Cols];
            for (int i = 0; i < rows; i++)
            {
                for (Int32 j = 0; j < Cols; j++)
                {
                    Console.WriteLine($"insert the Value off cell ({i},{j})");
                    UserArr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return UserArr;
        }
        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (Int32 j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        //Q28 function 
        static void ReverseArray<T>(T[] arr)
        {
            for (int i = (arr.Length) - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }

        ////////////////********Functions************////////////
        //Q3 function 
        static void GetSumSub(int[] ParamArr)
        {
            Console.WriteLine($"the Summition of First Two Parameters Is {ParamArr[0] + ParamArr[1]}");
            Console.WriteLine($"the Substraction of Second Two Parameters Is {ParamArr[2] - ParamArr[3]}");

        }

        //Q4 function 
        static int DigitsSum(string num)
        {
            int sum = 0;
            int[] GigitsArray= num.Select(c => c - '0').ToArray();
            foreach (var digit in GigitsArray)
            {
                sum += digit;
            }
            return sum;
        }

        //Q5 function
        static bool IsPrime(int num)
        {
            int bound = (int)Math.Floor(Math.Sqrt(num));
            if (bound < 2)
                return false;
            if (num == 2 || num == 3)
                return true;
            for (int j = 2; j <= bound; j++)
            {
                if (num % j == 0)
                    return false;
            }
          return true;
        }

        //Q6 function
        static void MinMaxArray(int[] arr)
        {
            int max = arr[0], min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                else if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine($"The Maximum Element is {max}");
            Console.WriteLine($"The Manimum Element is {min}");
        }

        //Q7 function
        static int GetFactorial(int num)
        {
            int div = 1;
           
            for (int i = num; i > 0; i--)
            {
                div *= i;
            }
            return div;
        }

        //Q8 function 
        static string ChangeChar(string str,int place,char NewChar)
        {
            char[] CharArr= str.ToCharArray();
            CharArr[place] = NewChar;
            return new string(CharArr);
        }
    }
}
