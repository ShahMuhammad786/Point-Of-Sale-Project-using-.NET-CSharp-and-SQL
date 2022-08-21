using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.IO;

namespace Final_Project
{
    public partial class StockManagement : Form
    {
        public StockManagement()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Index().Show();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {            
            this.txtName.Text = "";
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (this.txtName.Text == "")
                this.txtName.Text = "Enter Item Name...";
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {            
            this.txtPrice.Text = "";
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (this.txtPrice.Text == "")
                this.txtPrice.Text = "Enter Item price...";
        }

        private void txtBarcode_Enter(object sender, EventArgs e)
        {           
            this.txtBarcode.Text = "";
        }

        private void txtBarcode_Leave(object sender, EventArgs e)
        {
            if (this.txtBarcode.Text == "")
                this.txtBarcode.Text = "Enter Barcode...";
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            getData();

            this.txtName.Text = "Enter Item Name...";
            this.txtPrice.Text = "Enter Item Price...";
            this.txtBarcode.Text = "Enter Items' Barcode...";


        }

        public void getData()
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

            //showing dataset tabel in data grid view            
            this.stockTable.DataSource = dataset.Tables[0];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "Enter Item Name...";
            this.txtPrice.Text = "Enter Item Price...";
            this.txtBarcode.Text = "Enter Item's barcode...";
        }

        private void button1_Click(object sender, EventArgs e)
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

            DataRow drow = dataset.Tables["stock"].NewRow();

            //Row index finding
            int lastRowIndex = 0;
            foreach (DataRow row in dataset.Tables["stock"].Rows)
            {
                if (row[0].ToString() == this.txtName.Text)
                {
                    lastRowIndex = (int)dataset.Tables["stock"].Rows.IndexOf(row);
                    break;
                }
            }

            if ((string)dataset.Tables[0].Rows[lastRowIndex][0] == this.txtName.Text)
            {
                MessageBox.Show("Item Already Exist !");
            }
            else
            {
                drow[0] = this.txtName.Text;
                drow[1] = this.txtPrice.Text;
                drow[2] = this.txtBarcode.Text;

                dataset.Tables["stock"].Rows.Add(drow);
                try
                {
                    SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                    sda.Update(dataset.Tables["stock"]);

                    //showing dataset tabel in data grid view            
                    this.stockTable.DataSource = dataset.Tables[0];
                    MessageBox.Show("Inserted new Row !");
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }
            }

            //Generating barcode
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            Image image = barcode.Draw(this.txtBarcode.Text, 50);

            //Generating QR Code
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            Image image1 = qrcode.Draw(this.txtBarcode.Text, 50);

            //Image savce with the name of item.
            image.Save(@"BarCodes\"+this.txtName.Text+".bmp");
            image1.Save(@"QRCodes\" + this.txtName.Text + ".bmp");
        }

        private void stockTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.stockTable.Rows[e.RowIndex];
                if (row != null)
                {
                    this.txtName.Text = row.Cells["name"].Value.ToString();
                    this.txtPrice.Text = row.Cells["price"].Value.ToString();
                    this.txtBarcode.Text = row.Cells["barcode"].Value.ToString();
                } 
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

            //Updating in dataset 
            int lastRowIndex = 0;
            foreach (DataRow row in dataset.Tables["stock"].Rows)
            {
                if (row[0].ToString() == this.txtName.Text)
                {
                    lastRowIndex = (int)dataset.Tables["stock"].Rows.IndexOf(row);
                    break;
                }
            }

            DialogResult result1 = MessageBox.Show("Do you really want to remove Item?",
                                       "Item removal Confirmation",
                                       MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                dataset.Tables["stock"].Rows[lastRowIndex].Delete();

                try
                {
                    //Update into database tabel
                    SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                    sda.Update(dataset.Tables["stock"]);

                    //Showing updated records
                    this.stockTable.DataSource = dataset.Tables[0];
                    MessageBox.Show("Record Deleted !");
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }

                //Deleting barcode in directory
                File.Delete(@"BarCodes\" + this.txtName.Text + ".bmp");
                File.Delete(@"QRCodes\" + this.txtName.Text + ".bmp");

            }

        }

        private void button3_Click(object sender, EventArgs e)
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

            //Updating in dataset 
            int lastRowIndex = 0 ;
            foreach (DataRow row in dataset.Tables["stock"].Rows)
            {
                if(row[0].ToString() == this.txtName.Text)
                {
                    lastRowIndex = (int)dataset.Tables["stock"].Rows.IndexOf(row);
                    break;
                }                
            }

            dataset.Tables["stock"].Rows[lastRowIndex][0] = this.txtName.Text;
            dataset.Tables["stock"].Rows[lastRowIndex][1] = Convert.ToDecimal(this.txtPrice.Text);
            dataset.Tables["stock"].Rows[lastRowIndex][2] = this.txtBarcode.Text;
            
            try
            {
                //Update into database tabel
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                sda.Update(dataset.Tables["stock"]);

                //Showing updated records
                this.stockTable.DataSource = dataset.Tables[0];
                MessageBox.Show("Record updated !");
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }

            //Generating barcode
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            Image image = barcode.Draw(this.txtBarcode.Text, 50);

            //Generating QR Code
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            Image image1 = qrcode.Draw(this.txtBarcode.Text, 50);

            //Image savce with the name of item.
            image.Save(@"BarCodes\" + this.txtName.Text + ".bmp");
            image1.Save(@"QRCodes\" + this.txtName.Text + ".bmp");
        }

        private void StockManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
