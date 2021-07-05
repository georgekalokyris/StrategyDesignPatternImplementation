using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.VariationStrategy;
using Assignment3.Models;
using Assignment3.PaymentMethodStrategy;

namespace Assignment3.EshopContext
{
    public class Eshop
    {
        private IEnumerable<IVariationStrategy> Variations { get; set; }

        private IPaymentMethod PaymentMethod { get; set; }

        public void SetVariation(IEnumerable<IVariationStrategy> variations)
        {
            Variations = variations;  
        }

        public void SetPaymentMethod(IPaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }



        public void PayTshirt(TShirt tshirt)
        {
            Console.WriteLine("\t\t T-Shirt Payment is in progress...");

            foreach (var variation in Variations)
            {
                variation.Cost(tshirt);
            }

            Console.WriteLine($"T-Shirt Final Price is {tshirt.Price} £");

            PaymentMethod.Pay(tshirt.Price);


        }





    }
}
