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
            this.rbVolumeUsed = new System.Windows.Forms.RadioButton();
            this.rbMeterId = new System.Windows.Forms.RadioButton();
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
            this.dgvWatermeters.Location = new System.Drawing.Point(10, 25);
            this.dgvWatermeters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvWatermeters.Name = "dgvWatermeters";
            this.dgvWatermeters.RowTemplate.Height = 28;
            this.dgvWatermeters.Size = new System.Drawing.Size(806, 247);
            this.dgvWatermeters.TabIndex = 0;
            this.dgvWatermeters.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWatermeters_RowEnter);
            // 
            // lblWaterMeters
            // 
            this.lblWaterMeters.AutoSize = true;
            this.lblWaterMeters.Location = new System.Drawing.Point(28, 6);
            this.lblWaterMeters.Name = "lblWaterMeters";
            this.lblWaterMeters.Size = new System.Drawing.Size(93, 17);
            this.lblWaterMeters.TabIndex = 1;
            this.lblWaterMeters.Text = "Water Meters";
            // 
            // lblWaterMeterAccount
            // 
            this.lblWaterMeterAccount.AutoSize = true;
            this.lblWaterMeterAccount.Location = new System.Drawing.Point(23, 286);
            this.lblWaterMeterAccount.Name = "lblWaterMeterAccount";
            this.lblWaterMeterAccount.Size = new System.Drawing.Size(141, 17);
            this.lblWaterMeterAccount.TabIndex = 2;
            this.lblWaterMeterAccount.Text = "Water Meter Account";
            // 
            // dgvWeterMeterAccount
            // 
            this.dgvWeterMeterAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeterMeterAccount.Location = new System.Drawing.Point(10, 305);
            this.dgvWeterMeterAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvWeterMeterAccount.Name = "dgvWeterMeterAccount";
            this.dgvWeterMeterAccount.RowTemplate.Height = 28;
            this.dgvWeterMeterAccount.Size = new System.Drawing.Size(806, 111);
            this.dgvWeterMeterAccount.TabIndex = 3;
            // 
            // gbrMeters
            // 
            this.gbrMeters.Controls.Add(this.rbVolumeUsed);
            this.gbrMeters.Controls.Add(this.rbMeterId);
            this.gbrMeters.Location = new System.Drawing.Point(30, 433);
            this.gbrMeters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbrMeters.Name = "gbrMeters";
            this.gbrMeters.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbrMeters.Size = new System.Drawing.Size(210, 96);
            this.gbrMeters.TabIndex = 4;
            this.gbrMeters.TabStop = false;
            this.gbrMeters.Text = "Sort Water Meters";
            // 
            // rbVolumeUsed
            // 
            this.rbVolumeUsed.AutoSize = true;
            this.rbVolumeUsed.Location = new System.Drawing.Point(21, 65);
            this.rbVolumeUsed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbVolumeUsed.Name = "rbVolumeUsed";
            this.rbVolumeUsed.Size = new System.Drawing.Size(113, 21);
            this.rbVolumeUsed.TabIndex = 1;
            this.rbVolumeUsed.TabStop = true;
            this.rbVolumeUsed.Text = "Volume Used";
            this.rbVolumeUsed.UseVisualStyleBackColor = true;
            this.rbVolumeUsed.CheckedChanged += new System.EventHandler(this.rbVolumeUsed_CheckedChanged);
            // 
            // rbMeterId
            // 
            this.rbMeterId.AutoSize = true;
            this.rbMeterId.Location = new System.Drawing.Point(21, 30);
            this.rbMeterId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMeterId.Name = "rbMeterId";
            this.rbMeterId.Size = new System.Drawing.Size(76, 21);
            this.rbMeterId.TabIndex = 0;
            this.rbMeterId.TabStop = true;
            this.rbMeterId.Text = "MeterId";
            this.rbMeterId.UseVisualStyleBackColor = true;
            this.rbMeterId.CheckedChanged += new System.EventHandler(this.rbMeterId_CheckedChanged);
            // 
            // btnCustomerArrers
            // 
            this.btnCustomerArrers.Location = new System.Drawing.Point(477, 443);
            this.btnCustomerArrers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomerArrers.Name = "btnCustomerArrers";
            this.btnCustomerArrers.Size = new System.Drawing.Size(134, 86);
            this.btnCustomerArrers.TabIndex = 5;
            this.btnCustomerArrers.Text = "Customer Arrears";
            this.btnCustomerArrers.UseVisualStyleBackColor = true;
            this.btnCustomerArrers.Click += new System.EventHandler(this.btnCustomerArrers_Click);
            // 
            // btnSummaryReportS
            // 
            this.btnSummaryReportS.Location = new System.Drawing.Point(626, 443);
            this.btnSummaryReportS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSummaryReportS.Name = "btnSummaryReportS";
            this.btnSummaryReportS.Size = new System.Drawing.Size(134, 86);
            this.btnSummaryReportS.TabIndex = 6;
            this.btnSummaryReportS.Text = "Summary Report";
            this.btnSummaryReportS.UseVisualStyleBackColor = true;
            this.btnSummaryReportS.Click += new System.EventHandler(this.btnSummaryReportS_Click);
            // 
            // grpWaterMeters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 540);
            this.Controls.Add(this.btnSummaryReportS);
            this.Controls.Add(this.btnCustomerArrers);
            this.Controls.Add(this.gbrMeters);
            this.Controls.Add(this.dgvWeterMeterAccount);
            this.Controls.Add(this.lblWaterMeterAccount);
            this.Controls.Add(this.lblWaterMeters);
            this.Controls.Add(this.dgvWatermeters);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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

