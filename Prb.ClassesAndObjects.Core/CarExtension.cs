using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prb.ClassesAndObjects.Core
{
    public partial class Car
    {
        public override string ToString()
        {
            return $"{brand} - {color}";
        }
        public decimal PriceDifference(Car someCar)
        {
            return Math.Abs(this.price - someCar.price);
        }
        public static decimal PriceDifference(Car car1, Car car2)
        {
            return Math.Abs(car1.price - car2.price);
        }
    }
}
