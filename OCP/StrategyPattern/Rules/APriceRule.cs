﻿using OCP.Models.Base;

namespace OCP.Models.Rules;

public class APriceRule : IPriceRule
{
    public decimal CalculatePrice(OrderItem item)
    {
        return item.Quantity * 2;
    }

    public bool IsMatch(OrderItem item)
    {
        return item.Name.StartsWith("A");
    }
}