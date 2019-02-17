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
            this.btnWriteFile = new System.Windows.Forms.Button();
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
            this.chkWon = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvRaces = new System.Windows.Forms.DataGridView();
            this.dgvSortPopularity = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.rbSort = new System.Windows.Forms.RadioButton();
            this.rbSortPopularity = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtpRaceDate = new System.Windows.Forms.DateTimePicker();
            this.grpRace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortPopularity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFile.Location = new System.Drawing.Point(1336, 274);
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
            this.rtbFile.Location = new System.Drawing.Point(1043, 125);
            this.rtbFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbFile.Name = "rtbFile";
            this.rtbFile.Size = new System.Drawing.Size(439, 140);
            this.rtbFile.TabIndex = 1;
            this.rtbFile.Text = "";
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteFile.Location = new System.Drawing.Point(1172, 274);
            this.btnWriteFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(146, 59);
            this.btnWriteFile.TabIndex = 2;
            this.btnWriteFile.Text = "Write File";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
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
            this.lblLength.Size = new System.Drawing.Size(86, 29);
            this.lblLength.TabIndex = 8;
            this.lblLength.Text = "Length";
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
            // chkWon
            // 
            this.chkWon.AutoSize = true;
            this.chkWon.Location = new System.Drawing.Point(141, 195);
            this.chkWon.Name = "chkWon";
            this.chkWon.Size = new System.Drawing.Size(68, 24);
            this.chkWon.TabIndex = 11;
            this.chkWon.Text = "Won";
            this.chkWon.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1336, 876);
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
            this.dgvRaces.Location = new System.Drawing.Point(22, 445);
            this.dgvRaces.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvRaces.Name = "dgvRaces";
            this.dgvRaces.RowTemplate.Height = 24;
            this.dgvRaces.Size = new System.Drawing.Size(456, 402);
            this.dgvRaces.TabIndex = 19;
            // 
            // dgvSortPopularity
            // 
            this.dgvSortPopularity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSortPopularity.Location = new System.Drawing.Point(520, 445);
            this.dgvSortPopularity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSortPopularity.Name = "dgvSortPopularity";
            this.dgvSortPopularity.RowTemplate.Height = 24;
            this.dgvSortPopularity.Size = new System.Drawing.Size(456, 402);
            this.dgvSortPopularity.TabIndex = 20;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1014, 445);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(456, 402);
            this.dataGridView3.TabIndex = 21;
            // 
            // rbSort
            // 
            this.rbSort.AutoSize = true;
            this.rbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSort.Location = new System.Drawing.Point(14, 876);
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
            this.rbSortPopularity.Location = new System.Drawing.Point(520, 876);
            this.rbSortPopularity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSortPopularity.Name = "rbSortPopularity";
            this.rbSortPopularity.Size = new System.Drawing.Size(225, 29);
            this.rbSortPopularity.TabIndex = 23;
            this.rbSortPopularity.TabStop = true;
            this.rbSortPopularity.Text = "Sort by Popularity";
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
            // dtpRaceDate
            // 
            this.dtpRaceDate.Location = new System.Drawing.Point(141, 142);
            this.dtpRaceDate.Name = "dtpRaceDate";
            this.dtpRaceDate.Size = new System.Drawing.Size(219, 26);
            this.dtpRaceDate.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1496, 979);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbSortPopularity);
            this.Controls.Add(this.rbSort);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dgvSortPopularity);
            this.Controls.Add(this.dgvRaces);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpRace);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.rtbFile);
            this.Controls.Add(this.btnLoadFile);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpRace.ResumeLayout(false);
            this.grpRace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortPopularity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.RichTextBox rtbFile;
        private System.Windows.Forms.Button btnWriteFile;
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
        private System.Windows.Forms.DataGridView dgvSortPopularity;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.RadioButton rbSort;
        private System.Windows.Forms.RadioButton rbSortPopularity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkWon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpRaceDate;
    }
}

