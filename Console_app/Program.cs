
namespace Calculator;
class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        Console.WriteLine("Калькулятор на c#\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
            double result = 0;
            double num1 = GetNumberFromUser("Введите первое число: ", "Ошибка");
            double num2 = GetNumberFromUser("Введите второе число: ", "Ошибка");

            double GetNumberFromUser(string message, string errorMesage)
            {
                while (true)
                {
                    Console.Write(message);
                    bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
                    if (isCorrect)
                    {
                        return userNumber;
                    }
                    Console.WriteLine(errorMesage);
                }
            }


            Console.WriteLine("Выберете вариант из следующего списка:");
            Console.WriteLine("\ta - Сложить");
            Console.WriteLine("\ts - Вычесть");
            Console.WriteLine("\tm - Умножить");
            Console.WriteLine("\td - Разделить");
            Console.Write("Ваш вариант? ");

            string op = Console.ReadLine();

          
            result = Calculator.DoOperation(num1, num2, op);

            Console.WriteLine("Ваш результат: {0:0.##}\n", result);
              

           

            Console.Write("Нажмите 'n' и Enter, чтобы закрыть приложение, или нажмите любую другую клавишу и Enter, чтобы продолжить:");
            if (Console.ReadLine() == "n") endApp = true;
            Console.WriteLine("\n");
        }
        return;
    }

 }