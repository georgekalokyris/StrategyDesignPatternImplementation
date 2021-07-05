using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Models;
using Assignment3.VariationStrategy;
using Assignment3.Enums;
using Assignment3.EshopContext;
using Assignment3.PaymentMethodStrategy;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eshop Business Layer

            IEnumerable<IVariationStrategy> ShopNormalVariation = new List<IVariationStrategy>()
            {
                new ColorVariationNormalStrategy(),
                new SizeVariationNormalStrategy(),
                new FabricVariationNormalStrategy()
            };
            
            IEnumerable<IVariationStrategy> DiscountNormalVariation = new List<IVariationStrategy>()
            {
                new ColorVariationNormalStrategy()
            };

            IEnumerable<IVariationStrategy> ExpensiveVariation = new List<IVariationStrategy>()
            {
                new FabricVariationExpensiveStrategy()
            };

            //Input logic //Creation logic
            Console.WriteLine("Welcome to the T-Shirt Shop :) ");
            Console.WriteLine("Create TShirt");

            //Logic color
            Console.WriteLine("Choose Color");

            int colorInput;

            Color finalcolor;

            var colors = Enum.GetNames(typeof(Color));

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"{i,-5}{colors[i]}");
            }

            colorInput = Convert.ToInt32(Console.ReadLine());

            finalcolor = (Color)(colorInput);

            Console.WriteLine(finalcolor);


            //Logic fabric
            Console.WriteLine("Choose Fabric");

            int fabricINput;

            Fabric finalFabric;

            var fabrics = Enum.GetNames(typeof(Fabric));

            for (int i = 0; i < fabrics.Length; i++)
            {
                Console.WriteLine($"{i,-5}{fabrics[i]}");
            }

            fabricINput = Convert.ToInt32(Console.ReadLine());

            finalFabric = (Fabric)(fabricINput);

            Console.WriteLine(finalFabric);


            
            //Logic size
            Console.WriteLine("Choose Fabric");

            int sizeInput;

            Size finalSize;

            var sizes = Enum.GetNames(typeof(Size));

            for (int i = 0; i < sizes.Length; i++)
            {
                Console.WriteLine($"{i,-5}{sizes[i]}");
            }

            sizeInput = Convert.ToInt32(Console.ReadLine());

            finalSize = (Size)(sizeInput);

            Console.WriteLine(sizeInput);



            TShirt tshirt = new TShirt(finalcolor, finalSize, finalFabric);

            Console.WriteLine("Choose Payment");

            Console.WriteLine("1- Debit");
            Console.WriteLine("2 - Bank Transfer");
            Console.WriteLine("3 - Cash");

            string paymentInput = Console.ReadLine();
            IPaymentMethod UserPaymentMethod;
            switch (paymentInput)
            {
                case "1": UserPaymentMethod =  new DebitStrategy(); break;
                case "2": UserPaymentMethod = new BankTransferStrategy(); break;
                case "3": UserPaymentMethod = new CashStrategy(); break;
                default: UserPaymentMethod = new CashStrategy();break;
            }

            var eshop = new Eshop();

            eshop.SetVariation(ExpensiveVariation);

            eshop.SetPaymentMethod(UserPaymentMethod);

            eshop.PayTshirt(tshirt);


        }
    }
}

