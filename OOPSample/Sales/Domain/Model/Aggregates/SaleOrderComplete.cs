using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample.Sales.Domain.Model.Aggregates
{
    class SaleOrderComplete : SalesOrder
    {
        private string status { get; set; }

        public SaleOrderComplete(int customerId, string customerName, double totalAmount, string _status)
            : base(customerId, customerName, totalAmount)
        {
            this.status = _status;
        }

        public string GetStatus()
        {
            return this.status;
        }

    }
}
