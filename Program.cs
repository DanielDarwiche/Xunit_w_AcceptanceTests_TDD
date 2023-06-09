namespace Xunit_w_AcceptanceTests_TDD
{
    public class Program
    {
        static void Main(string[] args)
        {
            RunMenu();
        }
        public static void RunMenu()
        {
            Calculator mc = new Calculator();
            do
            {
                Console.Write("\nWelcome to "); Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("'Cal"); Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Cula"); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Tor'\n"); Console.ForegroundColor = ConsoleColor.White;
                Console.Write("There are many ways to "); Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("CalcuLate\n"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter a number to choose:\n");

                Console.WriteLine("1) Calculate using 'Addition'");
                Console.WriteLine("2) Calculate using 'Subtraction'");
                Console.WriteLine("3) Calculate using 'Multiplication'");
                Console.WriteLine("4) Calculate using 'Division'");
                Console.WriteLine("5) View 'Records' of calculations");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("You chose to calculate using 'Addition'.");
                        mc.InputMethod();
                        mc.Addition(mc.NumOne, mc.NumTwo);
                        mc.OutputMethod(mc.NumOne, mc.NumTwo, mc.MathChoice, mc.Result);
                        mc.RecordWriter(mc.RecordFile);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("You chose to calculate using 'Subtraction'.");
                        mc.InputMethod();
                        mc.Subtraction(mc.NumOne, mc.NumTwo);
                        mc.OutputMethod(mc.NumOne, mc.NumTwo, mc.MathChoice, mc.Result);
                        mc.RecordWriter(mc.RecordFile);
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("You chose to calculate using 'Multiplication'.");
                        mc.InputMethod();
                        mc.Multiplication(mc.NumOne, mc.NumTwo);
                        mc.OutputMethod(mc.NumOne, mc.NumTwo, mc.MathChoice, mc.Result);
                        mc.RecordWriter(mc.RecordFile);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("You chose to calculate using 'Division'.");
                        mc.InputMethod();
                        mc.Division(mc.NumOne, mc.NumTwo);
                        mc.OutputMethod(mc.NumOne, mc.NumTwo, mc.MathChoice, mc.Result);
                        mc.RecordWriter(mc.RecordFile);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("\nYou chose to view the records.\n");
                        mc.RecordDisplay(mc.RecordFile);
                        break;
                    default:
                        Console.Clear(); Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("'" + choice + "' was not valid. Simply enter a number."); Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            } while (true);
        }
    }
}