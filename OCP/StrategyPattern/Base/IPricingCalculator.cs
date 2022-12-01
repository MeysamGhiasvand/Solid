namespace OCP.Models.Base;

public interface IPricingCalculator
{
    decimal CalculatePrice(OrderItem item);
}