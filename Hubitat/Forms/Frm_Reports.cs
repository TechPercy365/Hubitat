using Microsoft.Reporting.WinForms;
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

namespace Hubitat.Forms
{
    public partial class Frm_Reports : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=HubitatDB;Integrated Security=True");

        public Frm_Reports()
        {
            InitializeComponent();
            LoadTransactionReports();
        }

        private void x_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_Home_Click(object sender, EventArgs e)
        {
            new Frm_AdminDashboard().Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            new Frm_AdminDashboard().Show();
            this.Hide();
        }

        private void Frm_Reports_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void LoadTransactionReports()
        {
            // Connection string to the SQL Server database
                try
                {
                    connection.Open();
                

                    SqlCommand command = new SqlCommand("SELECT * FROM Transactions", connection);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);


                    reportViewer1.LocalReport.DataSources.Clear();


                    ReportDataSource reportDataSource = new ReportDataSource("ReportDataSet", dataTable);


                    reportViewer1.LocalReport.ReportPath = "D:\\COLLEGE\\3rd Year\\2nd Sem\\IMDBSYS32\\Hubitat\\Hubitat\\Reports\\TransactionReports.rdlc";


                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);


                    reportViewer1.RefreshReport();


                    connection.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }
            
        }
    }
}
