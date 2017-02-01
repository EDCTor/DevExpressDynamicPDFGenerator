using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraReports.UI;

namespace DevExpressDynamicPDFGenerator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Simulate Real Data
        /// </summary>
        /// <returns>A DataSet that simulates a real data object</returns>
        public DataSet FillDataset()
        {
            DataSet ds = new DataSet();
            ds.DataSetName = "ticket";
            DataTable dt = new DataTable();

            ds.Tables.Add(dt);

            dt.TableName = "Ticket";

            // ticket information
            dt.Columns.Add("TicketNumber", typeof(string));
            dt.Columns.Add("IssueDate", typeof(DateTime));
            dt.Columns.Add("BadgeNumber", typeof(string));
            dt.Columns.Add("UnitID", typeof(string));
            dt.Columns.Add("CPI", typeof(string));
            dt.Columns.Add("PublicComments", typeof(string));
            dt.Columns.Add("PrivateComments", typeof(string));
            dt.Columns.Add("MeterNumber", typeof(string));
            dt.Columns.Add("BlockNumber", typeof(string));
            dt.Columns.Add("Direction", typeof(string));
            dt.Columns.Add("PrecinctCode", typeof(string));
            dt.Columns.Add("LocationDesc", typeof(string));
            // vehicle information
            dt.Columns.Add("PlateNumber", typeof(string));
            dt.Columns.Add("PlateState", typeof(string));
            dt.Columns.Add("PlateType", typeof(string));
            dt.Columns.Add("VIN", typeof(string));
            dt.Columns.Add("PermitNumber", typeof(string));
            dt.Columns.Add("RegExpDate", typeof(DateTime));
            dt.Columns.Add("RegNumber", typeof(string));
            dt.Columns.Add("VIN4", typeof(string));
            dt.Columns.Add("Year", typeof(string));
            dt.Columns.Add("MakeCode", typeof(string));
            dt.Columns.Add("ModelCode", typeof(string));
            dt.Columns.Add("ColorCode", typeof(string));
            dt.Columns.Add("BodyCode", typeof(string));
            // violation information
            dt.Columns.Add("ByLawCode", typeof(string));
            dt.Columns.Add("ByLawDesc", typeof(string));
            dt.Columns.Add("ViolationCode1", typeof(string));
            dt.Columns.Add("ViolationSection1", typeof(string));
            dt.Columns.Add("ViolationDesc1", typeof(string));
            dt.Columns.Add("ViolationAmount1", typeof(decimal));
            dt.Columns.Add("ViolationCode2", typeof(string));
            dt.Columns.Add("ViolationSection2", typeof(string));
            dt.Columns.Add("ViolationDesc2", typeof(string));
            dt.Columns.Add("ViolationAmount2", typeof(decimal));
            dt.Columns.Add("ViolationCode3", typeof(string));
            dt.Columns.Add("ViolationSection3", typeof(string));
            dt.Columns.Add("ViolationDesc3", typeof(string));
            dt.Columns.Add("ViolationAmount3", typeof(decimal));
            dt.Columns.Add("TotalAmount", typeof(decimal));
            // late fees or discounts
            dt.Columns.Add("UpliftDate", typeof(DateTime));
            dt.Columns.Add("UpliftAmount", typeof(decimal));
            dt.Columns.Add("DiscountDate", typeof(DateTime));
            dt.Columns.Add("DiscountAmount", typeof(decimal));
            // passes
            dt.Columns.Add("PassExpiration", typeof(DateTime));
            dt.Columns.Add("PassElapsed", typeof(string));
#warning TODO: hit object, images

            ds.Tables["Ticket"].Rows.Add(new Object[] {
                "17X00001", DateTime.Now, "100", "A", "V", "Next violation will be tow",
                "Abusive language", "Meter 12", "500","N","MAIN","EDC SURFACE LOT",
                "ABC123","NY","PAS","VIN123456789012345","P1234", new DateTime(2020,12,1), "R11111",
                "VIN4","2017","FORD","TAURUS","BLACK","4DRSD","PV", "Parking Violations",
                "001","1.0(a)(a)", "METER VIOLATION", 10.00,
                "002", "DOUBLE PARKED", "2.1(i)", 10.00,
                "003", "2.3(ii)", "FAILURE TO DISPLAY", 10.00,
                10.00,
                DateTime.Now.AddDays(14), 25.00, DateTime.Now.AddDays(7), 5.00,
                DateTime.Now, "15m"
            });
            return ds;
        }

        /// <summary>
        /// Allow a method to edit the report format, spawns a modal form with the report designer control.
        /// Allows for edit and save of repx files
        /// </summary>
        private void btnDesigner_Click(object sender, EventArgs e)
        {
            myXtraReport r = new myXtraReport();
            r.DataSource = FillDataset().Tables["Ticket"];
            r.LoadLayout(Application.StartupPath + "\\XtraReport1.repx");
            
            ReportDesignTool designTool = new ReportDesignTool(r);
            designTool.ShowRibbonDesignerDialog();
        }

        /// <summary>
        /// Allow a method for testing without the designer, a preview of sorts
        /// From here you can print or export
        /// </summary>
        private void btnPreview_Click(object sender, EventArgs e)
        {
            myXtraReport r = new myXtraReport();
            r.DataSource = FillDataset().Tables["Ticket"];
            r.LoadLayout(Application.StartupPath + "\\XtraReport1.repx");

            ReportPrintTool printTool = new ReportPrintTool(r);
            printTool.ShowPreview();
        }

        /// <summary>
        /// Purpose built function to merge the data with the template and generate a PDF
        /// </summary>
        private void btnPDF_Click(object sender, EventArgs e)
        {
            myXtraReport r = new myXtraReport();
            r.DataSource = FillDataset().Tables["Ticket"];
            r.LoadLayout(Application.StartupPath + "\\XtraReport1.repx");

            r.ExportToPdf(Application.StartupPath + "\\sample.pdf");

            MessageBox.Show("PDF written to: " + Application.StartupPath + "\\sample.pdf");
        }
    }
}
