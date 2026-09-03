namespace RestoranSimulyasiyasi
{
    public class PizzaService : IPizzaService
    {
        public Pizza CreatePizza(string id,string name, DateTime created, TimeSpan prepareTime,  double calories,double radius, bool isHot)
        {
            return new Pizza(id, name, created, prepareTime, calories,radius,isHot);          
        }

        public Pizza GetBiggestRadiusPizza(Pizza[] pizzas)
        {
            Pizza biggest = pizzas[0];

            foreach (Pizza pizza in pizzas)
            {
                if (pizza.Radius > biggest.Radius)
                    biggest = pizza;
            }
            return biggest;
        }
    }
}