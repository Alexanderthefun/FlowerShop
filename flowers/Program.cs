using System;
using System.Collections.Generic;

namespace Flowershop
{
    class Program
    {
        static void Main(string[] args)
        {
            Daisy whiteDaisy = new Daisy()
            {
                StemLength = 14.1
            };
            Hibiscus pinkHibiscus = new Hibiscus()
            {
                Color = "pink",
                StemLength = 12.3
            };

            Rose redRose = new Rose()
            {
                Color = "red",
                PetalCount = 9
            };
            Sunflower smallSunflower = new Sunflower()
            {
                Color = "yellow",
                PetalCount = 5
            };
            List<IMothersDayFlower> MDFlowers = new List<IMothersDayFlower>(){
                whiteDaisy, pinkHibiscus
            };
            List<IBirthdayFlower> BDFlowers = new List<IBirthdayFlower> {
                redRose, smallSunflower
            };
            foreach (IMothersDayFlower md in MDFlowers){
                Console.WriteLine(md);
            }
            foreach (IBirthdayFlower bd in BDFlowers){
                Console.WriteLine(bd);
            }
        }
    }
}
