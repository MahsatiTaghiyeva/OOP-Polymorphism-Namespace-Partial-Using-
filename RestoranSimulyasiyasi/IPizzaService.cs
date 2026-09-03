namespace RestoranSimulyasiyasi
{
    public interface IPizzaService{
        Pizza CreatePizza(string id,string name, DateTime created,  TimeSpan prepareTime, double calories, double radius,  bool isHot);
                   Pizza GetBiggestRadiusPizza(Pizza[] pizzas);
    }

}