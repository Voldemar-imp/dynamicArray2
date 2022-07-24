using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicArray2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool areContinue = true;

            while (areContinue)
            {
                Console.WriteLine("Введите число или комманду:  exit - для выхода," +
                    " sum - для вывода суммы всех введенных чисел");               
                string userInput = Console.ReadLine();
                bool success = int.TryParse(userInput, out int number);
                if (success == true)
                {
                    numbers.Add(number);
                }
                else 
                {
                    ExecuteCommand(numbers, userInput, ref areContinue);
                }

                Console.ReadKey(true);
                Console.Clear();
            }
        }

        static void ExecuteCommand(List<int> numbers, string userInput, ref bool areContinue)
        {
            switch (userInput)
            {
                case "sum":
                    WriteSum(numbers);
                    break;
                case "exit":
                    areContinue = false;
                    break;
                default:
                    Console.WriteLine($"Введенное значение: '{userInput}' не явлеяется целым числом или командой, поробуйте еще раз.");
                    break;
            }
        }

        static void WriteSum(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"Сумма всех введенных чисел = '{sum}'");
        }
    }
}
