namespace RacingBetSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.rtbFile = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpRace = new System.Windows.Forms.GroupBox();
            this.dtpRaceDate = new System.Windows.Forms.DateTimePicker();
            this.chkWon = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvRaces = new System.Windows.Forms.DataGridView();
            this.rbSort = new System.Windows.Forms.RadioButton();
            this.rbSortPopularity = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbsSortMoney = new System.Windows.Forms.RadioButton();
            this.rbHighestAmountWonLost = new System.Windows.Forms.RadioButton();
            this.btnReport = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuloadRaceDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTipDetails = new System.Windows.Forms.Label();
            this.grpRace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFile.Location = new System.Drawing.Point(998, 370);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(146, 59);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // rtbFile
            // 
            this.rtbFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFile.Location = new System.Drawing.Point(974, 74);
            this.rtbFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbFile.Name = "rtbFile";
            this.rtbFile.Size = new System.Drawing.Size(579, 270);
            this.rtbFile.TabIndex = 1;
            this.rtbFile.Text = "";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(141, 34);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 35);
            this.txtName.TabIndex = 3;
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(141, 88);
            this.txtLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(217, 35);
            this.txtLength.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(18, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(18, 94);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(94, 29);
            this.lblLength.TabIndex = 8;
            this.lblLength.Text = "Amount";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(18, 142);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 29);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.Location = new System.Drawing.Point(18, 191);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(111, 29);
            this.lblOutcome.TabIndex = 10;
            this.lblOutcome.Text = "Outcome";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(558, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(378, 82);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "HotTipster";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(136, 345);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 59);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(263, 345);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 59);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpRace
            // 
            this.grpRace.Controls.Add(this.dtpRaceDate);
            this.grpRace.Controls.Add(this.chkWon);
            this.grpRace.Controls.Add(this.lblName);
            this.grpRace.Controls.Add(this.txtName);
            this.grpRace.Controls.Add(this.txtLength);
            this.grpRace.Controls.Add(this.lblLength);
            this.grpRace.Controls.Add(this.lblDate);
            this.grpRace.Controls.Add(this.lblOutcome);
            this.grpRace.Location = new System.Drawing.Point(44, 74);
            this.grpRace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRace.Name = "grpRace";
            this.grpRace.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRace.Size = new System.Drawing.Size(434, 246);
            this.grpRace.TabIndex = 17;
            this.grpRace.TabStop = false;
            // 
            // dtpRaceDate
            // 
            this.dtpRaceDate.Location = new System.Drawing.Point(141, 142);
            this.dtpRaceDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpRaceDate.Name = "dtpRaceDate";
            this.dtpRaceDate.Size = new System.Drawing.Size(219, 26);
            this.dtpRaceDate.TabIndex = 25;
            // 
            // chkWon
            // 
            this.chkWon.AutoSize = true;
            this.chkWon.Location = new System.Drawing.Point(141, 195);
            this.chkWon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkWon.Name = "chkWon";
            this.chkWon.Size = new System.Drawing.Size(68, 24);
            this.chkWon.TabIndex = 11;
            this.chkWon.Text = "Won";
            this.chkWon.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1348, 886);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 59);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvRaces
            // 
            this.dgvRaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaces.Location = new System.Drawing.Point(14, 542);
            this.dgvRaces.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvRaces.Name = "dgvRaces";
            this.dgvRaces.RowTemplate.Height = 24;
            this.dgvRaces.Size = new System.Drawing.Size(706, 402);
            this.dgvRaces.TabIndex = 19;
            // 
            // rbSort
            // 
            this.rbSort.AutoSize = true;
            this.rbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSort.Location = new System.Drawing.Point(760, 606);
            this.rbSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSort.Name = "rbSort";
            this.rbSort.Size = new System.Drawing.Size(168, 29);
            this.rbSort.TabIndex = 22;
            this.rbSort.TabStop = true;
            this.rbSort.Text = "Sort by Date";
            this.rbSort.UseVisualStyleBackColor = true;
            this.rbSort.CheckedChanged += new System.EventHandler(this.rbSort_CheckedChanged);
            // 
            // rbSortPopularity
            // 
            this.rbSortPopularity.AutoSize = true;
            this.rbSortPopularity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSortPopularity.Location = new System.Drawing.Point(760, 644);
            this.rbSortPopularity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSortPopularity.Name = "rbSortPopularity";
            this.rbSortPopularity.Size = new System.Drawing.Size(258, 29);
            this.rbSortPopularity.TabIndex = 23;
            this.rbSortPopularity.TabStop = true;
            this.rbSortPopularity.Text = "Most Popular Course";
            this.rbSortPopularity.UseVisualStyleBackColor = true;
            this.rbSortPopularity.CheckedChanged += new System.EventHandler(this.rbSortPopularity_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(549, 125);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 279);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // rbsSortMoney
            // 
            this.rbsSortMoney.AutoSize = true;
            this.rbsSortMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsSortMoney.Location = new System.Drawing.Point(760, 681);
            this.rbsSortMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbsSortMoney.Name = "rbsSortMoney";
            this.rbsSortMoney.Size = new System.Drawing.Size(366, 29);
            this.rbsSortMoney.TabIndex = 25;
            this.rbsSortMoney.TabStop = true;
            this.rbsSortMoney.Text = "Amount Won and Lost per Year";
            this.rbsSortMoney.UseVisualStyleBackColor = true;
            this.rbsSortMoney.CheckedChanged += new System.EventHandler(this.rbsSortMoney_CheckedChanged);
            // 
            // rbHighestAmountWonLost
            // 
            this.rbHighestAmountWonLost.AutoSize = true;
            this.rbHighestAmountWonLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHighestAmountWonLost.Location = new System.Drawing.Point(760, 719);
            this.rbHighestAmountWonLost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbHighestAmountWonLost.Name = "rbHighestAmountWonLost";
            this.rbHighestAmountWonLost.Size = new System.Drawing.Size(355, 29);
            this.rbHighestAmountWonLost.TabIndex = 27;
            this.rbHighestAmountWonLost.TabStop = true;
            this.rbHighestAmountWonLost.Text = "Highest Amount Won and Lost";
            this.rbHighestAmountWonLost.UseVisualStyleBackColor = true;
            this.rbHighestAmountWonLost.CheckedChanged += new System.EventHandler(this.rbHighestAmountWonLost_CheckedChanged);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(760, 756);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(242, 59);
            this.btnReport.TabIndex = 29;
            this.btnReport.Text = "Win Rate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1567, 33);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuloadRaceDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuloadRaceDataToolStripMenuItem
            // 
            this.menuloadRaceDataToolStripMenuItem.Name = "menuloadRaceDataToolStripMenuItem";
            this.menuloadRaceDataToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.menuloadRaceDataToolStripMenuItem.Text = "LoadRaceData";
            this.menuloadRaceDataToolStripMenuItem.Click += new System.EventHandler(this.menuloadRaceDataToolStripMenuItem_Click_1);
            // 
            // lblTipDetails
            // 
            this.lblTipDetails.AutoSize = true;
            this.lblTipDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipDetails.Location = new System.Drawing.Point(47, 61);
            this.lblTipDetails.Name = "lblTipDetails";
            this.lblTipDetails.Size = new System.Drawing.Size(143, 20);
            this.lblTipDetails.TabIndex = 31;
            this.lblTipDetails.Text = "Enter Tip Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1567, 979);
            this.Controls.Add(this.lblTipDetails);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.rbHighestAmountWonLost);
            this.Controls.Add(this.rbsSortMoney);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbSortPopularity);
            this.Controls.Add(this.rbSort);
            this.Controls.Add(this.dgvRaces);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpRace);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rtbFile);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Hot Tipster Bet Track";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpRace.ResumeLayout(false);
            this.grpRace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.RichTextBox rtbFile;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpRace;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvRaces;
        private System.Windows.Forms.RadioButton rbSort;
        private System.Windows.Forms.RadioButton rbSortPopularity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkWon;
        private System.Windows.Forms.DateTimePicker dtpRaceDate;
        private System.Windows.Forms.RadioButton rbsSortMoney;
        private System.Windows.Forms.RadioButton rbHighestAmountWonLost;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuloadRaceDataToolStripMenuItem;
        private System.Windows.Forms.Label lblTipDetails;
    }
}

