using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> My_dict1 = new Dictionary<int, string>();
            My_dict1.Add(1123, "Welcome");
            My_dict1.Add(1124, "to");
            My_dict1.Add(1125, "home");

            // foreach (KeyValuePair<int, string> ele1 in My_dict1)
            //{
            //Console.WriteLine("{0} and {1}",
            //ele1.Key, ele1.Value);
            //}
            //Console.WriteLine();

            // Using Remove() method
            My_dict1.Remove(1123);
            foreach (KeyValuePair<int, string> ele in My_dict1)
            {
                Console.WriteLine("{0} and {1}",
                            ele.Key, ele.Value);
            }
            Console.WriteLine();


        }
    }
}
