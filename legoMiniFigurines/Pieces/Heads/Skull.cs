using System;
using System.Collections.Generic;
using System.Text;

namespace legoMiniFigurines.Pieces.Heads
{
    class Skull : Head
    {
        public Condition Condition { get; set; }
        public Color Color { get; set; }
      

        public void Wail()
        {
            if (Condition == Condition.OnFire)
            {
                Console.WriteLine($"The flaming skull with {EyeColor} eyes wails angrily.");
            }
            else
            {
                Console.WriteLine($"The {Color} skull wails mournfully because it is dead and {Condition} and not flaming");
            }
        }

        public override void Greet()
        {
            if (Condition == Condition.OnFire)
            {
                Console.WriteLine($"The flaming {Color} skull with {EyeColor} eyes smoulders.");
            }
            else
            {
                Console.WriteLine($"The {Color} skull is dead and can't greet you.");
            }
        }
    }
}
