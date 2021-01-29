using System;
using System.Collections.Generic;
using System.Text;

namespace legoMiniFigurines.Pieces.Heads
{
    class NerdHead : Head
    {
        public bool Braces { get; set; }
        public string Hat { get; set; }
        public bool Acne { get; set; }

        public void Pontificate()
        {
            Console.WriteLine($"The nerd wearing a {Hat} says 'Actually... I am very smart'");
        }

        public override void Greet()
        {
            Console.WriteLine($"The nerd wearing a {Hat} says 'I've calculated the chances of us ever seeing eachother again. It is zero.");
        }
    }
}
