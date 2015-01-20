using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Biodata
    {

        partial void Age_Compute(ref int result)
        {
            var today = DateTime.Today;
            result = today.Year - DateOfBirth.Year;
            if (DateOfBirth > today.AddYears(-result)) result--;
            // Set result to the desired field value

        }
    }
}
