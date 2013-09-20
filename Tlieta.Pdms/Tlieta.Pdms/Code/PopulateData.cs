using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using Tlieta.Pdms.DataAccess;

namespace Tlieta.Pdms.Views.Shared
{
    static class PopulateData
    {
        public static void PopulateHospital(RadDropDownList ddl)
        {
            DataTable dt = new MasterData().GetHospitals();
            dt.Rows.InsertAt(dt.NewRow(), 0); dt.Rows[0][0] = "0"; dt.Rows[0][1] = "Select Hospital";
            ddl.DataSource = dt;
            ddl.ValueMember = "HospitalId";
            ddl.DisplayMember = "HospitalName";
        }

        public static void PopulateOperations(RadDropDownList ddl)
        {
            DataTable dt = new MasterData().GetOperations();
            dt.Rows.InsertAt(dt.NewRow(), 0); dt.Rows[0][0] = "0"; dt.Rows[0][1] = "Select Operation";
            ddl.DataSource = dt;
            ddl.ValueMember = "OperationId";
            ddl.DisplayMember = "OperationName";
        }

        public static void PopulateImplants(RadDropDownList ddl)
        {
            DataTable dt = new MasterData().GetImplants();
            dt.Rows.InsertAt(dt.NewRow(), 0); dt.Rows[0][0] = "0"; dt.Rows[0][1] = "Select Implant";
            ddl.DataSource = dt;
            ddl.ValueMember = "ImplantId";
            ddl.DisplayMember = "ImplantName";
        }

        public static void PopulateGraftSize(RadDropDownList ddl)
        {
            DataTable dt = new MasterData().GetGraftSizes();
            dt.Rows.InsertAt(dt.NewRow(), 0); dt.Rows[0][0] = "0"; dt.Rows[0][1] = "0";
            ddl.DataSource = dt;
            ddl.ValueMember = "GraftSizeId";
            ddl.DisplayMember = "GraftSizeValue";
        }

        public static void PopulateACLSubType(RadDropDownList ddl)
        {
            DataTable dt = new MasterData().GetACLSubTypes();
            dt.Rows.InsertAt(dt.NewRow(), 0); dt.Rows[0][0] = "0"; dt.Rows[0][1] = "Select ACL SubType";
            ddl.DataSource = dt;
            ddl.ValueMember = "ACLSubTypeId";
            ddl.DisplayMember = "ACLSubTypeName";
        }

        public static void SelectDropDownItem(RadDropDownList ddl, string value)
        {
            foreach (RadListDataItem item in ddl.Items)
            {
                if (item.Value.ToString() == value)
                {
                    item.Selected = true; return;
                }
            }
        }

        public static void SelectListItem(RadListControl lst, string[] values)
        {
            foreach (RadListDataItem item in lst.Items)
            {
                if(values.Contains(item.Value.ToString()))
                {
                    item.Selected = true;
                }
            }
        }
    }
}
