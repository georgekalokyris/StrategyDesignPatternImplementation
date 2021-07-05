﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Enums;
using Assignment3.Models;

namespace Assignment3.VariationStrategy
{
    public class FabricVariationExpensiveStrategy : IVariationStrategy
    {
        private static Dictionary<Fabric, decimal> fabricVariatons;

        static FabricVariationExpensiveStrategy()
        {
            fabricVariatons = new Dictionary<Fabric, decimal>()
            {
                {Fabric.CASHMERE, 30m },
                {Fabric.COTTON, 40m },
                {Fabric.LINEN, 60m },
                {Fabric.POLYESTER, 120m },
                {Fabric.RAYON, 150m },
                {Fabric.SILK, 180m },
                {Fabric.WOOL, 200m }
            };

        }

        public void Cost(TShirt tshirt)
        {
            tshirt.Price += fabricVariatons[tshirt.Fabric];
        }
    }
}
