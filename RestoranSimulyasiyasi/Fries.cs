using System;

namespace RestoranSimulyasiyasi
{
    public class Fries : Food
    {
        //IsSalty – Duzlu olub-olmaması (bool)
        //Weight – Çəki(qramla)
        public bool IsSalty { get; set; }
        public double Weight { get; set; }
        override public double CalcPrice()
        {
            double price = Weight/1000;
            if(IsSalty)
            {
                price += 0.8;
            }
            return price;
        }
        public Fries(string id, string name, DateTime created, TimeSpan prepareTime, double calories, bool isSalty, double weight) : base(id, name, created, prepareTime, calories)
        {
            IsSalty = isSalty;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"Fries: {Name}, Weight: {Weight}, IsSalty: {IsSalty}, Price: {CalcPrice()}";
        }
    }
}