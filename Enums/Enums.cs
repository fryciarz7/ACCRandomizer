using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ACCRandomizer.Enums
{
    public class Enums
    {
        public enum CarClassEnum
        {
            [Display(Name = "Mixed")]
            Mixed = 0,

            [Display(Name = "Cup")]
            Cup = 1,

            [Display(Name = "ST")]
            ST = 2,

            [Display(Name = "GT3")]
            GT3 = 3,

            [Display(Name = "GT4")]
            GT4 = 4
        }
    }
}