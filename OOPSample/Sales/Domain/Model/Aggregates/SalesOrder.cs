using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample.Sales.Domain.Model.Aggregates
{
    public class SalesOrder
    {
        private int CustomerId { get; set; }

        private string CustomerName { get; set; }

        private double? TotalAmount { get; set; }

        private double TotalAmountWithTax { get; set; }

        private const double TAX_RATE = 0.18;

        public SalesOrder()
        {
            this.CustomerId = 0;
            this.CustomerName = string.Empty;
            this.TotalAmount = null;
        }
        public SalesOrder(int customerId, string customerName, double totalAmount)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.TotalAmount = totalAmount;
            this.TotalAmountWithTax = totalAmount + (totalAmount * TAX_RATE);
        }

        public string getOrderString()
        {
            return "Sales Order: " + this.CustomerName + " - " + this.TotalAmount + " - " + this.TotalAmountWithTax;
        }

    }
}
