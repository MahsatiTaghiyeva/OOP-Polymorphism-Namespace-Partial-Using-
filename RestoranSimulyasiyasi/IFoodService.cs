namespace RestoranSimulyasiyasi
{
public interface IFoodService
{
    DateTime WhenWillPrepared(Food food);
    int GetCountByCalories(Food[] foods, double n);
}
}