using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class grpWaterMeters : Form
    {

        List<WaterMeter> WaterMeters;
        List<Account> Accounts;
        public grpWaterMeters()
        {
            InitializeComponent();

            WaterMeters = new List<WaterMeter>()
            {
                new WaterMeter
                {
                    MeterId = 100,
                    VolumeUsed = 68405,
                    HasBeenServiced = false,
                    OwnerAccountId = 10001

                },
              
                   new WaterMeter
                {
                    MeterId = 101,
                    VolumeUsed = 113609,
                    HasBeenServiced = true,
                    OwnerAccountId = 10002

                },
                    new WaterMeter
                {
                    MeterId = 102,
                    VolumeUsed = 138115,
                    HasBeenServiced = false,
                    OwnerAccountId = 10003

                },
                     new WaterMeter
                {
                    MeterId = 103,
                    VolumeUsed = 102191,
                    HasBeenServiced = true,
                    OwnerAccountId = 10004

                },
                      new WaterMeter
                {
                    MeterId = 104,
                    VolumeUsed = 791007,
                    HasBeenServiced = false,
                    OwnerAccountId = 10005

                },
            };

            Accounts = new List<Account>
            {
                new Account{ AccountId = 10001, Eircode = "K64R102", PaymentPeriod = PaymentPeriod.Annual, ArrearsCount = 2 },
                new Account{ AccountId = 10002, Eircode = "K64R103", PaymentPeriod = PaymentPeriod.Monthly, ArrearsCount = 2 },
                new Account{ AccountId = 10003, Eircode = "K64R104", PaymentPeriod = PaymentPeriod.Quarterly, ArrearsCount = 1 },
                new Account{ AccountId = 10004, Eircode = "K64S101", PaymentPeriod = PaymentPeriod.Monthly, ArrearsCount = 0 },
                new Account{ AccountId = 10005, Eircode = "K64S102", PaymentPeriod = PaymentPeriod.BiAnnual, ArrearsCount = 0 },
                new Account{ AccountId = 10006, Eircode = "K64S103", PaymentPeriod = PaymentPeriod.BiAnnual, ArrearsCount = 0 }
            };
        }

        private void grpWaterMeters_Load(object sender, EventArgs e)
        {
            dgvWatermeters.DataSource = (from waterMeter in WaterMeters
                                         select waterMeter).ToList();

            dgvWeterMeterAccount.DataSource = null;
        }

        private void dgvWatermeters_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int selectedAcc = Convert.ToInt32(dgvWatermeters.Rows[e.RowIndex].Cells[3].Value);

                dgvWeterMeterAccount.DataSource = (from account in Accounts
                                        where account.AccountId == selectedAcc
                                        select account).ToList();
            }
        }

        private void rbMeterId_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMeterId.Checked)
            {
                dgvWatermeters.DataSource = (from waterMeter in WaterMeters
                                             orderby waterMeter.MeterId
                                             select waterMeter).ToList();

                dgvWeterMeterAccount.DataSource = null;
            }
        }

        private void rbVolumeUsed_CheckedChanged(object sender, EventArgs e)
        {
            if(rbVolumeUsed.Checked)
            {
                dgvWatermeters.DataSource = (from waterMeter in WaterMeters
                                             orderby waterMeter.VolumeUsed
                                             select waterMeter).ToList();

               dgvWeterMeterAccount.DataSource = null;
            }
        }

        private void btnCustomerArrers_Click(object sender, EventArgs e)
        {
            using (CustomerArrearsReport cusArrReport = new CustomerArrearsReport(Accounts))
            {
                cusArrReport.ShowDialog();
            }
        }

        private void btnSummaryReportS_Click(object sender, EventArgs e)
        {
            int totalWater = (from waterMeter in WaterMeters
                              select waterMeter.VolumeUsed).Sum();

            int totalArrears = (from account in Accounts
                                where account.ArrearsCount > 0
                                select account.ArrearsCount).Count();

            MessageBox.Show($"Total water is {totalWater} and total arrears is {totalArrears}"); 
        }
    }
}
