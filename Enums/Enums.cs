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

        public enum SeriesEnum
        {
            [Display(Name = "2018")]
            s2018 = 2018,

            [Display(Name = "2019")]
            s2019 = 2019,

            [Display(Name = "2020")]
            s2020 = 2020
        }
    }
}