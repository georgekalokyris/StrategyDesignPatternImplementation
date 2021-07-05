using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Models;

namespace Assignment3.VariationStrategy
{
    public interface IVariationStrategy
    {
        void Cost(TShirt tshirt);
    }

}
