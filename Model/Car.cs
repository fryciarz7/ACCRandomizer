using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACCRandomizer.Model
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public Enums.Enums.CarClassEnum CarClass { get; set; }
        public string CarImage { get; set; }
    }
}