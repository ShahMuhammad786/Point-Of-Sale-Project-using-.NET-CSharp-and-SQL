using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*** For available items label ***/

            //Connection
            string connenctionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connenctionString);

            //Command (SQL)
            SqlCommand command = new SqlCommand("select * from stock", connection);

            //Definig dataset and dataAdapter;
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dataset); //filling dataset using adapter.
            dataset.Tables[0].TableName = "stock";

            //Row counting
            int  rows = dataset.Tables[0].Rows.Count;
            this.available.Text = rows+" Items ";

            /*** For total price ***/
            //Connection
            SqlConnection connection2 = new SqlConnection(connenctionString);

            //Command (SQL)
            command = new SqlCommand("select * from log", connection);

            //Definig dataset and dataAdapter;
            sda = new SqlDataAdapter(command);
            sda.Fill(dataset); //filling dataset using adapter.

            int totRows = dataset.Tables[1].Rows.Count;
            double totPrice = 0.0;
            for (int i=0; i<totRows; i++)
            {
                totPrice += Convert.ToDouble(dataset.Tables[1].Rows[i]["price"]);
            }

            this.totPrice.Text = totPrice + "pkr";
            this.itemPurchased.Text = totRows + " Items ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you really want to Exit App?",
                                       "Exit App Confirmation",
                                       MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                new login().Show();
                this.Hide();
            }
           
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            new StockManagement().Show();
            this.Hide();            
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            new Log().Show();
            this.Hide();           
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            new BuyScanner().Show();
            this.Hide();           
        }

        private void btnManual_Click_1(object sender, EventArgs e)
        {
            new BuyManual().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new addUsers().Show();
            this.Hide();
        }
    }
}
