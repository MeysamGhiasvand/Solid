using OCP.Models;
using OCP.Models.Base;
using OCP.StrategyPattern;

var cart = new Cart();
cart.Add(new OrderItem { Name = "Abb1", Quantity = 3 });
cart.Add(new OrderItem { Name = "Bbb1", Quantity = 6 });
cart.Add(new OrderItem { Name = "Cbb1", Quantity = 2 });


Console.WriteLine(cart.TotalAmount());

