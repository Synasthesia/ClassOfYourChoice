namespace ClassOfYourChoice
{
    public class Rabbit
    {
        //Fields
        private string name;
        private string color;
        private int hunger;
        private int tiredness;
        private string movement;
        private int feet = 0;

        //Properties
        public string Name { get; set; }
        public string Color { get; set; }
        public int Hunger { get; set; }
        public int Tiredness { get; set; }
        public string Movement { get; set; }
        public int Feet { get; set; }

        //Construct
        public Rabbit(string name, string color, int hunger, int tiredness, string movement)
        {
            Name = name;
            Color = color;
            Hunger = hunger;
            Tiredness = tiredness;
            Movement = movement;
            Feet = feet;
        }

        //Methods

        //Rename your rabbit
        public void Rename(string newName)
        {
            Name = newName;
            Console.WriteLine("You rename your rabbit to " + Name);
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        //Rabbit color
        public void NewColor(string newColor)
        {
            Color = newColor;
            Console.WriteLine("Your rabbit's color is now " + Color);
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }
        //Rabbit eats
        //Hunger value increases by 50
        //Tiredness value decreases by 20
        public void Eat()
        {
            Hunger += 50;
            if (Hunger > 100) { Hunger = 100; }
            Tiredness -= 20;
            if (Tiredness < 0) 
            { 
                Tiredness = 0; 
                Console.WriteLine("Your rabbit needs to sleep first!"); 
            }
            else
            {
                Console.WriteLine("You feed your rabbit a carrot.");
            }
            Console.WriteLine("Press any key to return to the menu");
            Console.WriteLine("                 \\     /\r\n                 \\\\   //\r\n                  )\\-/(\r\n                  /e e\\\r\n                 ( =T= )\r\n                 /`---'\\\r\n            ____/ /___\\ \\\r\n       \\   /   '''     ```~~\"--.,_\r\n    `-._\\ /                       `~~\"--.,_\r\n   ------>|                                `~~\"--.,_\r\n    _.-'/ \\                            ___,,,---\"\"~~``'\r\n       /   \\____,,,,....----\"\"\"\"~~~~````");
            Console.ReadKey();
        }

        //Rabbit sleeps
        //Hunger value decreases by 15 * 1 hour
        //Tiredness value increases by 20 * 1 hour
        public void Sleep(int hungerValue, int tiredValue)
        {
            Random random = new Random();
            int hoursSlept = random.Next(1, 5);

            Hunger -= (hoursSlept * 15);
            Tiredness += (hoursSlept * 20);
            if (Tiredness > 100) { Tiredness = 100; }
            if (Hunger < 0) { Hunger = 0; }
            Console.WriteLine("Your rabbit slept for " + hoursSlept + " hours.");
            Console.WriteLine("Press any key to return to the menu");
            Console.WriteLine("       __\r\n      / \\`\\          __\r\n      |  \\ `\\      /`/ \\\r\n      \\_/`\\  \\-\"-/` /\\  \\\r\n           |       |  \\  |\r\n           (_     _)   \\_/\r\n           /       \\\r\n       ,\".|.'.\\_/.'.|.\",\r\n      /   /\\' _|_ '/\\   \\\r\n      |  /  '-`\"`-'  \\  |\r\n      | |             | |\r\n      | \\    \\   /    / |\r\n       \\ \\    \\ /    / /\r\n        `\"`\\   :   /'\"`\r\n            `\"\"`\"\"`");
            Console.ReadKey();
        }

        /*Rabbit moves
         * Hunger value decreases by 15
         * Tiredness value decreases by 15
         * Rabbit total movement counter increases by 5ft * number of hops*/
        public void Move()
        {
            Random random = new Random();
            int thisMove = random.Next(1, 5);
            
            Feet += (thisMove * 5);
            Hunger -= 15;
            if (Hunger <= 0) 
            { 
                Console.WriteLine("Your rabbit is too hungry to hop around! Feed them first!");
                Hunger = 0;
            }
            Tiredness -= 15;
            if (Tiredness <= 0)
            {
                Console.WriteLine("Your rabbit is too tired to hop around! Let them sleep first!");
                Tiredness = 0;
            }

            Console.WriteLine("Your rabbit hops " + thisMove + " times, totalling " + (thisMove * 5) + "ft");
            Console.WriteLine("Your rabbit has moved a total of " + Feet + "'");

            Console.WriteLine("Press any key to return to the menu");
            Console.WriteLine("                     _       _\r\n                    / \\     / \\\r\n                   {   }   {   }\r\n                   {   {   }   }\r\n                    \\   \\ /   /\r\n                     \\   Y   /\r\n                     .-\"`\"`\"-.\r\n                   ,`         `.\r\n                  /             \\\r\n                 /               \\\r\n                {     ;\"\";,       }\r\n                {  /\";`'`,;       }\r\n                 \\{  ;`,'`;.     /\r\n                  {  }`\"\"`  }   /}\r\n                  {  }      {  //  \r\n                  {||}      {  /\r\n                  `\"'       `\"'");
            Console.ReadKey();
        }
    }
}
