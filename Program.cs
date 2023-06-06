namespace ClassOfYourChoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            Rabbit rabbit = new Rabbit("", "", 80, 75, "");


            while (isRunning)
            {
                

                Console.Clear();
                Console.WriteLine("Welcome to your new rabbit!");
                Console.WriteLine("Please select how to interact with your rabbit:");
                Console.WriteLine("1: Name");
                Console.WriteLine("2: Color");
                Console.WriteLine("3: Feed your rabbit");
                Console.WriteLine("4: Let your rabbit sleep");
                Console.WriteLine("5: Have your rabbit move around");
                Console.WriteLine("6: Rabbit statistics");
                Console.WriteLine("If you are finished, simply enter quit");
                Console.WriteLine("                          .\".\r\n                         /  |\r\n                        /  /\r\n                       / ,\"\r\n           .-------.--- /\r\n          \"._ __.-/ o. o\\  \r\n             \"   (    Y  )\r\n                  )     /\r\n                 /     (\r\n                /       Y\r\n            .-\"         |\r\n           /  _     \\    \\ \r\n          /    `. \". ) /' )\r\n         Y       )( / /(,/\r\n        ,|      /     )\r\n       ( |     /     /\r\n        \" \\_  (__   (__\r\n            \"-._,)--._,)");
                string userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter your rabbit's name.");
                        rabbit.Rename(Console.ReadLine());
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Enter your rabbit's color.");
                        rabbit.NewColor(Console.ReadLine());
                        break;
                    case "3":
                        Console.Clear();
                        rabbit.Eat();
                        break;
                    case "4":
                        Console.Clear();
                        rabbit.Sleep(rabbit.Hunger, rabbit.Tiredness);
                        break;
                    case "5":
                        Console.Clear();
                        rabbit.Move();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine($"{rabbit.Name} the {rabbit.Color} rabbit");
                        Console.WriteLine("-------------------");
                        Console.WriteLine($"Hunger: {rabbit.Hunger}");
                        Console.WriteLine($"Sleep: {rabbit.Tiredness}");
                        Console.WriteLine("Press any key to continue");
                        Console.WriteLine("                             ,\r\n                            /|      __\r\n                           / |   ,-~ /\r\n                          Y :|  //  /\r\n                          | jj /( .^\r\n                          >-\"~\"-v\"\r\n                         /       Y\r\n                        jo  o    |\r\n                       ( ~T~     j\r\n                        >._-' _./\r\n                       /   \"~\"  |\r\n                      Y     _,  |\r\n                     /| ;-\"~ _  l\r\n                    / l/ ,-\"~    \\\r\n                    \\//\\/      .- \\\r\n                     Y        /    Y    \r\n                     l       I     !\r\n                     ]\\      _\\    /\"\\\r\n                    (\" ~----( ~   Y.  )\r\n                ~~~~~~~~~~~~~~~~~~~~~~~~~~");

                        Console.ReadKey();
                        break;
                    case "quit":
                        Console.WriteLine("Thank you for interacting with your virtual rabbit");
                        isRunning = false;
                        break;
                    default: break;
                }
            }
        }
    }
}