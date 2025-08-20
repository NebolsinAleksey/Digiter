namespace Digiter;

class Program
{
    static void Main(string[] args)
    {
        {
            bool isEnabled = true;

            while (isEnabled)
            {
                Console.WriteLine("Введите первое число");

                var firstNumber = double.Parse(Console.ReadLine());

                Console.WriteLine("Выбрать операцию: '+', '-', '/', '*'");

                var selectedOperation = Console.ReadLine();

                Console.WriteLine("Введите второе число");

                var secondNumber = double.Parse(Console.ReadLine());

                double result = 0;

                switch (selectedOperation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "/":
                        result = firstNumber / secondNumber;                      
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;  
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
                Console.WriteLine($"Результат: {result}");

                Console.WriteLine("Продолжить? (y/n)");

                var isEnabledUserInput = Console.ReadLine().ToLower();

                isEnabled = (isEnabledUserInput == "y");
            }
        }
    }
}
