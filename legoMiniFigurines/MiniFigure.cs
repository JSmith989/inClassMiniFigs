using System;
using System.Collections.Generic;
using System.Text;
using legoMiniFigurines.Pieces.Heads;
using legoMiniFigurines.Pieces.Torsos;
using legoMiniFigurines.Pieces.Legs;


namespace legoMiniFigurines
{
    class MiniFigure
    {
        public Head Head { get; }
        public Torso Torso { get; }
        public LegsBase Legs { get; }
        public string Name { get;}

        public MiniFigure(Head head, Torso torso, LegsBase legs, string name)
        {
            Head = head;
            Torso = torso;
            Legs = legs;
            Name = name;
        }

        public void MeetSomeone()
        {
            Console.WriteLine($"{Name} is starting the greeting process");
            Legs.Walk();
            Torso.Wave();
            Head.Greet();
            Console.WriteLine(new string('-', 40));
        }
    }
}
