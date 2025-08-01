namespace Digiter;

class Program
{
    static void Main(string[] args)
    {
        {
            bool enabled = true;

            while (enabled)
            {
                Console.WriteLine("Выбрать операцию: '+', '-', '/', '*'");

                var choiceoperation = Console.ReadLine();

                Console.WriteLine("Введите первое число");

                var firstnumber = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число");

                var secondnumber = double.Parse(Console.ReadLine());

                double result = 0;

                switch (choiceoperation)
                {
                    case "+":
                        result = (firstnumber + secondnumber);
                        break;
                    case "-":
                        result = (firstnumber - secondnumber);
                        break;
                    case "/":
                        if (secondnumber != 0 )
                        result = (firstnumber / secondnumber);
                        else
                        {
                            Console.WriteLine("Ошибка: деление на ноль!");
                        }
                        break;
                    case "*":
                        result = (firstnumber * secondnumber);
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
                Console.WriteLine($"Результат: {result}");

                Console.WriteLine("Продолжить? (y/n)");

                var isEnabledUserInput = Console.ReadLine().ToLower();

                enabled = (isEnabledUserInput == "y");               
            }
        }
    }
}




