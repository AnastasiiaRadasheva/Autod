using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autod
{
    public partial class BaseForm : Form

    {
        protected void ApplyLanguage()
        {
            var res = new ComponentResourceManager(this.GetType());
            ApplyResourcesToControl(this, res);
            res.ApplyResources(this, "$this");
        }

        private void ApplyResourcesToControl(Control ctrl, ComponentResourceManager res)
        {
            res.ApplyResources(ctrl, ctrl.Name);

            foreach (Control child in ctrl.Controls)
            {
                ApplyResourcesToControl(child, res);
            }
        }
    }
}
