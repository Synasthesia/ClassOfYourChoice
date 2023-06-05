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
                Console.WriteLine("Welcome to the Character Creator!");
                Console.WriteLine("Please select which part of the Character Creator you would like to work on:");
                Console.WriteLine("1: Name");
                Console.WriteLine("2: Color");
                Console.WriteLine("3: Feed your rabbit");
                Console.WriteLine("4: Let your rabbit sleep");
                Console.WriteLine("5: Have your rabbit move around");
                Console.WriteLine("6: Display rabbit statistics");
                Console.WriteLine("If you are finished, simply enter quit");
                string userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Enter your rabbit's name.");
                        rabbit.Name = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Enter your rabbit's color.");
                        rabbit.Color = Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("You feed your rabbit a carrot.");
                        rabbit.Hunger += 50;
                        if (rabbit.Hunger > 100)
                        {
                         rabbit.Hunger = 100;
                        }
                        break;
                    case "4":
                        int hoursSlept = sleep.Next(1, 5);
                        Console.WriteLine($"Your rabbit falls asleep for {hoursSlept} hours.");
                        rabbit.Hunger = rabbit.Hunger - (hoursSlept * 15);
                        rabbit.Tiredness = rabbit.Tiredness + hoursSlept * 20;
                        if (rabbit.Tiredness > 100) { rabbit.Tiredness = 100; }
                        if (rabbit.Hunger < 0) { rabbit.Hunger = 0; }
                        Console.WriteLine("Press enter to return.");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Let your rabbit move around");
                        if (rabbit.Hunger == 0) { Console.WriteLine("Your rabbit needs to eat!"); break; }

                        if (rabbit.Hunger < 0)
                        {
                            rabbit.Hunger = 0;
                        }
                    break;
                    case "6":
                        Console.WriteLine($"{rabbit.Name} the {rabbit.Color} rabbit");
                        Console.WriteLine("-------------------");
                        Console.WriteLine($"Hunger: {rabbit.Hunger}");
                        Console.WriteLine($"Sleep: {rabbit.Tiredness}");
                        Console.WriteLine("Press any key to continue");
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

        //Let your rabbit sleep. Increases sleep and reduces hunger properties
        public int Sleep(int hunger, int tired)
        {
            Random sleep = new Random();
            int hoursSlept = sleep.Next(1, 5);

            Console.WriteLine($"Your rabbit falls asleep for {hoursSlept} hours.");
            hunger = hunger - (hoursSlept * 15);
            rabbit.Tiredness = rabbit.Tiredness + hoursSlept * 20;
            if (rabbit.Tiredness > 100) { rabbit.Tiredness = 100; }
            if (rabbit.Hunger < 0) { rabbit.Hunger = 0; }

            return hoursSlept;
        }
        
    }
}