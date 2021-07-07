using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public class DateAttribute : RangeAttribute
    {
        public DateAttribute () : base(typeof(DateTime), DateTime.Now.AddYears(1880 - DateTime.Now.Year).ToShortDateString(), DateTime.Now.ToShortDateString())
        {

        }
    }
}
