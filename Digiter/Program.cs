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

                var firstbody = double.Parse(Console.ReadLine());

                Console.WriteLine("Выбрать операцию: '+', '-', '/', '*'");

                var choiceOperation = Console.ReadLine();

                Console.WriteLine("Введите второе число");

                var secondbody = double.Parse(Console.ReadLine());

                double result = 0;

                switch (choiceOperation)
                {
                    case "+":
                        result = firstbody + secondbody;
                        break;
                    case "-":
                        result = firstbody - secondbody;
                        break;
                    case "/":
                        result = firstbody / secondbody;                      
                        break;
                    case "*":
                        result = firstbody * secondbody;
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
