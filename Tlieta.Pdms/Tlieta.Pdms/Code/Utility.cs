using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tlieta.Pdms.DataAccess;

namespace Tlieta.Pdms.Code
{
    public static class Utility
    {
        //public static DataTable ConvertObjectToDataTable(List<Patient> vehicleDetailsList)
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        dt.TableName = "data";

        //        foreach (PropertyInfo property in vehicleDetailsList[0].GetType().GetProperties())
        //        {
        //            dt.Columns.Add(new DataColumn(property.Name, property.PropertyType));
        //        }

        //        foreach (var vehicle in vehicleDetailsList)
        //        {
        //            DataRow newRow = dt.NewRow();
        //            foreach (PropertyInfo property in vehicle.GetType().GetProperties())
        //            {
        //                newRow[property.Name] = vehicle.GetType().GetProperty(property.Name).GetValue(vehicle, null);
        //            }
        //            dt.Rows.Add(newRow);
        //        }
        //        return dt;
        //    }
        //    catch { return null; }
        //}
    }
}
