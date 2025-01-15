namespace Login_With_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string username = "Hamza";
            string password = "hamza123";
            if(username == "Hamza" && password == "hamza123")
            {
                Console.WriteLine("true"+ username + password);
            }
            else
            {
                Console.WriteLine("Wrong Username Or Password");
            }

            int num = 3;
            if(num % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }

            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("No Matching Day");
                    break;
            }
        }
    }
}
