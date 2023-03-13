using System;
using System.Collections.Generic;

namespace Flowershop
{
    public class flowerShopModel
    {
        public List<Rose> Roses { get; set; } = new List<Rose>();
        public List<Sunflower> Sunflowers { get; set; } = new List<Sunflower>();
        public List<Hibiscus> Hisbiscuses { get; set; } = new List<Hibiscus>();
        public List<Daisy> Daisies { get; set; } = new List<Daisy>();


        public List<IMothersDayFlower> MakeMothersDayArrangement()
        {
            List<IMothersDayFlower> arrangement = new List<IMothersDayFlower>() {
            new Daisy() { StemLength = 5 },
            new Hibiscus() { StemLength = 14.1},
            new Daisy() { StemLength = 13.2 },
            new Hibiscus() { StemLength = 12.6}

    };
            return arrangement;

        }
        public List<IBirthdayFlower> MakeBirthDayArrangement()
        {
            List<IBirthdayFlower> arrangement = new List<IBirthdayFlower>() {
            new Rose() { Color = "Red" },
            new Sunflower() { Color = "Blue"},
            new Rose() { Color = "Red" },
            new Sunflower() { Color = "Blue"}

    };
            return arrangement;

        }
    }
}