namespace RestoranSimulyasiyasi
{
    public interface IPizzaService{
        Pizza CreatePizza();
        Pizza GetBiggestRadiusPizza(Pizza[] pizzas);
    }

}