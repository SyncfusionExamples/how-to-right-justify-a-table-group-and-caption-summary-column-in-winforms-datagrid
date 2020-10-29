using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Styles;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid.Renderers;
using Syncfusion.WinForms.GridCommon.ScrollAxis;
using System.Drawing;
using System.Collections.ObjectModel;

namespace SfDataGridDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SalesInfoCollection sales = new SalesInfoCollection();

            sfDataGrid.DataSource = sales.YearlySalesDetails;
            this.sfDataGrid.ShowGroupDropArea = true;
            sfDataGrid.AllowResizingColumns = true;
            this.sfDataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;            
            this.sfDataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = "Name" });
            this.sfDataGrid.ExpandAllGroup();
            //Table Summary Row
            GridTableSummaryRow tableSummaryRow1 = new GridTableSummaryRow();
            tableSummaryRow1.Name = "TableSummary";
            tableSummaryRow1.ShowSummaryInRow = false;
            tableSummaryRow1.Position = VerticalPosition.Top;

            GridSummaryColumn summaryColumn1 = new GridSummaryColumn();
            summaryColumn1.Name = "Q1";
            summaryColumn1.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn1.Format = "Total Value of Q1 : {Sum:c}";
            summaryColumn1.MappingName = "Q1";

            tableSummaryRow1.SummaryColumns.Add(summaryColumn1);

            this.sfDataGrid.TableSummaryRows.Add(tableSummaryRow1);

            // Creates the GridSummaryRow.
            GridSummaryRow groupSummaryRow1 = new GridSummaryRow();
            groupSummaryRow1.Name = "GroupSummary";
            groupSummaryRow1.ShowSummaryInRow = false;

            // Creates the GridSummaryColumn.
            GridSummaryColumn groupSummaryColumn = new GridSummaryColumn();
            groupSummaryColumn.Name = "Q3";
            groupSummaryColumn.SummaryType = SummaryType.DoubleAggregate;
            groupSummaryColumn.Format = "Total Value of Q3 : {Sum:c}";
            groupSummaryColumn.MappingName = "Q3";

            // Adds the GridSummaryColumn in SummaryColumns collection.
            groupSummaryRow1.SummaryColumns.Add(groupSummaryColumn);

            // Adds the summary row in the GroupSummaryRows collection.
            this.sfDataGrid.GroupSummaryRows.Add(groupSummaryRow1);


            // Creates the GridSummaryRow.
            GridSummaryRow captionSummaryRow = new GridSummaryRow();
            captionSummaryRow.Name = "CaptionSummary";
            captionSummaryRow.ShowSummaryInRow = false;

            // Creates the GridSummaryColumn.
            GridSummaryColumn captionSummaryColumn1 = new GridSummaryColumn();
            captionSummaryColumn1.Name = "Q2";
            captionSummaryColumn1.SummaryType = SummaryType.DoubleAggregate;
            captionSummaryColumn1.Format = "Total Value of Q2 : {Sum:c}";
            captionSummaryColumn1.MappingName = "Q2";

            GridSummaryColumn captionSummaryColumn2 = new GridSummaryColumn();
            captionSummaryColumn2.Name = "Q4";
            captionSummaryColumn2.SummaryType = SummaryType.Int32Aggregate;
            captionSummaryColumn2.Format = "Total Value of Q4 : {Sum:c}";
            captionSummaryColumn2.MappingName = "Q4";

            // Adds the summary column in the SummaryColumns collection.
            captionSummaryRow.SummaryColumns.Add(captionSummaryColumn1);
            captionSummaryRow.SummaryColumns.Add(captionSummaryColumn2);

            // Initializes the caption summary row.
            this.sfDataGrid.CaptionSummaryRow = captionSummaryRow;

            // justify the values to be right in the summary rows 
            this.sfDataGrid.Style.TableSummaryRowStyle.HorizontalAlignment = HorizontalAlignment.Right;
            this.sfDataGrid.Style.GroupSummaryRowStyle.HorizontalAlignment = HorizontalAlignment.Right;
            this.sfDataGrid.Style.CaptionSummaryRowStyle.HorizontalAlignment = HorizontalAlignment.Right;

            this.sfDataGrid.LiveDataUpdateMode = LiveDataUpdateMode.AllowSummaryUpdate | LiveDataUpdateMode.AllowDataShaping | LiveDataUpdateMode.AllowChildViewUpdate;
        }
    }
}
