using System;
namespace EvenNumberConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("Введите число: ");
            var input = Console.ReadLine();

            var userInput = int.TryParse(input, out int rightInput);

            while (userInput == false)
            {
                Console.WriteLine("Вы ввели неподходящий символ.");
                goto Start;
            }

            while (userInput == true)
            {
                if (rightInput != 0)
                {
                    if (rightInput % 2 == 0)
                    {
                        Console.WriteLine("Ваше число является чётным.");


                    }
                    else
                    {
                        Console.WriteLine("Ваше число является нечётным.");
                    }
                }
                else
                {
                    Console.WriteLine("Скорее всего вы ввели 0. Введите другое значение.");
                    goto Start;
                }
                Console.WriteLine("Хотите проверить другое число? Введите Да или Нет");
                var answer = Console.ReadLine();
                if (answer.ToLower() == "да")
                {
                    goto Start;
                }
                else
                {
                    Console.WriteLine("Хотите выйти? Введите Да или Нет");
                    var roundAnswer = Console.ReadLine();
                    if (roundAnswer.ToLower() == "нет")
                    {
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("До свидания!");
                        break;
                    }
                }
            }
        }     
    }
}
