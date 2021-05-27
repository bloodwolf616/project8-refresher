using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project8_refresher_
{
    class Bird
    {
        public string Color { get; set; }
        public string Species { get; set; }

        public Bird(string color, string species)
        {
            Color = color;
            Species = species;
        }
    }
}
