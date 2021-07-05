using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Enums;
using Assignment3.Models;

namespace Assignment3.VariationStrategy
{
    public class ColorVariationNormalStrategy : IVariationStrategy
    {
        private static Dictionary<Color, decimal> colorvariations;

        static ColorVariationNormalStrategy()
        {
            colorvariations = new Dictionary<Color, decimal>()
            {
                {Color.BLUE, 1m},
                {Color.GREEN, 2m},
                {Color.INDIGO, 4m},
                {Color.ORANGE, 5m},
                {Color.RED, 8m},
                {Color.VIOLET, 12m},
                {Color.YELLOW, 20m}
            };

        }

        public void Cost(TShirt tshirt)
        {
            tshirt.Price += colorvariations[tshirt.Color];
        }
    }
}
