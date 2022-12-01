using OCP.Models.Rules;

namespace OCP.Models.Base
{
    public class PricingCalculator : IPricingCalculator
    {
        private readonly List<IPriceRule> _priceRules;
        public PricingCalculator()
        {
            _priceRules = new List<IPriceRule>();
            _priceRules.Add(new APriceRule());
            _priceRules.Add(new BPriceRule());
            _priceRules.Add(new CPriceRule());
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return _priceRules.First(r => r.IsMatch(item)).CalculatePrice(item);
        }
    }
}
