using System;
using System.Collections.Generic;
using System.Text;

namespace legoMiniFigurines.Pieces.Torsos
{
    class Torso
    {
        public Clothing Clothing { get; set; }
        public Color Color { get; set; }
        public int NumberOfArms { get; set; }
        public string Accessory { get; set; }

        public Torso()
        {
            NumberOfArms = 2;
        }

        public virtual void Wave()
        {
            if (NumberOfArms > 0)
            {
                Console.WriteLine($"The {GetType().Name} wearing a {Clothing} and {Accessory} waves frantically. ");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} can't wave, no arms");
            }
        }

    }
}
