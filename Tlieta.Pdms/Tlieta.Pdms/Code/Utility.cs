using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tlieta.Pdms.DataAccess;

namespace Tlieta.Pdms.Code
{
    public static class Utility
    {
        public static DataTable ConvertObjectToDataTable(List<Patient> vehicleDetailsList)
        {
            DataTable dt = new DataTable();
            try
            {
                dt.TableName = "data";

                foreach (PropertyInfo property in vehicleDetailsList[0].GetType().GetProperties())
                {
                    dt.Columns.Add(new DataColumn(property.Name, property.PropertyType));
                }

                foreach (var vehicle in vehicleDetailsList)
                {
                    DataRow newRow = dt.NewRow();
                    foreach (PropertyInfo property in vehicle.GetType().GetProperties())
                    {
                        newRow[property.Name] = vehicle.GetType().GetProperty(property.Name).GetValue(vehicle, null);
                    }
                    dt.Rows.Add(newRow);
                }
                return dt;
            }
            catch { return null; }
        }

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

        //public static int ValidateBirthDate(DateTime birthday)
        //{
        //    DateTime today = DateTime.Now;
        //    DateTime validDate = new DateTime(today.Year - 21, today.Month, today.Day);
        //    TimeSpan validAge = today.Subtract(validDate);
        //    TimeSpan actualAge = today.Subtract(birthday);
        //    return TimeSpan.Compare(validAge, actualAge);
        //}
    }
}
