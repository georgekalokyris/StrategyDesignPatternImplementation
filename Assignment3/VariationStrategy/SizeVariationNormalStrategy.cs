using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Enums;
using Assignment3.Models;

namespace Assignment3.VariationStrategy
{
    public class SizeVariationNormalStrategy : IVariationStrategy
    {
        private static Dictionary<Size, decimal> sizeVariations;

        static SizeVariationNormalStrategy()
        {
            sizeVariations = new Dictionary<Size, decimal>()
            {
                {Size.XS, 3m},
                {Size.S, 4m},
                {Size.M, 6m},
                {Size.XL, 12m},
                {Size.XXL, 15m},
                {Size.XXXL, 18m},
            };

        }

        public void Cost(TShirt tshirt)
        {
            tshirt.Price += sizeVariations[tshirt.Size];
        }
    }
}
