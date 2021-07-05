﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Enums;
using Assignment3.Models;

namespace Assignment3.VariationStrategy
{
    public class FabricVariationNormalStrategy : IVariationStrategy
    {
        private static Dictionary<Fabric, decimal> fabricVariatons;

        static FabricVariationNormalStrategy()
        {
            fabricVariatons = new Dictionary<Fabric, decimal>()
            {
                {Fabric.CASHMERE, 3m },
                {Fabric.COTTON, 4m },
                {Fabric.LINEN, 6m },
                {Fabric.POLYESTER, 12m },
                {Fabric.RAYON, 15m },
                {Fabric.SILK, 18m },
                {Fabric.WOOL, 20m }
            };

        }

        public void Cost(TShirt tshirt)
        {
            tshirt.Price += fabricVariatons[tshirt.Fabric];
        }
    }
}
