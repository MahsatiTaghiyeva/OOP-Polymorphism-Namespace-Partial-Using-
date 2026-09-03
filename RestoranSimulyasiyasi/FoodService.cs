//IFoodService interfeysini implement edir.
//Yuxarıdakı metodların içi doldurulur.
namespace RestoranSimulyasiyasi
{
    public class FoodService : IFoodService
    {
        public  DateTime WhenWillPrepared(Food food)
        {
            return food.Created + food.PrepareTime;
        }
        public int GetCountByCalories(Food[] foods, double n)
        {
            int count =0;
            foreach(Food food in foods)
            {
                if(food.Calories > n)
                {
                    count++;
                }
            }
            return count;
        }
    }
}