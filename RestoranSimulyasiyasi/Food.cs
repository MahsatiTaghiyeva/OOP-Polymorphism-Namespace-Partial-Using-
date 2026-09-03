using System;

namespace RestoranSimulyasiyasi
{
    
        public abstract class Food
        {
            //Id
            //Name – Məhsulun adı
            //Created – Məhsulun yaranma vaxtı(gələcək tarix ola bilməz)
            //PrepareTime – Hazırlanma müddəti(TimeSpan)
            //Calories – Kalori dəyəri(double tipində, mənfi ola bilməz)
            public string Id { get; set; }
            public string Name { get; set; }
            private DateTime _created; 
            public DateTime Created 
            { 
                get => _created; 
                set 
                { 
                    if (value > DateTime.Now) 
                    { 
                        Console.WriteLine("Created gələcək tarix ola bilməz.");
                    } 
                    else 
                    {
                         _created = value; 
                    } } }            
            public TimeSpan PrepareTime { get; set; }
            private double _calories;
            public double Calories
            {
                get => _calories;
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Mənfi ola bilməz");
                    }
                    else
                    {
                        _calories = value;
                    }
                }
            }
        protected Food(string id, string name, DateTime created, TimeSpan prepareTime, double calories)
        {
            Id = id;
            Name = name;
            Created = created;
            PrepareTime = prepareTime;
            Calories = calories;
        }
        //CalcPrice() – Qiyməti hesablamaq üçün abstract metod
        public abstract double CalcPrice();


        
    }
}