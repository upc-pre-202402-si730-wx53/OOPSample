using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample.Sales.Domain.Model.Aggregates
{
    public static class StringExtender
    {
        public static string ToLowerUuid(this string uuid)
        {
            return uuid.ToLower();
        }
    }
}
