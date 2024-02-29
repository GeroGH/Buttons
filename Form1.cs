using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;
using Tekla.Structures.Model;
using ModelObjectSelector = Tekla.Structures.Model.UI.ModelObjectSelector;

namespace Buttons
{
    public partial class Buttons : Form
    {
        public Buttons()
        {
            this.InitializeComponent();
        }

        private void CopyNameToComment_Click(object sender, EventArgs e)
        {
            //var mos = new ModelObjectSelector();
            //var moe = mos.GetSelectedObjects();
            //var partsToSelelect = new ArrayList();

            //while (moe.MoveNext())
            //{
            //    var part = moe.Current as Part;
            //    if (part == null)
            //    {
            //        continue;
            //    }

            //    var name = part.Name;
            //    part.SetUserProperty("comment", name);
            //    mos.Select(new ArrayList() { part }, false);
            //    partsToSelelect.Add(part);
            //}

            //mos.Select(partsToSelelect, false);
        }

        private void CopyCommentToProductWebSite_Click(object sender, EventArgs e)
        {
            //var mos = new ModelObjectSelector();
            //var moe = mos.GetSelectedObjects();
            //var partsToSelelect = new ArrayList();

            //while (moe.MoveNext())
            //{
            //    var part = moe.Current as Part;
            //    if (part == null)
            //    {
            //        continue;
            //    }

            //    var comment = string.Empty;
            //    part.GetReportProperty("comment", ref comment);

            //    part.SetUserProperty("PRODUCT_WEBSITE", comment);
            //    mos.Select(new ArrayList() { part }, false);
            //    partsToSelelect.Add(part);
            //}

            //mos.Select(partsToSelelect, false);
        }

        private void UpdateFields_Click(object sender, EventArgs e)
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

                var cells = this.DataGridView.CurrentRow.Cells;

                foreach (DataGridViewCell cell in cells)
                {
                    var columnName = this.DataGridView.Columns[cell.ColumnIndex].Name;
                    var value = cell.Value.ToString();

                    part.SetUserProperty(columnName, value);
                }

                mos.Select(new ArrayList() { part }, false);
                partsToSelelect.Add(part);
            }

            mos.Select(partsToSelelect, false);
        }

        private void Buttons_Load(object sender, EventArgs e)
        {
            using (var stream = File.Open(@"C:\Users\gergan.gospodinov\OneDrive - Bourne Group\TeklaStructuresModels_2023\3375-1 South Ruislip Head House\HS2 Asset Data.xlsx", FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var conf = new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = config => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        }
                    };

                    var dataSet = reader.AsDataSet(conf);
                    var dataTableCollection = dataSet.Tables;
                    var AssetClasses = dataTableCollection["Asset Classes"];
                    this.DataGridView.DataSource = AssetClasses;
                    this.DataGridView.RowHeadersVisible = false;
                    this.DataGridView.AllowUserToResizeRows = false;
                    this.DataGridView.ReadOnly = true;
                    this.DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    this.DataGridView.MultiSelect = false;
                }
            }
        }

        private void DeleteFields_Click(object sender, EventArgs e)
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

                var columns = this.DataGridView.Columns;

                foreach (DataGridViewColumn column in columns)
                {
                    var columnName = column.Name;
                    part.SetUserProperty(columnName, "");
                }

                mos.Select(new ArrayList() { part }, false);
                partsToSelelect.Add(part);
            }

            mos.Select(partsToSelelect, false);
        }
    }
}
