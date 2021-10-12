using ShopsRUs.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopsRUs.API.Services

{
    public static class InvoiceService
    {
        public static decimal GetInvoiceAmount(AppUser user, IEnumerable<Item> products, Discount discount)
        {
            var amount = products
                        .Where(x => x.Category.ToLower() != "groceries")
                        .Sum(x => x.Amount * x.Quantity);

            var regularDiscount = 0.0m;

            if (user.Role.Name.ToLower() == "customer")
            {

                if (DateTime.Now.Year - user.CreatedAt.Year >= 2)
                {
                    regularDiscount =  CalculatePercentageDiscount(amount, discount) + products
                                       .Where(x => x.Category.ToLower() == "groceries")
                                       .Sum(x => x.Amount * x.Quantity);
                    return CalculateExtraDiscount(regularDiscount);
                }
                else
                {
                    amount = products.Sum(x => x.Amount * x.Quantity);
                    return CalculateExtraDiscount(amount);
                }

            }

            regularDiscount =  CalculatePercentageDiscount(amount, discount) + products
                               .Where(x => x.Category.ToLower() == "groceries")
                               .Sum(x => x.Amount * x.Quantity);
            
            return CalculateExtraDiscount(regularDiscount);
        }

        private static decimal CalculatePercentageDiscount(decimal amount, Discount discount) 
            => amount - amount * discount.Rate;

        private static decimal CalculateExtraDiscount(decimal amount)
            => amount - (Math.Floor(amount / 100) * 5);

    }
}
