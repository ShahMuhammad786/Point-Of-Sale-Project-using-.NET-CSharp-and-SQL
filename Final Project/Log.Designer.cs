
namespace Final_Project
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.Header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.welNote = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Footer = new System.Windows.Forms.Panel();
            this.stockTable = new System.Windows.Forms.DataGridView();
            this.PurchasedView = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancelled = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTable)).BeginInit();
            this.PurchasedView.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.DodgerBlue;
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Controls.Add(this.btnHome);
            this.Header.Controls.Add(this.welNote);
            this.Header.Controls.Add(this.logo);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(807, 65);
            this.Header.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.mainIcon;
            this.pictureBox1.Location = new System.Drawing.Point(744, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Image = global::Final_Project.Properties.Resources.home;
            this.btnHome.Location = new System.Drawing.Point(699, 27);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(37, 31);
            this.btnHome.TabIndex = 4;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // welNote
            // 
            this.welNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welNote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welNote.Location = new System.Drawing.Point(288, 13);
            this.welNote.Name = "welNote";
            this.welNote.Size = new System.Drawing.Size(297, 38);
            this.welNote.TabIndex = 9;
            this.welNote.Text = "History of Items";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.DodgerBlue;
            this.logo.Image = global::Final_Project.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(60, 58);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.DodgerBlue;
            this.Footer.Location = new System.Drawing.Point(0, 497);
            this.Footer.Margin = new System.Windows.Forms.Padding(4);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(807, 24);
            this.Footer.TabIndex = 2;
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
            this.stockTable.Location = new System.Drawing.Point(12, 131);
            this.stockTable.Name = "stockTable";
            this.stockTable.ReadOnly = true;
            this.stockTable.Size = new System.Drawing.Size(411, 359);
            this.stockTable.TabIndex = 3;
            // 
            // PurchasedView
            // 
            this.PurchasedView.BackColor = System.Drawing.Color.Beige;
            this.PurchasedView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PurchasedView.Controls.Add(this.button2);
            this.PurchasedView.Controls.Add(this.btnCancelled);
            this.PurchasedView.Controls.Add(this.button1);
            this.PurchasedView.Controls.Add(this.dateTimePicker);
            this.PurchasedView.Controls.Add(this.btnSearch);
            this.PurchasedView.Location = new System.Drawing.Point(479, 131);
            this.PurchasedView.Name = "PurchasedView";
            this.PurchasedView.Size = new System.Drawing.Size(273, 335);
            this.PurchasedView.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::Final_Project.Properties.Resources.refresh;
            this.button2.Location = new System.Drawing.Point(176, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 36);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelled
            // 
            this.btnCancelled.BackColor = System.Drawing.Color.Azure;
            this.btnCancelled.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelled.Image = global::Final_Project.Properties.Resources.cancelled;
            this.btnCancelled.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelled.Location = new System.Drawing.Point(138, 241);
            this.btnCancelled.Name = "btnCancelled";
            this.btnCancelled.Size = new System.Drawing.Size(115, 36);
            this.btnCancelled.TabIndex = 2;
            this.btnCancelled.Text = "Cancelled";
            this.btnCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelled.UseVisualStyleBackColor = false;
            this.btnCancelled.Click += new System.EventHandler(this.btnCancelled_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::Final_Project.Properties.Resources.refresh;
            this.button1.Location = new System.Drawing.Point(53, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 36);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.LightCyan;
            this.dateTimePicker.Location = new System.Drawing.Point(19, 16);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(238, 22);
            this.dateTimePicker.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Azure;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::Final_Project.Properties.Resources.purchases;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(15, 241);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Purchased";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(574, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search Box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(62, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "History of the all puchased & Cancelled Items so far.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(438, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 445);
            this.panel2.TabIndex = 11;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PurchasedView);
            this.Controls.Add(this.stockTable);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_FormClosing);
            this.Load += new System.EventHandler(this.Log_Load);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTable)).EndInit();
            this.PurchasedView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label welNote;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.DataGridView stockTable;
        private System.Windows.Forms.Panel PurchasedView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelled;
        private System.Windows.Forms.Button button2;
    }
}