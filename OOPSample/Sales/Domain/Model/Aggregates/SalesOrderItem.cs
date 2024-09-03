using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample.Sales.Domain.Model.Aggregates
{
    public class SalesOrderItem
    {
        private Guid ProductId { get; }
        private int Quantity { get; }
        private double Price { get; }

        
        public SalesOrderItem(int quantity, double price)
        {
            this.ProductId = GenerateOrderItemId();
            this.Quantity = quantity;
            this.Price = price;
        }

        public static Guid GenerateOrderItemId()
        {
            return Guid.NewGuid();
        }

        public static string UpperUuid(Guid uuid)
        {
            return uuid.ToString().ToUpper();
        }

        public double GetTotal()
        {
            return this.Quantity * this.Price;
        }

        public string getOrderItemString()
        {
            return $"Sales Item: UUID - {ProductId} - Total { GetTotal() }";
        }
    }
}
