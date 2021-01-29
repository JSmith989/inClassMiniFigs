using System;
using System.Collections.Generic;
using System.Text;

namespace legoMiniFigurines.Pieces.Heads
{
    // : is like extends in react
    class CoolHead : Head
    {
        
        public string Hair { get; set; }
        public Gender Gender { get; set; }
       


        public void Chill()
        {
            Console.WriteLine($"The {Gender} head with {Hair} hair is wearing {Eyewear} and chilling.");
        }

        public override void Greet()
        {
            Console.WriteLine($"The {Gender} head with {Hair} hair is wearing {Eyewear} and says 'sup'");
        }
    }
    
}
