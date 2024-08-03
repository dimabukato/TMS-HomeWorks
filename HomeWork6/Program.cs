namespace HomeWork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            Phone phone1 = new Phone("+375293345553", "Samsung", 5);
            Phone phone2 = new Phone("+375293245443", "iPhone");

            Console.WriteLine(phone2.GetNumber());
            Console.WriteLine(phone1.GetNumber());
            Console.WriteLine(phone.GetNumber());

            phone1.ReceiveCall("Ada");
            phone2.ReceiveCall("Leon", "+375293245443");
            phone.SendMessage("+375293245443", "+3752231245443", "+375293245434");
            Console.ReadLine();
        }
    }

    public class Phone
    {
        string Number;
        string Model;
        float Weight;

        public Phone() { Number = "Unknown number"; Model = "Unknown model"; Weight = 0; }
        public Phone(string userNumber, string userModel) : this(userNumber, userModel, 0)
        {
            Number = userNumber;
            Model = userModel;
            Weight = 0;
        }
        public Phone(string userNumber, string userModel, float phoneWeight) 
        {
            Number = userNumber;
            Model = userModel;
            Weight = phoneWeight;
        }

        public void ReceiveCall(string name)
        {
            Console.WriteLine($"{name} calls");
        }
        public void ReceiveCall(string name, string number)
        {
            Console.WriteLine($"{name} calls {number}");
        }
        public void SendMessage (params string[] numbers)
        {
            foreach (string number in numbers)
            {
                Console.Write(" " + number);
            }
        }

        public string GetNumber()
        {
            return this.Number;
        }

    }
}
