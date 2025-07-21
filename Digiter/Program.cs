namespace Digiter;

class Program
{
    static void Main(string[] args)
    {      
        {  
            Console.WriteLine("Выбрать операцию: '+', '-', '/', '*'");

            var str = Console.ReadLine();

            Console.WriteLine("Введите первое число");

            var numfirst = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");

            var numsecond = double.Parse(Console.ReadLine());

            double result = 0;

            switch (str)
            {
                case "+":
                    result = (numfirst + numsecond);
                    break;
                case "-":
                    result = (numfirst - numsecond);
                    break;
                case "/":
                    result = (numfirst / numsecond);
                    break;
                case "*":
                    result = (numfirst * numsecond);
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.WriteLine($"Результат: {result}");            
        }
    }    
}
