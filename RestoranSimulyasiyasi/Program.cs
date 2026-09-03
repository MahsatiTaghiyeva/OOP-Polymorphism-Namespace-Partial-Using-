using System;
using RestoranSimulyasiyasi;

FoodService foodService = new FoodService();
PizzaService pizzaService = new PizzaService();
Pizza pizza1 = pizzaService.CreatePizza(
    "1",
    "Margherita",
    new DateTime(2025, 5, 16, 18, 30, 20),
    new TimeSpan(0, 15, 0),
    500,
    12,
    true
);

Pizza pizza2 = pizzaService.CreatePizza(
    "2",
    "Pepperoni",
    new DateTime(2025, 5, 16, 17, 00, 00),
    new TimeSpan(0, 20, 0),
    700,
    15,
    false
);
Fries fries1 = new Fries(
    "3",
    "French Fries",
    new DateTime(2025, 5, 16, 18, 00, 00),
    new TimeSpan(0, 10, 0),
    300,
    true,
    150
);

Console.WriteLine(pizza1);

Console.WriteLine(fries1);

Console.WriteLine($"Pizza price: {pizza1.CalcPrice():F2} AZN");
Console.WriteLine($"Fries price: {fries1.CalcPrice():F2} AZN");
Console.WriteLine(foodService.WhenWillPrepared(pizza1));

Food[] foods = { pizza1, pizza2, fries1 };

int count = foodService.GetCountByCalories(foods, 400);

Console.WriteLine($"Calories > 400: {count}");

Console.WriteLine();

Pizza[] pizzas = { pizza1, pizza2 };

Pizza biggestPizza = pizzaService.GetBiggestRadiusPizza(pizzas);

Console.WriteLine(biggestPizza);

