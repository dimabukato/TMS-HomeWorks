namespace Calculat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Second number: ");
            string secondNumber = Console.ReadLine();
            if (double.TryParse(firstNumber, out double firstNum)) 
            {
                if (double.TryParse(secondNumber, out double secondNum))
                {
                    Console.WriteLine("Choose: '+' '-' '*' '/' '%'");
                    switch (Console.ReadLine())
                    {
                        case "+":
                            
                            Console.WriteLine($"Your result is:{firstNum + secondNum}");
                            break;

                        case "-":
                            Console.WriteLine($"Your result is:{firstNum - secondNum}");
                            break;

                        case "*":
                            Console.WriteLine($"Your result is:{firstNum * secondNum}");
                            break;

                        case "/":
                            Console.WriteLine($"Your result is:{firstNum / secondNum}");
                            break;

                        case "%":
                            Console.WriteLine($"Your result is:{firstNum % secondNum}");
                            break;

                        default:
                            Console.WriteLine("Unknown operaion, please try again");
                            break;
                    }
                }
                else
                Console.WriteLine("Input data must be numbers");
            }
            else 
            Console.WriteLine("Input data must be numbers");
        }
    }
}
