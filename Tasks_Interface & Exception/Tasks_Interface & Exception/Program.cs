using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Tasks_Interface___Exception
{



    interface ICalculator
    {


        int Add(int a, int b);

    }




    class Calculator : ICalculator
    {


        public int Add(int a, int b)
        {

            return a + b;


        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter the num a");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the num b");
                int b = Convert.ToInt32(Console.ReadLine());
                ICalculator calc = new Calculator();
                int result = calc.Add(a, b);

                Console.WriteLine("Result: " + result);

            }
            catch (Exception e)
            {
                {
                    Console.WriteLine("Invalid input! Please enter numbers only." + e.Message);



                }

            }

            File.AppendAllText("TextFile1.txt", "\nNew Line");
            File.WriteAllText("TextFile1.txt", "\r\nMy Name is Hussam Aldairyah\r\nMy age is 23 years old \r\n");

            StreamReader reader = new StreamReader("TextFile1.txt");

            string line;
            try
            {

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                reader.Close();
            }
            catch (Exception e) { 
            
            Console.WriteLine("Error "+e.Message);
            
            }
        }
    }
}