internal class Program
{
    private static void Main(string[] args)
    {
        Calculation();
        Exchang();
    }

    public static int Exchang()
    {
        Console.WriteLine("Enter amount of money");
        double amount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Enter what do you want to do : \n1 - AMD to USD \n2 - USD to AMD \n3 - AMD to EUR \n4 - EUR to AMD");
        Console.WriteLine();
        string currency = Console.ReadLine();
        Console.WriteLine();
        switch (currency)

        {
            case "1":
                Console.WriteLine("You can take: " + amount / 400 + "USD");
                break;
            case "2":
                Console.WriteLine("You can take: " + amount * 398 + "AMD");
                break;
            case "3":
                Console.WriteLine("You can take: " + amount / 450 + "EUR");
                break;
            case "4":
                Console.WriteLine("You can take: " + amount * 445 + "AMD");
                break;
            default:
                Console.WriteLine("Wrong value entered");
                break;
        }
        Console.WriteLine("\n");
        return Exchang();
    }
    public static int Calculation()
    {
        Console.WriteLine("Enter first number");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the action");
        string a = Console.ReadLine();

        Console.WriteLine("Enter second number");
        double b = Convert.ToDouble(Console.ReadLine());

        switch (a)
        {
            case "+":
                Console.WriteLine("Аnswer: " + c + b);
                break;
            case "-":
                Console.WriteLine("Аnswer: " + (c - b));
                break;
            case "*":
                Console.WriteLine("Аnswer: " + c * b);
                break;
            case "/":
                if (b == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine("Аnswer: " + c / b);
                }
                break;
            case "%":
                Console.WriteLine("Аnswer: " + (c / b * 100));
                break;

            default:
                Console.WriteLine("Wrong value entered");
                break;
        }
        Console.WriteLine("\n");
        return Calculation();
    }


}