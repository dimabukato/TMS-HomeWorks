using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Text;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("D:\\File1.txt");

            //Console.WriteLine(text);

            var words = text.Split(new char[] { ' ', ',', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
            Task1(words);


            static void Task1(string[] words)
            {
                var counter = 0;
                var maxCount = 0;
                var result = string.Empty;

                foreach (var word in words)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (char.IsDigit(word[i]))
                        {
                            counter++;
                        }
                    }
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        result = word;
                    }
                        counter = 0;
                    
                }
                Console.WriteLine(result);
            }

            static void Task2(string[] words)
            {
                var counter = 0;
                var maxCount = 0;
                var result = string.Empty;

                foreach (var word in words)
                {

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (counter > maxCount)
                        {
                            maxCount = counter;
                            result = word;
                        }
                    }
                    if (counter == maxCount)
                    {
                        result += word;
                    }
                        counter = 0;
                }
                Console.WriteLine(result);
            }
        }
    }
}
