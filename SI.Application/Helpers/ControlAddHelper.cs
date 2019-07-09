using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SI.App
{
    public static class ControlAddHelper
    {
        public static void AddControl(this Panel panel,UserControl control)
        {
            StaticProperties.HomePanel.Controls.Clear();
            StaticProperties.HomePanel.Controls.Add(control);
        }
    }
}
