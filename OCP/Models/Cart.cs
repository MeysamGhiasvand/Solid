using OCP.Models.Base;

namespace OCP.Models;

public class Cart
{
    private readonly List<OrderItem> _items;
    private readonly IPricingCalculator _pricingCalculator;

    public Cart() : this(new PricingCalculator())
    {
    }

    public Cart(IPricingCalculator pricingCalculator)
    {
        _pricingCalculator = pricingCalculator;
        _items = new List<OrderItem>();
    }

    public IEnumerable<OrderItem> Items
    {
        get { return _items; }
    }

    public void Add(OrderItem orderItem)
    {
        _items.Add(orderItem);
    }

    public decimal TotalAmount()
    {
        decimal totalAmount = 0;
        foreach (OrderItem orderItem in Items)
        {
            totalAmount += _pricingCalculator.CalculatePrice(orderItem);
        }

        return totalAmount;
    }
}