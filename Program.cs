using System;

namespace corporate_system_programming_calculator
{
    class Program
    {
        
        private static double current = 0;
        private static double memory = 0;

        static double GetNumber()
        {
            Console.WriteLine("Enter number:");
            double user_input_to_double = Convert.ToDouble(Console.ReadLine());
            return user_input_to_double;
        }

        static double ChangeOperationWithTwoVariable(double number1, string operation, double number2)
        {

            switch (operation)
            {
                case "+": return number1 + number2; break;
                case "-": return number1 - number2; break;
                case "*": return number1 * number2; break;
                case "/": if (number1 != 0 && number2 != 0) 
                    return number1 / number2; break; 
                case "%": return number1 % number2; break;

            }

            return 0;
        }

        static double ChangeOperationWithOneVariable(double number, string operation)
        {
            switch (operation)
            {
                case "r":
                    if (number != 0) return 1 / number;
                    break;
                case "s": return number *= number; break;
                case "q":
                    if (number >= 0) return Math.Sqrt(number);
                    break;
                case "m+": memory += number; break;
                case "m-": memory -= number; break;
                case "mr": number = memory; break;
                case "c": current = 0; break;


            }

            return 0;
        }



        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Память: {memory}");
                Console.WriteLine($"Текущее значение: {current}");
                Console.WriteLine("Enter classic operation: +, -, *, /, %, r, s, q \nor memory operation: m+,m-,mr,c ");
                string input_operation = Console.ReadLine();
                if (input_operation == "+" || input_operation == "-" || input_operation == "*" ||
                    input_operation == "/" || input_operation == "%")
                {
                    current = ChangeOperationWithTwoVariable(GetNumber(), input_operation,GetNumber());
                }
                else
                {
                    current = ChangeOperationWithOneVariable(GetNumber(), input_operation);
                }
            }
        }
    }
}
