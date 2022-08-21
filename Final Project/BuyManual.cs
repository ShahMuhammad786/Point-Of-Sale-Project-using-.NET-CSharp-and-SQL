using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Final_Project
{
    public partial class BuyManual : Form
    {
        public BuyManual()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Index().Show();
        }

        private void BuyManual_Load(object sender, EventArgs e)
        {
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

            int rows = dataset.Tables["stock"].Rows.Count;
            for (int i=0; i<rows; i++)
            {
                this.comboBoxChoose.Items.Add(dataset.Tables["stock"].Rows[i][0]);
            }

            //Feilds settings
            this.txtPrice.Text = "Price of item...";
            this.txtBarCode.Text = "Barcode of item...";
        }

        private void comboBoxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
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

            int rows = dataset.Tables["stock"].Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                if (dataset.Tables["stock"].Rows[i][0].ToString()==this.comboBoxChoose.SelectedItem.ToString())
                {
                    this.txtPrice.Text = dataset.Tables["stock"].Rows[i][1].ToString();
                    this.txtBarCode.Text = dataset.Tables["stock"].Rows[i][2].ToString();
                    break;
                }                
            }
        }

        private void manCancel_Click(object sender, EventArgs e)
        {
            this.txtPrice.Text = "Price of item...";
            this.txtBarCode.Text = "Barcode of item...";
            this.comboBoxChoose.Text = "Choose Item";
        }

        private void manOrder_Click(object sender, EventArgs e)
        {
            if (this.comboBoxChoose.Text == "Choose Item")
            {
                MessageBox.Show("Please Choose Item first !");
            }
            else
            {
                //Calculating values from database;
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

                int rows = dataset.Tables["stock"].Rows.Count;
                for (int i = 0; i < rows; i++)
                {
                    if (dataset.Tables["stock"].Rows[i][2].ToString() == this.txtBarCode.Text)
                    {
                        this.nameAns.Text = dataset.Tables["stock"].Rows[i][0].ToString();
                        this.priceAns.Text = dataset.Tables["stock"].Rows[i][1].ToString();
                        this.quantityAns.Text = "1 Item";
                        this.totToPay.Text = this.priceAns.Text;
                        this.pBoxBarCode.ImageLocation = @"BarCodes\" + this.nameAns.Text + ".bmp";

                        this.lblDataEntryDate.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
                        this.lblPrintDate.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();

                        this.panelReceipt.Visible = true;
                        this.label2.Visible = true;
                        this.btnCancel.Visible = true;
                        this.btnSave.Visible = true;
                        this.btnPrint.Visible = true;

                    }

                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you really want to cancel Order?",
                                       "Cancel Order Confirmation",
                                       MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                //saved in data base (canceled table)
                //Connection
                string connenctionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connenctionString);

                //Command (SQL)
                SqlCommand command = new SqlCommand("select * from canceled", connection);

                //Definig dataset and dataAdapter;
                DataSet dataset = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(dataset); //filling dataset using adapter.
                dataset.Tables[0].TableName = "canceled";

                DataRow drow = dataset.Tables["canceled"].NewRow();


                drow[0] = DateTime.Now.ToLongDateString();
                drow[1] = this.nameAns.Text;
                drow[2] = Convert.ToDecimal(this.priceAns.Text);

                dataset.Tables["canceled"].Rows.Add(drow);
                try
                {
                    SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                    sda.Update(dataset.Tables["canceled"]);
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }

                MessageBox.Show("Order Cancelled !");


                this.panelReceipt.Visible = false;
                this.nameAns.Text = "";
                this.priceAns.Text = "";
                this.quantityAns.Text = "";
                this.totToPay.Text = "";

                this.label2.Visible = false;
                this.panelReceipt.Visible = false;
                this.btnCancel.Visible = false;
                this.btnSave.Visible = false;
                this.btnPrint.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int width = panelReceipt.Size.Width;
            int height = panelReceipt.Size.Height;

            Bitmap bm = new Bitmap(width, height);
            panelReceipt.DrawToBitmap(bm, new Rectangle(0, 0, width, height));
            
            bm.Save(@"Reciepts\" + this.nameAns.Text+".bmp", ImageFormat.Bmp);

            MessageBox.Show("Reciept saved Successfully !");
            this.label2.Visible = false;
            this.panelReceipt.Visible = false;
            this.btnCancel.Visible = false;
            this.btnSave.Visible = false;
            this.btnPrint.Visible = false;

            //Saving history of purchased
            //Connection
            string connenctionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connenctionString);

            //Command (SQL)
            SqlCommand command = new SqlCommand("select * from log", connection);

            //Definig dataset and dataAdapter;
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dataset); //filling dataset using adapter.
            dataset.Tables[0].TableName = "log";

            DataRow drow = dataset.Tables["log"].NewRow();

            drow[0] = DateTime.Now.ToLongDateString();
            drow[1] = this.nameAns.Text;
            drow[2] = Convert.ToDecimal(this.priceAns.Text);

            dataset.Tables["log"].Rows.Add(drow);
            try
            {
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                sda.Update(dataset.Tables["log"]);
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }

        }

        Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = panelReceipt.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panelReceipt.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();


            //Setting things' visibility false.
            this.label2.Visible = false;
            this.panelReceipt.Visible = false;
            this.btnCancel.Visible = false;
            this.btnSave.Visible = false;
            this.btnPrint.Visible = false;

            //Saving history of purchased
            //Connection
            string connenctionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connenctionString);

            //Command (SQL)
            SqlCommand command = new SqlCommand("select * from log", connection);

            //Definig dataset and dataAdapter;
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dataset); //filling dataset using adapter.
            dataset.Tables[0].TableName = "log";

            DataRow drow = dataset.Tables["log"].NewRow();

            drow[0] = DateTime.Now.ToLongDateString();
            drow[1] = this.nameAns.Text;
            drow[2] = Convert.ToDecimal(this.priceAns.Text);

            dataset.Tables["log"].Rows.Add(drow);
            try
            {
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                sda.Update(dataset.Tables["log"]);
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void BuyManual_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
