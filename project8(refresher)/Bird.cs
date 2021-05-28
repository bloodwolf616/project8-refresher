using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project8_refresher_
{
    class Bird
    {

        private static readonly Random _random = new Random();


        public double RandomDouble()
        {
            return _random.NextDouble();
        }


        public string Color { get; private set; }
        public string Species { get; private set; }

        public Bird(string color, string species)
        {
            Color = color;
            Species = species;
        }



        public string ChangeColor(string newColor)
        {
            Color = newColor;
            return $"The color of the bird has changed to {Color}";
        }


        public void Call()
        {
            Console.WriteLine("Chirp Chirp...");
        }
       public void Call(string call)
        {
            Console.WriteLine(call);
        }



        public override bool Equals(object obj)
        {
            if(!(obj is Bird))
            {
                return false;
            }
            Bird that = obj as Bird;
            return this.Species == that.Species && this.Color == that.Color;
            
        }


        public override int GetHashCode()
        {
            return Color.GetHashCode() * 31 + Species.GetHashCode();
        }

    }
}
