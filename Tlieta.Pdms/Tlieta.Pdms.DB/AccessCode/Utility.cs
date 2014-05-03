using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace Tlieta.Pdms.DB
{
    public static class Utility
    {
        public static int GetAgeFromDob(DateTime dob)
        {
            int age = 0;
            try
            {
                age = Convert.ToInt32(Math.Truncate(DateTime.Now.Subtract(dob).TotalDays * (1 / 365.242199)));
            }
            catch { }
            return age;
        }
    }
}
