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
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Index().Show();
        }

        private void Log_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            //Connection
            string connenctionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connenctionString);

            //Command (SQL)
            SqlCommand command = new SqlCommand("select * from log", connection);

            //Definig dataset and dataAdapter;
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dataset); //filling dataset using adapter.

            //showing dataset tabel in data grid view                
            this.stockTable.DataSource = dataset.Tables[0];

        }

        bool flag = false;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Connection
            string connenctionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connenctionString);

            //Command (SQL)
            SqlCommand command = new SqlCommand("select * from log", connection);

            //Definig dataset and dataAdapter;
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dataset); //filling dataset using adapter.

            int rows = dataset.Tables[0].Rows.Count;
            this.stockTable.DataSource = "";
            this.stockTable.DataSource = null;
            for (int i=0; i<rows; i++)
            { 
                if (dataset.Tables[0].Rows[i][0].ToString()==this.dateTimePicker.Text)
                {
                    string date = dataset.Tables[0].Rows[i][0].ToString();
                    string name = dataset.Tables[0].Rows[i][1].ToString();
                    string price = dataset.Tables[0].Rows[i][2].ToString();

                    stockTable.ColumnCount = 3;
                    stockTable.Columns[0].Name = "date";
                    stockTable.Columns[1].Name = "name";
                    stockTable.Columns[2].Name = "price";

                    string[] row = new string[] { date, name, price };
                    stockTable.Rows.Add(row);
                    stockTable.Columns["date"].Visible = true;
                    stockTable.Columns["name"].Visible = true;
                    stockTable.Columns["price"].Visible = true;

                    flag = true;
                }
            }

            this.label2.Text = "History of all PURCHASED Items so far.";
        }

        
        private void Log_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelled_Click(object sender, EventArgs e)
        {
            // Connection
            string connenctionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connenctionString);

            //Command (SQL)
            SqlCommand command = new SqlCommand("select * from canceled", connection);

            //Definig dataset and dataAdapter;
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dataset); //filling dataset using adapter.

            int rows = dataset.Tables[0].Rows.Count;
            this.stockTable.DataSource = "";
            this.stockTable.DataSource = null;
            for (int i = 0; i < rows; i++)
            {
                if (dataset.Tables[0].Rows[i][0].ToString() == this.dateTimePicker.Text)
                {
                    string date = dataset.Tables[0].Rows[i][0].ToString();
                    string name = dataset.Tables[0].Rows[i][1].ToString();
                    string price = dataset.Tables[0].Rows[i][2].ToString();

                    stockTable.ColumnCount = 3;
                    stockTable.Columns[0].Name = "date";
                    stockTable.Columns[1].Name = "name";
                    stockTable.Columns[2].Name = "price";

                    string[] row = new string[] { date, name, price };
                    stockTable.Rows.Add(row);
                    stockTable.Columns["date"].Visible = true;
                    stockTable.Columns["name"].Visible = true;
                    stockTable.Columns["price"].Visible = true;

                    flag = true;
                }
            }
            this.label2.Text = "History of all CANCELLED Items so far.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.stockTable.Columns["date"].Visible = false;
                this.stockTable.Columns["name"].Visible = false;
                this.stockTable.Columns["price"].Visible = false;
                flag = false;
            }
            getData();
            this.label2.Text = "History of all PURCHASED Items so far.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.stockTable.Columns["date"].Visible = false;
                this.stockTable.Columns["name"].Visible = false;
                this.stockTable.Columns["price"].Visible = false;
                flag = false;
            }
            //geeting all data from cancelled tabel

            //Connection
            string connenctionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connenctionString);

            //Command (SQL)
            SqlCommand command = new SqlCommand("select * from canceled", connection);

            //Definig dataset and dataAdapter;
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dataset); //filling dataset using adapter.

            //showing dataset tabel in data grid view                
            this.stockTable.DataSource = dataset.Tables[0];



            this.label2.Text = "History of all CANCELLED Items so far.";
        }
    }
}
