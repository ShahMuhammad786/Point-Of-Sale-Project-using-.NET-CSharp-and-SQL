
namespace Final_Project
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.Header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.welNote = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Footer = new System.Windows.Forms.Panel();
            this.lblPurchaseView = new System.Windows.Forms.Label();
            this.PurchasedView = new System.Windows.Forms.Panel();
            this.available = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemPurchased = new System.Windows.Forms.Label();
            this.totPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.PurchasedView.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.DodgerBlue;
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Controls.Add(this.btnExit);
            this.Header.Controls.Add(this.welNote);
            this.Header.Controls.Add(this.logo);
            this.Header.Location = new System.Drawing.Point(0, -1);
            this.Header.Margin = new System.Windows.Forms.Padding(4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(807, 67);
            this.Header.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Image = global::Final_Project.Properties.Resources.logout;
            this.btnExit.Location = new System.Drawing.Point(690, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // welNote
            // 
            this.welNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welNote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welNote.Location = new System.Drawing.Point(135, 19);
            this.welNote.Name = "welNote";
            this.welNote.Size = new System.Drawing.Size(495, 38);
            this.welNote.TabIndex = 1;
            this.welNote.Text = "Welcome to NOODLES POS System";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.DodgerBlue;
            this.logo.Image = global::Final_Project.Properties.Resources.mainIcon;
            this.logo.Location = new System.Drawing.Point(744, 5);
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
            this.Footer.TabIndex = 7;
            // 
            // lblPurchaseView
            // 
            this.lblPurchaseView.AutoSize = true;
            this.lblPurchaseView.BackColor = System.Drawing.Color.Beige;
            this.lblPurchaseView.Location = new System.Drawing.Point(574, 135);
            this.lblPurchaseView.Name = "lblPurchaseView";
            this.lblPurchaseView.Size = new System.Drawing.Size(171, 18);
            this.lblPurchaseView.TabIndex = 2;
            this.lblPurchaseView.Text = "Purchased Items\' Details";
            // 
            // PurchasedView
            // 
            this.PurchasedView.BackColor = System.Drawing.Color.Beige;
            this.PurchasedView.Controls.Add(this.available);
            this.PurchasedView.Controls.Add(this.label3);
            this.PurchasedView.Controls.Add(this.label2);
            this.PurchasedView.Controls.Add(this.label1);
            this.PurchasedView.Controls.Add(this.totPrice);
            this.PurchasedView.Location = new System.Drawing.Point(544, 166);
            this.PurchasedView.Name = "PurchasedView";
            this.PurchasedView.Size = new System.Drawing.Size(231, 256);
            this.PurchasedView.TabIndex = 3;
            // 
            // available
            // 
            this.available.AutoSize = true;
            this.available.BackColor = System.Drawing.Color.FloralWhite;
            this.available.Location = new System.Drawing.Point(165, 190);
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(24, 18);
            this.available.TabIndex = 5;
            this.available.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Available Items : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Price gain : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Items Purchased : ";
            // 
            // itemPurchased
            // 
            this.itemPurchased.AutoSize = true;
            this.itemPurchased.Location = new System.Drawing.Point(709, 211);
            this.itemPurchased.Name = "itemPurchased";
            this.itemPurchased.Size = new System.Drawing.Size(24, 18);
            this.itemPurchased.TabIndex = 3;
            this.itemPurchased.Text = "00";
            // 
            // totPrice
            // 
            this.totPrice.AutoSize = true;
            this.totPrice.Location = new System.Drawing.Point(165, 119);
            this.totPrice.Name = "totPrice";
            this.totPrice.Size = new System.Drawing.Size(24, 18);
            this.totPrice.TabIndex = 4;
            this.totPrice.Text = "00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(59, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 48);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Location = new System.Drawing.Point(235, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 255);
            this.panel2.TabIndex = 10;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Azure;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettings.Image = global::Final_Project.Properties.Resources.settings;
            this.btnSettings.Location = new System.Drawing.Point(6, 108);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(42, 38);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Beige;
            this.label4.Location = new System.Drawing.Point(162, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Main Application Operations";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::Final_Project.Properties.Resources.refresh;
            this.button1.Location = new System.Drawing.Point(647, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 31);
            this.button1.TabIndex = 4;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.Beige;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.Image = global::Final_Project.Properties.Resources.manuall;
            this.btnManual.Location = new System.Drawing.Point(296, 324);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(170, 98);
            this.btnManual.TabIndex = 3;
            this.btnManual.Text = "Buy: Manual";
            this.btnManual.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click_1);
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.Beige;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Image = global::Final_Project.Properties.Resources.scanner;
            this.btnScan.Location = new System.Drawing.Point(59, 324);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(170, 98);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "Buy: Scanner ";
            this.btnScan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Beige;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Image = global::Final_Project.Properties.Resources.history;
            this.btnHistory.Location = new System.Drawing.Point(296, 166);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(170, 98);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.Text = " Items History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnPos
            // 
            this.btnPos.BackColor = System.Drawing.Color.Beige;
            this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPos.Image = global::Final_Project.Properties.Resources.stock;
            this.btnPos.Location = new System.Drawing.Point(59, 166);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(170, 98);
            this.btnPos.TabIndex = 0;
            this.btnPos.Text = "Stock Management";
            this.btnPos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPos.UseVisualStyleBackColor = false;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(807, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.itemPurchased);
            this.Controls.Add(this.PurchasedView);
            this.Controls.Add(this.lblPurchaseView);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIBAU-POS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Index_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.PurchasedView.ResumeLayout(false);
            this.PurchasedView.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label welNote;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblPurchaseView;
        private System.Windows.Forms.Panel PurchasedView;
        private System.Windows.Forms.Label available;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label itemPurchased;
        private System.Windows.Forms.Label totPrice;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSettings;
    }
}

