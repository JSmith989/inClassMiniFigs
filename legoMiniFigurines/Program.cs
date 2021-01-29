using System;
using legoMiniFigurines.Pieces;
using legoMiniFigurines.Pieces.Heads;
using legoMiniFigurines.Pieces.Torsos;
using legoMiniFigurines.Pieces.Legs;

namespace legoMiniFigurines
{
    class Program
    {
        static void Main(string[] args)
        {
            var coolHead = new CoolHead();
            coolHead.Eyewear = "Sunglasses";
            coolHead.Hair = "Long";
            coolHead.Gender = Gender.Male;

            var nerdHead = new NerdHead();
            nerdHead.Acne = true;
            nerdHead.Hat = "Fedora";

            var skull = new Skull 
            {
                Color = Color.Red,
                Condition = Condition.OnFire,
                EyeColor = Color.Green,
                Eyewear = "Aviators"
            };

            var heads = new Head[] { coolHead, nerdHead, skull };

            foreach (var head in heads)
            {
                
                head.Talk("Stuff");
            }

            var pirateTorsoWithHook = new PirateTorso(true) {Clothing = Clothing.SmokingJacket };
            var pirateTorsoNoHook = new PirateTorso(false) { Clothing = Clothing.Raincoat };

            pirateTorsoWithHook.Wave();
            pirateTorsoNoHook.Wave();

            var skeletonTorso = new SkeletonTorso(false, Condition.OnFire);

            var policeTorso = new PoliceOfficerTorso();

            var torsos = new Torso[] { pirateTorsoWithHook, pirateTorsoNoHook, skeletonTorso, policeTorso };

            foreach (var torso in torsos)
            {
                torso.Wave();
            }

            var legs = new DiscoLegs();

            var skullPoliceSpider = new MiniFigure(skull, policeTorso, new SpiderLegs(), "Weird dude");
            skullPoliceSpider.MeetSomeone();
        }
    }
}
