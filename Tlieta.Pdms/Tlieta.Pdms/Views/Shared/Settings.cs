using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tlieta.Pdms.DataAccess;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class Settings : UserControl
    {
        public Settings(string serialkey)
        {
            InitializeComponent();

            lblProductKey.Text = serialkey;
        }

        private void btnAddHospital_Click(object sender, EventArgs e)
        {
            string name = txtHospitalName.Text.Trim();
            string location = txtLocation.Text.Trim();

            if (name == "" || location == "")
            {
                MessageBox.Show("Enter name and location");
                return;
            }
            else
            {
                bool result = new MasterData().AddHospital(name, location);
                if (result)
                {
                    txtHospitalName.Text = "";
                    txtLocation.Text = "";
                    MessageBox.Show("Hospital added successfully");
                }
                else
                {
                    MessageBox.Show("Cannot add hospital : contact Admin");
                }
            }
        }

        private void btnAddOperation_Click(object sender, EventArgs e)
        {
            string name = txtOperationName.Text.Trim();

            if (name == "" )
            {
                MessageBox.Show("Enter operation name");
                return;
            }
            else
            {
                bool result = new MasterData().AddOperation(name);
                if (result)
                {
                    txtOperationName.Text = "";
                    MessageBox.Show("Operation name added successfully");
                }
                else
                {
                    MessageBox.Show("Cannot add operation : contact Admin");
                }
            }
        }

        private void btnAddImplant_Click(object sender, EventArgs e)
        {
            string name = txtImplant.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Enter implant name");
                return;
            }
            else
            {
                bool result = new MasterData().AddImplant(name);
                if (result)
                {
                    txtImplant.Text = "";
                    MessageBox.Show("Implant name added successfully");
                }
                else
                {
                    MessageBox.Show("Cannot add implant : contact Admin");
                }
            }
        }

        private void btnAddGraftSize_Click(object sender, EventArgs e)
        {
            decimal size = 0;
            try
            {
                size = Convert.ToDecimal(txtGraftSize.Text.Trim());
            }
            catch { MessageBox.Show("Enter valid size"); return; }

            bool result = new MasterData().AddGraftSize(size);
            if (result)
            {
                txtGraftSize.Text = "";
                MessageBox.Show("Graft Size added successfully");
            }
            else
            {
                MessageBox.Show("Cannot add Graft Size : contact Admin");
            }
        }

        private void btnAddACLSubType_Click(object sender, EventArgs e)
        {
            string name = txtACLSubType.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Enter ACL SubType name");
                return;
            }
            else
            {
                bool result = new MasterData().AddACLSubType(name);
                if (result)
                {
                    txtACLSubType.Text = "";
                    MessageBox.Show("ACL SubType name added successfully");
                }
                else
                {
                    MessageBox.Show("Cannot add ACL SubType : contact Admin");
                }
            }
        }
    }
}
