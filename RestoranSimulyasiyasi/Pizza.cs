using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranSimulyasiyasi
{
    public class Pizza : Food
    {
        //Radius
        //IsHot – Acılı olub-olmaması(bool)
        public double Radius { get; set; }
        public bool IsHot { get; set; }
        override public double CalcPrice()
        {
            double price = Radius*Radius*3.14*0.10;
            if(IsHot)
            {
                price += 1.15;
            }
            return price;
        }
        public Pizza(string id, string name, DateTime created, TimeSpan prepareTime, double calories, double radius, bool isHot): base(id, name, created, prepareTime, calories)
        {
            Radius = radius;
            this.IsHot = isHot;
        }
        
        public override string ToString()
        {
            return $"Pizza: {Name}, Radius: {Radius}, IsHot: {IsHot}, Price: {CalcPrice()}";
        }

    }
}