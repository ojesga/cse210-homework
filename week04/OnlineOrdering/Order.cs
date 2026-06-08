using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        // Sums total product costs and adds baseline shipping fees ($5 domestic / $35 international)
        public double CalculateTotalOrderCost()
        {
            double total = 0;

            foreach (Product product in _products)
            {
                total += product.GetTotalCost();
            }

            double shippingCost = _customer.LivesInUsa() ? 5.00 : 35.00;
            total += shippingCost;

            return total;
        }

        // Packing label lists the name and product ID of each item
        public string GetPackingLabel()
        {
            string label = "--- PACKING LABEL ---\n";
            foreach (Product product in _products)
            {
                label += $"Item: {product.GetName()} (ID: {product.GetProductId()})\n";
            }
            return label;
        }

        // Shipping label lists customer name and their full formatted multi-line address
        public string GetShippingLabel()
        {
            string label = "--- SHIPPING LABEL ---\n";
            label += $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddressString()}\n";
            return label;
        }
    }
}