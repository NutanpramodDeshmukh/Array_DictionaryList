using System;
using System.Collections;

namespace ArraylistCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an ArrayList
            ArrayList student = new ArrayList();

            // add elements to ArrayList
            student.Add("Nutan");
            student.Add("pooja");
            student.Add("Jack");
            // remove 
            //student.Remove("Jack");
            Console.WriteLine("First element: " + student[0]);
            Console.WriteLine("Second element: " + student[1]);
            Console.WriteLine("Third element: " + student[2]);


            // display every element of myList 
            // for (int i = 0; i < student.Count; i++)
            //{
            //Console.WriteLine(student[i]);
            // Console.ReadKey();
            //}

            // change the value of second element 
            student[1] = "Hrushi";
            
            Console.WriteLine("Updated second element: " + student[1]);
            Console.ReadKey();

            
        }
    }
}
