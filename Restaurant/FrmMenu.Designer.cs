namespace Restaurant
{
    partial class FrmMenu
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
            this.BtnTableOrder = new System.Windows.Forms.Button();
            this.BtnRezervation = new System.Windows.Forms.Button();
            this.BtnPackageService = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnSafeTransactions = new System.Windows.Forms.Button();
            this.BtnKitchen = new System.Windows.Forms.Button();
            this.BtnReports = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnLock = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTableOrder
            // 
            this.BtnTableOrder.BackColor = System.Drawing.Color.Orange;
            this.BtnTableOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTableOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTableOrder.Location = new System.Drawing.Point(124, 75);
            this.BtnTableOrder.Name = "BtnTableOrder";
            this.BtnTableOrder.Size = new System.Drawing.Size(260, 91);
            this.BtnTableOrder.TabIndex = 0;
            this.BtnTableOrder.Text = "Table";
            this.BtnTableOrder.UseVisualStyleBackColor = false;
            this.BtnTableOrder.Click += new System.EventHandler(this.BtnTableOrder_Click);
            // 
            // BtnRezervation
            // 
            this.BtnRezervation.BackColor = System.Drawing.Color.Brown;
            this.BtnRezervation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRezervation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRezervation.Location = new System.Drawing.Point(390, 75);
            this.BtnRezervation.Name = "BtnRezervation";
            this.BtnRezervation.Size = new System.Drawing.Size(127, 91);
            this.BtnRezervation.TabIndex = 0;
            this.BtnRezervation.Text = "REZERVATIONS";
            this.BtnRezervation.UseVisualStyleBackColor = false;
            this.BtnRezervation.Click += new System.EventHandler(this.BtnRezervation_Click);
            // 
            // BtnPackageService
            // 
            this.BtnPackageService.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnPackageService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPackageService.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPackageService.Location = new System.Drawing.Point(523, 75);
            this.BtnPackageService.Name = "BtnPackageService";
            this.BtnPackageService.Size = new System.Drawing.Size(127, 91);
            this.BtnPackageService.TabIndex = 0;
            this.BtnPackageService.Text = "PACKAGE SERVICE";
            this.BtnPackageService.UseVisualStyleBackColor = false;
            this.BtnPackageService.Click += new System.EventHandler(this.BtnPackageService_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCustomers.Location = new System.Drawing.Point(124, 172);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCustomers.Size = new System.Drawing.Size(127, 91);
            this.BtnCustomers.TabIndex = 0;
            this.BtnCustomers.Text = "CUSTOMERS";
            this.BtnCustomers.UseVisualStyleBackColor = false;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // BtnSafeTransactions
            // 
            this.BtnSafeTransactions.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnSafeTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSafeTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSafeTransactions.Location = new System.Drawing.Point(257, 172);
            this.BtnSafeTransactions.Name = "BtnSafeTransactions";
            this.BtnSafeTransactions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSafeTransactions.Size = new System.Drawing.Size(127, 91);
            this.BtnSafeTransactions.TabIndex = 0;
            this.BtnSafeTransactions.Text = "SAFE TRANSACTIONS";
            this.BtnSafeTransactions.UseVisualStyleBackColor = false;
            this.BtnSafeTransactions.Click += new System.EventHandler(this.BtnSafeTransactions_Click);
            // 
            // BtnKitchen
            // 
            this.BtnKitchen.BackColor = System.Drawing.Color.DeepPink;
            this.BtnKitchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKitchen.Location = new System.Drawing.Point(390, 172);
            this.BtnKitchen.Name = "BtnKitchen";
            this.BtnKitchen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnKitchen.Size = new System.Drawing.Size(260, 91);
            this.BtnKitchen.TabIndex = 0;
            this.BtnKitchen.Text = "KITCHEN";
            this.BtnKitchen.UseVisualStyleBackColor = false;
            this.BtnKitchen.Click += new System.EventHandler(this.BtnKitchen_Click);
            // 
            // BtnReports
            // 
            this.BtnReports.BackColor = System.Drawing.Color.Lime;
            this.BtnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnReports.Location = new System.Drawing.Point(124, 269);
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnReports.Size = new System.Drawing.Size(127, 91);
            this.BtnReports.TabIndex = 0;
            this.BtnReports.Text = "REPORTS";
            this.BtnReports.UseVisualStyleBackColor = false;
            this.BtnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSettings.Location = new System.Drawing.Point(257, 269);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSettings.Size = new System.Drawing.Size(127, 91);
            this.BtnSettings.TabIndex = 0;
            this.BtnSettings.Text = "SETTINGS";
            this.BtnSettings.UseVisualStyleBackColor = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnLock
            // 
            this.BtnLock.BackColor = System.Drawing.Color.Yellow;
            this.BtnLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLock.Location = new System.Drawing.Point(390, 269);
            this.BtnLock.Name = "BtnLock";
            this.BtnLock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnLock.Size = new System.Drawing.Size(127, 91);
            this.BtnLock.TabIndex = 0;
            this.BtnLock.Text = "LOCK";
            this.BtnLock.UseVisualStyleBackColor = false;
            this.BtnLock.Click += new System.EventHandler(this.BtnLock_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnExit.Location = new System.Drawing.Point(523, 269);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnExit.Size = new System.Drawing.Size(127, 91);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnKitchen);
            this.Controls.Add(this.BtnSafeTransactions);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLock);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnReports);
            this.Controls.Add(this.BtnCustomers);
            this.Controls.Add(this.BtnPackageService);
            this.Controls.Add(this.BtnRezervation);
            this.Controls.Add(this.BtnTableOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTableOrder;
        private System.Windows.Forms.Button BtnRezervation;
        private System.Windows.Forms.Button BtnPackageService;
        private System.Windows.Forms.Button BtnCustomers;
        private System.Windows.Forms.Button BtnSafeTransactions;
        private System.Windows.Forms.Button BtnKitchen;
        private System.Windows.Forms.Button BtnReports;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnLock;
        private System.Windows.Forms.Button BtnExit;
    }
}