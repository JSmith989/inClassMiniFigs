using System;
using System.Collections.Generic;
using System.Text;

namespace legoMiniFigurines.Pieces.Torsos
{
    class PirateTorso : Torso
    {
        public bool HasHook { get; }

        public PirateTorso(bool hasHook)
        {
            Accessory = "Parrot";
            HasHook = hasHook;
        }

        public override void Wave()
        {
            if(HasHook)
            {
                Console.WriteLine($"The pirate torso beckons menacingly with his hook...");
            }
            else
            {
                base.Wave();
          
            }
              
        }
    }
}
