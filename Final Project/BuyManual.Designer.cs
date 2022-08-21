
namespace Final_Project
{
    partial class BuyManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyManual));
            this.Header = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.welNote = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Footer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxChoose = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.panelReceipt = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pBoxBarCode = new System.Windows.Forms.PictureBox();
            this.totToPay = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.quantityAns = new System.Windows.Forms.Label();
            this.priceAns = new System.Windows.Forms.Label();
            this.nameAns = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPrintDate = new System.Windows.Forms.Label();
            this.lblDataEntryDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.manOrder = new System.Windows.Forms.Button();
            this.manCancel = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.DodgerBlue;
            this.Header.Controls.Add(this.pictureBox3);
            this.Header.Controls.Add(this.btnHome);
            this.Header.Controls.Add(this.welNote);
            this.Header.Controls.Add(this.logo);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(807, 66);
            this.Header.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox3.Image = global::Final_Project.Properties.Resources.mainIcon;
            this.pictureBox3.Location = new System.Drawing.Point(745, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Image = global::Final_Project.Properties.Resources.home;
            this.btnHome.Location = new System.Drawing.Point(703, 27);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(37, 35);
            this.btnHome.TabIndex = 6;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // welNote
            // 
            this.welNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welNote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welNote.Location = new System.Drawing.Point(244, 15);
            this.welNote.Name = "welNote";
            this.welNote.Size = new System.Drawing.Size(377, 38);
            this.welNote.TabIndex = 8;
            this.welNote.Text = "Buy Items Manually\r\n";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.DodgerBlue;
            this.logo.Image = global::Final_Project.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(2, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(60, 58);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.DodgerBlue;
            this.Footer.Location = new System.Drawing.Point(0, 495);
            this.Footer.Margin = new System.Windows.Forms.Padding(4);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(807, 24);
            this.Footer.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(413, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 442);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Choose Items to Purchase";
            // 
            // comboBoxChoose
            // 
            this.comboBoxChoose.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxChoose.FormattingEnabled = true;
            this.comboBoxChoose.Location = new System.Drawing.Point(59, 188);
            this.comboBoxChoose.Name = "comboBoxChoose";
            this.comboBoxChoose.Size = new System.Drawing.Size(240, 24);
            this.comboBoxChoose.TabIndex = 0;
            this.comboBoxChoose.Text = "Choose Item";
            this.comboBoxChoose.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoose_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(59, 239);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(240, 22);
            this.txtPrice.TabIndex = 25;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(59, 288);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.ReadOnly = true;
            this.txtBarCode.Size = new System.Drawing.Size(240, 22);
            this.txtBarCode.TabIndex = 26;
            // 
            // panelReceipt
            // 
            this.panelReceipt.AutoScroll = true;
            this.panelReceipt.BackColor = System.Drawing.Color.Beige;
            this.panelReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReceipt.Controls.Add(this.label15);
            this.panelReceipt.Controls.Add(this.label19);
            this.panelReceipt.Controls.Add(this.label18);
            this.panelReceipt.Controls.Add(this.label17);
            this.panelReceipt.Controls.Add(this.label14);
            this.panelReceipt.Controls.Add(this.pBoxBarCode);
            this.panelReceipt.Controls.Add(this.totToPay);
            this.panelReceipt.Controls.Add(this.label13);
            this.panelReceipt.Controls.Add(this.quantityAns);
            this.panelReceipt.Controls.Add(this.priceAns);
            this.panelReceipt.Controls.Add(this.nameAns);
            this.panelReceipt.Controls.Add(this.label12);
            this.panelReceipt.Controls.Add(this.lblPrintDate);
            this.panelReceipt.Controls.Add(this.lblDataEntryDate);
            this.panelReceipt.Controls.Add(this.label11);
            this.panelReceipt.Controls.Add(this.label10);
            this.panelReceipt.Controls.Add(this.label7);
            this.panelReceipt.Controls.Add(this.label6);
            this.panelReceipt.Controls.Add(this.label5);
            this.panelReceipt.Controls.Add(this.label4);
            this.panelReceipt.Controls.Add(this.label3);
            this.panelReceipt.Controls.Add(this.pictureBox2);
            this.panelReceipt.Controls.Add(this.pictureBox1);
            this.panelReceipt.Controls.Add(this.label8);
            this.panelReceipt.Controls.Add(this.label9);
            this.panelReceipt.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelReceipt.Location = new System.Drawing.Point(458, 99);
            this.panelReceipt.Name = "panelReceipt";
            this.panelReceipt.Size = new System.Drawing.Size(318, 347);
            this.panelReceipt.TabIndex = 33;
            this.panelReceipt.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(66, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(205, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = " ----------Sale Receipt ----------";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(75, 317);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(171, 15);
            this.label19.TabIndex = 22;
            this.label19.Text = "-----------------------------------------";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(117, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 15);
            this.label18.TabIndex = 21;
            this.label18.Text = "---------------------";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 293);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 15);
            this.label17.TabIndex = 19;
            this.label17.Text = "Print Date : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = "Entry Date : ";
            // 
            // pBoxBarCode
            // 
            this.pBoxBarCode.BackColor = System.Drawing.Color.Beige;
            this.pBoxBarCode.Location = new System.Drawing.Point(132, 197);
            this.pBoxBarCode.Name = "pBoxBarCode";
            this.pBoxBarCode.Size = new System.Drawing.Size(147, 58);
            this.pBoxBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxBarCode.TabIndex = 3;
            this.pBoxBarCode.TabStop = false;
            // 
            // totToPay
            // 
            this.totToPay.AutoSize = true;
            this.totToPay.Location = new System.Drawing.Point(56, 233);
            this.totToPay.Name = "totToPay";
            this.totToPay.Size = new System.Drawing.Size(34, 15);
            this.totToPay.TabIndex = 16;
            this.totToPay.Text = "00.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Total to Pay : ";
            // 
            // quantityAns
            // 
            this.quantityAns.AutoSize = true;
            this.quantityAns.Location = new System.Drawing.Point(151, 162);
            this.quantityAns.Name = "quantityAns";
            this.quantityAns.Size = new System.Drawing.Size(19, 15);
            this.quantityAns.TabIndex = 14;
            this.quantityAns.Text = "00";
            // 
            // priceAns
            // 
            this.priceAns.AutoSize = true;
            this.priceAns.Location = new System.Drawing.Point(151, 142);
            this.priceAns.Name = "priceAns";
            this.priceAns.Size = new System.Drawing.Size(19, 15);
            this.priceAns.TabIndex = 13;
            this.priceAns.Text = "00";
            // 
            // nameAns
            // 
            this.nameAns.AutoSize = true;
            this.nameAns.Location = new System.Drawing.Point(151, 120);
            this.nameAns.Name = "nameAns";
            this.nameAns.Size = new System.Drawing.Size(60, 15);
            this.nameAns.TabIndex = 12;
            this.nameAns.Text = "ItemName";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(272, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "_____________________________________________________";
            // 
            // lblPrintDate
            // 
            this.lblPrintDate.AutoSize = true;
            this.lblPrintDate.Location = new System.Drawing.Point(99, 293);
            this.lblPrintDate.Name = "lblPrintDate";
            this.lblPrintDate.Size = new System.Drawing.Size(125, 15);
            this.lblPrintDate.TabIndex = 10;
            this.lblPrintDate.Text = "00/00/0000     00:00 pm";
            // 
            // lblDataEntryDate
            // 
            this.lblDataEntryDate.AutoSize = true;
            this.lblDataEntryDate.Location = new System.Drawing.Point(99, 278);
            this.lblDataEntryDate.Name = "lblDataEntryDate";
            this.lblDataEntryDate.Size = new System.Drawing.Size(122, 15);
            this.lblDataEntryDate.TabIndex = 9;
            this.lblDataEntryDate.Text = "00/00/0000    00:00 pm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Operator : SHAHI ENTERPRISES";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(272, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "_____________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quantity : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Price : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "THE SUPERMARKET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "ICON BY SHAHI ENTERPRISES";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Beige;
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.mainIcon;
            this.pictureBox2.Location = new System.Drawing.Point(223, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Beige;
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.mainIcon;
            this.pictureBox1.Location = new System.Drawing.Point(49, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(272, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "_____________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(272, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "_____________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(567, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "-------Reciept-------";
            this.label2.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Azure;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Image = global::Final_Project.Properties.Resources.print;
            this.btnPrint.Location = new System.Drawing.Point(638, 453);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(46, 37);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Azure;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Image = global::Final_Project.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(592, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(37, 37);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Azure;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Image = global::Final_Project.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(548, 452);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(38, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // manOrder
            // 
            this.manOrder.BackColor = System.Drawing.Color.Azure;
            this.manOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manOrder.Image = global::Final_Project.Properties.Resources.order;
            this.manOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.manOrder.Location = new System.Drawing.Point(182, 347);
            this.manOrder.Name = "manOrder";
            this.manOrder.Size = new System.Drawing.Size(95, 46);
            this.manOrder.TabIndex = 1;
            this.manOrder.Text = "Order";
            this.manOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manOrder.UseVisualStyleBackColor = false;
            this.manOrder.Click += new System.EventHandler(this.manOrder_Click);
            // 
            // manCancel
            // 
            this.manCancel.BackColor = System.Drawing.Color.Azure;
            this.manCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manCancel.Image = global::Final_Project.Properties.Resources.reset;
            this.manCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.manCancel.Location = new System.Drawing.Point(78, 347);
            this.manCancel.Name = "manCancel";
            this.manCancel.Size = new System.Drawing.Size(98, 46);
            this.manCancel.TabIndex = 2;
            this.manCancel.Text = "Reset";
            this.manCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manCancel.UseVisualStyleBackColor = false;
            this.manCancel.Click += new System.EventHandler(this.manCancel_Click);
            // 
            // BuyManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelReceipt);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.manOrder);
            this.Controls.Add(this.manCancel);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.comboBoxChoose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BuyManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyManual";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuyManual_FormClosing);
            this.Load += new System.EventHandler(this.BuyManual_Load);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelReceipt.ResumeLayout(false);
            this.panelReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label welNote;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxChoose;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Button manCancel;
        private System.Windows.Forms.Button manOrder;
        private System.Windows.Forms.Panel panelReceipt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pBoxBarCode;
        private System.Windows.Forms.Label totToPay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label quantityAns;
        private System.Windows.Forms.Label priceAns;
        private System.Windows.Forms.Label nameAns;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPrintDate;
        private System.Windows.Forms.Label lblDataEntryDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}