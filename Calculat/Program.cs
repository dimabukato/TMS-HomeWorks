namespace Calculat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            string firstNumber = Console.ReadLine();
            Console.Write("Second number: ");
            string secondNumber = Console.ReadLine();
            if (double.TryParse(firstNumber, out double firstNum)) 
            {
                if (double.TryParse(secondNumber, out double secondNum))
                {
                    Console.WriteLine("Choose: '+' '-' '*' '/' '%'");
                    switch (Console.ReadLine())
                    {
                        case "+":
                            
                            Console.WriteLine($"Your result:{firstNum + secondNum}");
                            break;

                        case "-":
                            Console.WriteLine($"Your result:{firstNum - secondNum}");
                            break;

                        case "*":
                            Console.WriteLine($"Your result:{firstNum * secondNum}");
                            break;

                        case "/":
                            Console.WriteLine($"Your result:{firstNum / secondNum}");
                            break;

                        case "%":
                            Console.WriteLine($"Your result:{firstNum % secondNum}");
                            break;

                        default:
                            Console.WriteLine("Unknown operaion");
                            break;
                    }
                }
                else
                Console.WriteLine("Unknown operaion");
            }
            else 
            Console.WriteLine("Unknown operaion");
        }
    }
}
