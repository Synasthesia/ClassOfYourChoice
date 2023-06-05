using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //Properties
        public string Name { get; set; }
        public string Color { get; set; }
        public int Hunger { get; set; }
        public int Tiredness { get; set; }
        public string Movement { get; set; } 

        //Construct
        public Rabbit(string name, string color, int hunger, int tiredness, string movement)
        {
            Name = name;
            Color = color;
            Hunger = hunger;
            Tiredness = tiredness;
            Movement = movement;
        }
    }
}
