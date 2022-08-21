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
    public partial class addUsers : Form
    {
        public addUsers()
        {
            InitializeComponent();
        }

        private void addUsers_Load(object sender, EventArgs e)
        {
            //Connection
            string connenctionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connenctionString);

            //Command (SQL)
            SqlCommand command = new SqlCommand("select * from users", connection);

            //Definig dataset and dataAdapter;
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dataset); //filling dataset using adapter.

            //showing dataset tabel in data grid view            
            this.stockTable.DataSource = dataset.Tables[0];


            this.txtID.Text = "Enter user's ID...";
            this.txtPass.Text = "Enter user's Password...";
        }

        private void addUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            new Index().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Connection
            string connenctionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connenctionString);

            //Command (SQL)
            SqlCommand command = new SqlCommand("select * from users", connection);

            //Definig dataset and dataAdapter;
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dataset); //filling dataset using adapter.
            dataset.Tables[0].TableName = "users";

            DataRow drow = dataset.Tables["users"].NewRow();

            //Row index finding
            int lastRowIndex = 0;
            foreach (DataRow row in dataset.Tables["users"].Rows)
            {
                if (row[0].ToString() == this.txtID.Text)
                {
                    lastRowIndex = (int)dataset.Tables["stock"].Rows.IndexOf(row);
                    break;
                }
            }

            if ((string)dataset.Tables[0].Rows[lastRowIndex][0] == this.txtID.Text)
            {
                MessageBox.Show("Item Already Exist !");
            }
            else
            {
                drow[0] = this.txtID.Text;
                drow[1] = this.txtPass.Text;

                dataset.Tables["users"].Rows.Add(drow);
                try
                {
                    SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                    sda.Update(dataset.Tables["users"]);

                    //showing dataset tabel in data grid view            
                    this.stockTable.DataSource = dataset.Tables[0];
                    MessageBox.Show("Inserted new Row !");
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Connection
            string connenctionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connenctionString);

            //Command (SQL)
            SqlCommand command = new SqlCommand("select * from users", connection);

            //Definig dataset and dataAdapter;
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dataset); //filling dataset using adapter.
            dataset.Tables[0].TableName = "users";

            //Updating in dataset 
            int lastRowIndex = 0;
            foreach (DataRow row in dataset.Tables["users"].Rows)
            {
                if (row[0].ToString() == this.txtID.Text)
                {
                    lastRowIndex = (int)dataset.Tables["users"].Rows.IndexOf(row);
                    break;
                }
            }

            DialogResult result1 = MessageBox.Show("Do you really want to Remove User?",
                                       "User removal Confirmation",
                                       MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                dataset.Tables["users"].Rows[lastRowIndex].Delete();

                try
                {
                    //Update into database tabel
                    SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                    sda.Update(dataset.Tables["users"]);

                    //Showing updated records
                    this.stockTable.DataSource = dataset.Tables[0];
                    MessageBox.Show("Record Deleted !");
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Connection
            string connenctionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connenctionString);

            //Command (SQL)
            SqlCommand command = new SqlCommand("select * from users", connection);

            //Definig dataset and dataAdapter;
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dataset); //filling dataset using adapter.
            dataset.Tables[0].TableName = "users";

            //Updating in dataset 
            int lastRowIndex = 0;
            foreach (DataRow row in dataset.Tables["users"].Rows)
            {
                if (row[0].ToString() == this.txtID.Text)
                {
                    lastRowIndex = (int)dataset.Tables["users"].Rows.IndexOf(row);
                    break;
                }
            }

            dataset.Tables["users"].Rows[lastRowIndex][0] = this.txtID.Text;
            dataset.Tables["users"].Rows[lastRowIndex][1] = this.txtPass.Text;            

            try
            {
                //Update into database tabel
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                sda.Update(dataset.Tables["users"]);

                //Showing updated records
                this.stockTable.DataSource = dataset.Tables[0];
                MessageBox.Show("Record updated !");
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txtID.Text = "Enter User's ID...";
            this.txtPass.Text = "Enter User's Password...";
        }

        private void stockTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.stockTable.Rows[e.RowIndex];
                if (row != null)
                {
                    this.txtID.Text = row.Cells["id"].Value.ToString();
                    this.txtPass.Text = row.Cells["pass"].Value.ToString();
                }
            }
        }
    }
}
