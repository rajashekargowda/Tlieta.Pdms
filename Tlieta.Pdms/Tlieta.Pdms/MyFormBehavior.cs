using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Tlieta.Pdms
{
    public class MyFormBehavior : RadFormBehavior
    {
        public MyFormBehavior(IComponentTreeHandler treeHandler, bool shouldCreateChildren) :
            base(treeHandler, shouldCreateChildren)
        {
        }

        public override Padding BorderWidth
        {
            get
            {
                return new Padding(1);
            }
        }
    }
}
