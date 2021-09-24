using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Match
    {
        //implementation of search method
        public static int Search<T>(T[] arrays, T Key) where T : IComparable<T>
        {
            for(int i=0; i<arrays.Length; i++)           
            {
                if (arrays[i].CompareTo(Key) == 0)
                    return i;
            }
            return -1;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 5 integer elements");
            int[] input = new int[5];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Display array
            foreach (var i in input)
            {
                Console.Write(i + ", ");
            }

            //Get a search key from user
            Console.WriteLine();
            Console.WriteLine("Enter the element you want to find the location");
            int x = Convert.ToInt32(Console.ReadLine());

            //Invocation of search method
            int result = Search(input, x);
            if (result >= 0)
            {
                Console.WriteLine("Element is in the {0}th place", result + 1);
            }
            else
                Console.WriteLine("Element is in the {0}th place - Element is not found", result);
            Console.WriteLine();

            //Student 
            Console.WriteLine("-----Find Student-----");
            Console.WriteLine("Enter the 5 Student Names");
            
            //Student objects
            Student s1 = new Student();
            s1.name = Console.ReadLine();
            Student s2 = new Student();
            s2.name = Console.ReadLine();
            Student s3 = new Student();
            s3.name = Console.ReadLine();
            Student s4 = new Student();
            s4.name = Console.ReadLine();
            Student s5 = new Student();
            s5.name = Console.ReadLine();

            //Input student objects 
            String[] students = { s1.name, s2.name, s3.name, s4.name, s5.name };

            //Display array
            foreach (var i in students)
            {
                Console.Write(i + ", ");
            }

            //Get a search key from user
            Console.WriteLine();
            Console.WriteLine("Enter the student name that you want to find the location");
            String y = Console.ReadLine();

            //Invocation of search method
            result = Search(students, y);
            if (result >= 0)
            {
                Console.WriteLine("Student is in the {0}th place", result + 1);
            }
            else
                Console.WriteLine("Student is in the {0}th place - Student is not found", result);
            Console.ReadKey();
        }
    }

    public class Student
    {
        public string name;
    }

}
