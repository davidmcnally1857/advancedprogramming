namespace WindowsFormsApp3
{
    partial class grpWaterMeters
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
            this.dgvWatermeters = new System.Windows.Forms.DataGridView();
            this.lblWaterMeters = new System.Windows.Forms.Label();
            this.lblWaterMeterAccount = new System.Windows.Forms.Label();
            this.dgvWeterMeterAccount = new System.Windows.Forms.DataGridView();
            this.gbrMeters = new System.Windows.Forms.GroupBox();
            this.rbMeterId = new System.Windows.Forms.RadioButton();
            this.rbVolumeUsed = new System.Windows.Forms.RadioButton();
            this.btnCustomerArrers = new System.Windows.Forms.Button();
            this.btnSummaryReportS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWatermeters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeterMeterAccount)).BeginInit();
            this.gbrMeters.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWatermeters
            // 
            this.dgvWatermeters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWatermeters.Location = new System.Drawing.Point(12, 30);
            this.dgvWatermeters.Name = "dgvWatermeters";
            this.dgvWatermeters.RowTemplate.Height = 28;
            this.dgvWatermeters.Size = new System.Drawing.Size(907, 187);
            this.dgvWatermeters.TabIndex = 0;
            // 
            // lblWaterMeters
            // 
            this.lblWaterMeters.AutoSize = true;
            this.lblWaterMeters.Location = new System.Drawing.Point(32, 7);
            this.lblWaterMeters.Name = "lblWaterMeters";
            this.lblWaterMeters.Size = new System.Drawing.Size(105, 20);
            this.lblWaterMeters.TabIndex = 1;
            this.lblWaterMeters.Text = "Water Meters";
            // 
            // lblWaterMeterAccount
            // 
            this.lblWaterMeterAccount.AutoSize = true;
            this.lblWaterMeterAccount.Location = new System.Drawing.Point(30, 234);
            this.lblWaterMeterAccount.Name = "lblWaterMeterAccount";
            this.lblWaterMeterAccount.Size = new System.Drawing.Size(160, 20);
            this.lblWaterMeterAccount.TabIndex = 2;
            this.lblWaterMeterAccount.Text = "Water Meter Account";
            // 
            // dgvWeterMeterAccount
            // 
            this.dgvWeterMeterAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeterMeterAccount.Location = new System.Drawing.Point(12, 274);
            this.dgvWeterMeterAccount.Name = "dgvWeterMeterAccount";
            this.dgvWeterMeterAccount.RowTemplate.Height = 28;
            this.dgvWeterMeterAccount.Size = new System.Drawing.Size(907, 213);
            this.dgvWeterMeterAccount.TabIndex = 3;
            // 
            // gbrMeters
            // 
            this.gbrMeters.Controls.Add(this.rbVolumeUsed);
            this.gbrMeters.Controls.Add(this.rbMeterId);
            this.gbrMeters.Location = new System.Drawing.Point(34, 513);
            this.gbrMeters.Name = "gbrMeters";
            this.gbrMeters.Size = new System.Drawing.Size(236, 120);
            this.gbrMeters.TabIndex = 4;
            this.gbrMeters.TabStop = false;
            this.gbrMeters.Text = "Sort Water Meters";
            // 
            // rbMeterId
            // 
            this.rbMeterId.AutoSize = true;
            this.rbMeterId.Location = new System.Drawing.Point(24, 37);
            this.rbMeterId.Name = "rbMeterId";
            this.rbMeterId.Size = new System.Drawing.Size(89, 24);
            this.rbMeterId.TabIndex = 0;
            this.rbMeterId.TabStop = true;
            this.rbMeterId.Text = "MeterId";
            this.rbMeterId.UseVisualStyleBackColor = true;
            // 
            // rbVolumeUsed
            // 
            this.rbVolumeUsed.AutoSize = true;
            this.rbVolumeUsed.Location = new System.Drawing.Point(24, 81);
            this.rbVolumeUsed.Name = "rbVolumeUsed";
            this.rbVolumeUsed.Size = new System.Drawing.Size(130, 24);
            this.rbVolumeUsed.TabIndex = 1;
            this.rbVolumeUsed.TabStop = true;
            this.rbVolumeUsed.Text = "Volume Used";
            this.rbVolumeUsed.UseVisualStyleBackColor = true;
            // 
            // btnCustomerArrers
            // 
            this.btnCustomerArrers.Location = new System.Drawing.Point(540, 513);
            this.btnCustomerArrers.Name = "btnCustomerArrers";
            this.btnCustomerArrers.Size = new System.Drawing.Size(151, 107);
            this.btnCustomerArrers.TabIndex = 5;
            this.btnCustomerArrers.Text = "Customer Arrears";
            this.btnCustomerArrers.UseVisualStyleBackColor = true;
            // 
            // btnSummaryReportS
            // 
            this.btnSummaryReportS.Location = new System.Drawing.Point(710, 513);
            this.btnSummaryReportS.Name = "btnSummaryReportS";
            this.btnSummaryReportS.Size = new System.Drawing.Size(151, 107);
            this.btnSummaryReportS.TabIndex = 6;
            this.btnSummaryReportS.Text = "Summary Report";
            this.btnSummaryReportS.UseVisualStyleBackColor = true;
            // 
            // grpWaterMeters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 641);
            this.Controls.Add(this.btnSummaryReportS);
            this.Controls.Add(this.btnCustomerArrers);
            this.Controls.Add(this.gbrMeters);
            this.Controls.Add(this.dgvWeterMeterAccount);
            this.Controls.Add(this.lblWaterMeterAccount);
            this.Controls.Add(this.lblWaterMeters);
            this.Controls.Add(this.dgvWatermeters);
            this.Name = "grpWaterMeters";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.grpWaterMeters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWatermeters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeterMeterAccount)).EndInit();
            this.gbrMeters.ResumeLayout(false);
            this.gbrMeters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWatermeters;
        private System.Windows.Forms.Label lblWaterMeters;
        private System.Windows.Forms.Label lblWaterMeterAccount;
        private System.Windows.Forms.DataGridView dgvWeterMeterAccount;
        private System.Windows.Forms.GroupBox gbrMeters;
        private System.Windows.Forms.RadioButton rbVolumeUsed;
        private System.Windows.Forms.RadioButton rbMeterId;
        private System.Windows.Forms.Button btnCustomerArrers;
        private System.Windows.Forms.Button btnSummaryReportS;
    }
}

