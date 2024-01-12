using System;
using System.Collections;
using System.Windows.Forms;
using Tekla.Structures.Model;
using ModelObjectSelector = Tekla.Structures.Model.UI.ModelObjectSelector;


namespace Buttons
{
    public partial class Buttons : Form
    {
        public Buttons()
        {
            InitializeComponent();
        }

        private void CopyNameToComment_Click(object sender, EventArgs e)
        {
            var mos = new ModelObjectSelector();
            var moe = mos.GetSelectedObjects();
            var partsToSelelect = new ArrayList();

            while (moe.MoveNext())
            {
                var part = moe.Current as Part;
                if (part == null)
                {
                    continue;
                }

                var name = part.Name;
                part.SetUserProperty("comment", name);
                mos.Select(new ArrayList() { part }, false);
                partsToSelelect.Add(part);
            }

            mos.Select(partsToSelelect, false);
        }

        private void CopyCommentToProductWebSite_Click(object sender, EventArgs e)
        {
            var mos = new ModelObjectSelector();
            var moe = mos.GetSelectedObjects();
            var partsToSelelect = new ArrayList();

            while (moe.MoveNext())
            {
                var part = moe.Current as Part;
                if (part == null)
                {
                    continue;
                }

                var comment = string.Empty;
                part.GetReportProperty("comment", ref comment);

                part.SetUserProperty("PRODUCT_WEBSITE", comment);
                mos.Select(new ArrayList() { part }, false);
                partsToSelelect.Add(part);
            }

            mos.Select(partsToSelelect, false);
        }
    }
}
