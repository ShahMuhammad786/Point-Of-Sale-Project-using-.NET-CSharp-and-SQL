
namespace Final_Project
{
    partial class StockManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockManagement));
            this.Header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.welNote = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Footer = new System.Windows.Forms.Panel();
            this.stockTable = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.DodgerBlue;
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Controls.Add(this.btnExit);
            this.Header.Controls.Add(this.btnGoHome);
            this.Header.Controls.Add(this.welNote);
            this.Header.Controls.Add(this.logo);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(5);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(795, 68);
            this.Header.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.mainIcon;
            this.pictureBox1.Location = new System.Drawing.Point(732, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Image = global::Final_Project.Properties.Resources.home;
            this.btnExit.Location = new System.Drawing.Point(691, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.Location = new System.Drawing.Point(933, 38);
            this.btnGoHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(100, 33);
            this.btnGoHome.TabIndex = 2;
            this.btnGoHome.Text = "Go Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            // 
            // welNote
            // 
            this.welNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welNote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welNote.Location = new System.Drawing.Point(180, 15);
            this.welNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welNote.Name = "welNote";
            this.welNote.Size = new System.Drawing.Size(453, 47);
            this.welNote.TabIndex = 1;
            this.welNote.Text = "Stock Inventory NOODLES POS";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.DodgerBlue;
            this.logo.Image = global::Final_Project.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(3, 2);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(65, 63);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.DodgerBlue;
            this.Footer.Location = new System.Drawing.Point(0, 493);
            this.Footer.Margin = new System.Windows.Forms.Padding(5);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(795, 25);
            this.Footer.TabIndex = 3;
            // 
            // stockTable
            // 
            this.stockTable.AllowUserToAddRows = false;
            this.stockTable.AllowUserToDeleteRows = false;
            this.stockTable.AllowUserToOrderColumns = true;
            this.stockTable.AllowUserToResizeColumns = false;
            this.stockTable.AllowUserToResizeRows = false;
            this.stockTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockTable.BackgroundColor = System.Drawing.Color.Beige;
            this.stockTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockTable.GridColor = System.Drawing.Color.Beige;
            this.stockTable.Location = new System.Drawing.Point(31, 151);
            this.stockTable.Name = "stockTable";
            this.stockTable.ReadOnly = true;
            this.stockTable.Size = new System.Drawing.Size(406, 323);
            this.stockTable.TabIndex = 8;
            this.stockTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockTable_CellContentClick);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Azure;
            this.txtName.Location = new System.Drawing.Point(460, 151);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(302, 22);
            this.txtName.TabIndex = 0;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Azure;
            this.txtPrice.Location = new System.Drawing.Point(460, 192);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(302, 22);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.Azure;
            this.txtBarcode.Location = new System.Drawing.Point(460, 236);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(302, 22);
            this.txtBarcode.TabIndex = 2;
            this.txtBarcode.Enter += new System.EventHandler(this.txtBarcode_Enter);
            this.txtBarcode.Leave += new System.EventHandler(this.txtBarcode_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(110, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "All the Available Stock in the Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(555, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data Operations";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(596, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 185);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(460, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 31);
            this.panel1.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Azure;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Final_Project.Properties.Resources.reset;
            this.button4.Location = new System.Drawing.Point(633, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 70);
            this.button4.TabIndex = 6;
            this.button4.Text = "Reset";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Azure;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Final_Project.Properties.Resources.updItm;
            this.button3.Location = new System.Drawing.Point(460, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 70);
            this.button3.TabIndex = 5;
            this.button3.Text = "Update Item";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Final_Project.Properties.Resources.delItm;
            this.button2.Location = new System.Drawing.Point(633, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 74);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove Item";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Final_Project.Properties.Resources.addItm;
            this.button1.Location = new System.Drawing.Point(460, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 74);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Item";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stockTable);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StockManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockManagement_FormClosing);
            this.Load += new System.EventHandler(this.StockManagement_Load);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.Label welNote;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView stockTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}