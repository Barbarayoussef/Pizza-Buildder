using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Buildder
{
    public class Order
    {
        private string orderType;
        private decimal tips=0m;
        private DateTime orderDateTime;
        Customer customer =new Customer();
        Pizza pizza = new Pizza();

        public decimal Tips { get { return tips; } set { tips = value; } }
        public string OrderType { get { return orderType; } set { orderType = value; } }
        public DateTime OrderDateTime { get { return orderDateTime; } set { orderDateTime = DateTime.Now;  } }
        public Customer Customer { get { return customer; } }
        public Pizza Pizza { get { return pizza; } }

        private Dictionary<string, decimal> SizeCosts = new Dictionary<string, decimal>
        {
        {"Small", 8.00m},
        {"Medium", 10.00m},
        {"Large", 12.00m},
        {"Extra-Large", 14.00m}
        };

        private Dictionary<string, decimal> CrustCosts = new Dictionary<string, decimal>
        {
            {"Regular Crust", 0.00m},
            {"Stuffed Crust", 2.00m},
            {"Deep Dish", 1.50m},
            {"Thin Crust", 0.75m},
            {"Cheesy Garlic Butter Crust", 2.50m}
        };
        private Dictionary<string, decimal> SauceCosts = new Dictionary<string, decimal>
        {
            {"Tomato", 0.00m},
            {"White", 0.50m},
            {"Pesto", 1.00m},
            {"Barbecue", 1.00m},
            {"Alfredo", 0.75m},
            {"Garlic", 0.25m},
            {"Buffalo", 1.00m},
            {"Ranch", 0.75m},
            {"Creamy Parmesan", 1.25m},
            {"Teriyaki", 1.50m}
        };
        private Dictionary<string, decimal> ToppingCosts = new Dictionary<string, decimal>
        {
            {"Pepperoni", 1.00m},
            {"Sausage", 1.00m},
            {"Bacon", 1.25m},
            {"Ham", 1.00m},
            {"Onions", 0.50m},
            {"Peppers", 0.50m},
            {"Olives", 0.75m},
            {"Mushrooms", 0.75m},
            {"Pineapple", 0.75m},
            {"Tomatoes", 0.75m}
        };
        private Dictionary<string, decimal> PremiumAdditionCosts = new Dictionary<string, decimal>
        {
            {"Extra Cheese", 1.00m},
            {"Extra Meat", 1.50m},
            {"Gluten-Free Crust", 2.00m},
            {"Vegan Cheese", 1.50m},
            {"Truffle Oil", 2.50m},
            {"Sun-Dried Tomatoes", 1.75m},
            {"Roasted Garlic", 1.00m},
            {"Caramelized Onions", 1.00m},
            {"Smoked Salmon", 2.50m},
            {"Pine Nuts", 1.75m}
        };

        public Order(Customer _customer, Pizza _pizza, string deliveryOrPickup, decimal tip )
        {
            customer = _customer;
            pizza = _pizza;
            orderType = deliveryOrPickup;
            tips = tip;
            OrderDateTime = DateTime.Now;
        }
        public decimal CalculateTheCost()
        {
            decimal totalCost = 0m;

            // Adding size cost
            if (SizeCosts.ContainsKey(pizza.Size))
            {
                totalCost += SizeCosts[pizza.Size];
            }

            // Adding crust cost
            if (CrustCosts.ContainsKey(pizza.CrustType))
            {
                totalCost += CrustCosts[pizza.CrustType];
            }

            // Adding sauce cost
            if (SauceCosts.ContainsKey(pizza.SauseSelection))
            {
                totalCost += SauceCosts[pizza.SauseSelection];
            }

            // Adding topping costs
            foreach (string toppingValue in pizza.Toppings)
            {
                    totalCost += ToppingCosts[toppingValue];
            }

            // Adding premium addition costs
            if (pizza.Additions.Count > 0)
            {
                foreach (string additionValue in pizza.Additions)
                {
                    totalCost += PremiumAdditionCosts[additionValue];

                }
            }
            decimal tax = 0.20m;
            totalCost = totalCost * tax;
            totalCost += tips;

            return totalCost;
        }
       /* public string CustomerInformation()
        {
            string CustomerInformationData = "Name : " + customer.Name + "\n"
                + "Address : " + customer.Address + "\n"
                + "Phone : " + customer.Phone + "\n"
                + "City : " + customer.City + "\n"
                + "State : " + customer.State + "\n"
                + "Zip : " + customer.Zip + "\n";
            return CustomerInformationData;

        }*/

       





    }
}
