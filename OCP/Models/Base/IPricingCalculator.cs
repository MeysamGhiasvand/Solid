using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Models.Base
{
    public interface IPricingCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}
