using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Xunit_w_AcceptanceTests_TDD
{
    public class Calculator
    {
        public double NumOne;
        public double NumTwo;
        public double Result;
        public string MathChoice = string.Empty;
        public string RecordFile = @"C:\Users\danie\source\repos\Xunit_w_AcceptanceTests_TDD\RecordsText.txt";
        public void RecordWriter(string file)
        {
            string texttoappend = $"* Calculation: {NumOne} {MathChoice} {NumTwo} = {Result}\n";
            if (!File.Exists(file)) //If the file does not exist already, it will be created
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine(texttoappend);
                    Console.WriteLine("This is the first calculation created here\n");
                    //Console.WriteLine(texttoappend);
                    writer.Close();
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(file, true))//If the file already exists, we write the record on it!
                {
                    writer.WriteLine(texttoappend);
                    //Console.WriteLine(" " + texttoappend);
                    writer.Close();
                }
            }
        }
        public void RecordDisplay(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                Console.ForegroundColor = ConsoleColor.White;

                reader.Close();
            }
        }
        public void InputMethod() //Method to enter numbers to calculate
        {
            bool inputIsCorrect = false; //looping while the input is incorrect
            do
            {
                Console.WriteLine("\nKeep in mind that for decimal numbers: Use ','(comma) and not '.'(dot).");
                Console.WriteLine("Please enter a value for Number 1:\n");
                try
                {
                    NumOne = Convert.ToDouble(Console.ReadLine());
                    inputIsCorrect = true;
                }
                catch
                {
                    Console.WriteLine("Invalid input.");
                }
            } while (inputIsCorrect == false);
            inputIsCorrect = false;
            do
            {
                Console.WriteLine("\nKeep in mind that for decimal numbers: Use ','(comma) and not '.'(dot).");
                Console.WriteLine("Please enter a value for Number 2:\n");
                try
                {
                    NumTwo = Convert.ToDouble(Console.ReadLine());
                    inputIsCorrect = true;
                }
                catch
                {
                    Console.WriteLine("Invalid input.");
                }
            } while (inputIsCorrect == false);
        }
        public void Addition(double a, double b)
        {
            Result = a + b;
            MathChoice = "Addition";
        }
        public void Subtraction(double a, double b)
        {
            Result = a - b;
            MathChoice = "Subtraction";
        }
        public void Multiplication(double a, double b)
        {
            Result = a * b;
            MathChoice = "Multiplication";
        }
        public void Division(double a, double b)
        {
            Result = a / b;
            MathChoice = "Division";
        }
        public void OutputMethod(double a, double b, string mathMethod, double calcResult)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Calculation of {a} and {b} using {mathMethod} is {calcResult}");
            Console.WriteLine("------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
