using QLQA.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQA
{
    public partial class fPrintStaff : Form
    {
        public fPrintStaff()
        {
            InitializeComponent();
        }

        private void btnPrintStaff_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-02QEP2RN\\THANHTHAT;Initial Catalog=qlqa;Integrated Security=True");
            SqlCommand command = new SqlCommand("select * from staff", con);

            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataSet s = new DataSet();
            sd.Fill(s);

            rprListStaff sr = new rprListStaff();
            sr.SetDatabaseLogon("sa", "123456");
            sr.SetDataSource(s.Tables["table"]);
            crystalReportViewer1.ReportSource = sr;
        }
    }
}
