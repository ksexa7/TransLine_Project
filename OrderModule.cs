using System;

namespace TransLine
{
    public class Order
    {
        public string ClientName { get; set; }
        public double Weight { get; set; }

        public Order(string clientName, double weight)
        {
            ClientName = clientName;
            Weight = weight;
        }

        public double CalculatePrice()
        {
            // Базовая цена за кг (например, 50 рублей)
            return Weight * 50;
        }
    }
}
