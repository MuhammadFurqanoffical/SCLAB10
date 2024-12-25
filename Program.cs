using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{


    public class CoffeeShop
    {
        // Encapsulated fields with properties
        private double _coffeePrice;
        private double _sandwichPrice;

        public double CoffeePrice
        {
            get => _coffeePrice;
            private set => _coffeePrice = value;
        }

        public double SandwichPrice
        {
            get => _sandwichPrice;
            private set => _sandwichPrice = value;
        }

        // Constructor to initialize menu prices
        public CoffeeShop(double coffeePrice, double sandwichPrice)
        {
            CoffeePrice = coffeePrice;
            SandwichPrice = sandwichPrice;
        }

        // Process an order for a customer
        public void ProcessOrder(string customerName, bool wantsCoffee, bool wantsSandwich)
        {
            double total = CalculateTotal(wantsCoffee, wantsSandwich);

            Console.WriteLine($"Order processed for {customerName}");
            Console.WriteLine($"Total amount to pay: {total}");

            ProcessPayment(total);
        }

        // Calculate the total cost of an order
        public double CalculateTotal(bool wantsCoffee, bool wantsSandwich)
        {
            double total = 0;

            if (wantsCoffee)
                total += CoffeePrice;

            if (wantsSandwich)
                total += SandwichPrice;

            return total;
        }

        // Process payment for the given amount
        private void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of {amount}");
        }

        // Update menu prices
        public void UpdateMenu(double newCoffeePrice, double newSandwichPrice)
        {
            CoffeePrice = newCoffeePrice;
            SandwichPrice = newSandwichPrice;

            Console.WriteLine("Menu prices updated!");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            CoffeeShop shop = new CoffeeShop(5.0, 7.0);

            shop.ProcessOrder("Muhammad Furqan", wantsCoffee: true, wantsSandwich: false);

            shop.UpdateMenu(newCoffeePrice: 6.0, newSandwichPrice: 8.0);

            shop.ProcessOrder("Tehzeeb Hafi", wantsCoffee: true, wantsSandwich: true);
        }
    }
}
