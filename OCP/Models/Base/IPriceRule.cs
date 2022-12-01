using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Models.Base
{
    public interface IPriceRule
    {
        bool IsMatch(OrderItem item);
        decimal CalculatePrice(OrderItem item);
    }
}
