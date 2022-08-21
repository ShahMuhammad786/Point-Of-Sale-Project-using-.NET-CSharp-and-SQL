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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (this.panel1.Visible == true)
            {
                this.panel1.Visible = false;
            }
            else
            {
                this.panel1.Visible = true;
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you really want to Exit App?",
                                       "Exit App Confirmation",
                                       MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.textBox2.Text == "")
            {
                MessageBox.Show("Please fill all the feilds !");
            }
            else
            {               
                // Connection
                string connenctionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connenctionString);

                //Command (SQL)
                SqlCommand command = new SqlCommand("select * from users", connection);

                //Definig dataset and dataAdapter;
                DataSet dataset = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(dataset); //filling dataset using adapter.

                int rows = dataset.Tables[0].Rows.Count;
                bool flag = false;
                for (int i = 0; i < rows; i++)
                {
                    if (dataset.Tables[0].Rows[i][0].ToString() == this.textBox1.Text &&
                        dataset.Tables[0].Rows[i][1].ToString() == this.textBox2.Text)
                    {                        
                        flag = true;
                        break;

                    }
                }

                if (flag==false)
                {
                    MessageBox.Show("User Not Present !");                   
                }
                else
                {
                    this.timer1.Start();
                    this.progressBar1.Visible = true;
                }
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you really want to Exit App?",
                                       "Exit App Confirmation",
                                       MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        ///Logic for progress bar
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(2);

            if (this.progressBar1.Value == progressBar1.Maximum)
            {
                this.timer1.Stop();
                this.progressBar1.Visible = false;
                new Index().Show();
                this.Hide();

                this.textBox1.Text = "";
                this.textBox2.Text = "";
            }

        }

        



    }
}
