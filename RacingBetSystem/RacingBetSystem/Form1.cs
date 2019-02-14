using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace RacingBetSystem
{
    public partial class Form1 : Form
    {
        public List<Races> raceList;
        private const string DIR_NAME = @"C:\Users\david\Documents";
        private const string SRCFile = "RaceBet.txt";
        private string PATH_NAME;

        public Form1()
        {
            PATH_NAME = $@"{DIR_NAME}\{SRCFile}";
            InitializeComponent();
            raceList = new List<Races>
            {
                new Races{Name = "Ascot", Date = new DateTime(2017, 05, 12), Length = 11.58, Outcome = true  },
                new Races{Name = "Punchestown", Date = new DateTime(2016, 12, 22), Length = 122.52, Outcome = true  },
                new Races{Name = "Sandown", Date = new DateTime(2016, 11, 17), Length = 20.00, Outcome = false },
                new Races{Name = "Ayr", Date = new DateTime(2016, 03, 11), Length = 25.00, Outcome = false  },
                new Races{Name = "FairyHouse", Date = new DateTime(2016, 02, 12), Length = 65.75, Outcome = true  },
                new Races{Name = "Doncaster", Date = new DateTime(2017, 12, 02), Length = 10.00, Outcome = false  },
                new Races{Name = "Towcester", Date = new DateTime(2016, 03, 12), Length = 50.00, Outcome = false  }
               



            };

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
         
       
          if (rtbFile != null)
            {
                rtbFile.Clear();
            }
            btnWriteFile.Enabled = false;
            try
            {

                string name;
                double length;
                bool outcome;
                using (Stream fs = File.Open(PATH_NAME, FileMode.Open))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        foreach(var race in raceList)
                        {
                            name = br.ReadString();
                            length = br.ReadDouble();
                            outcome = br.ReadBoolean();
                            rtbFile.AppendText($"Venue: {name}  Length: {length} Outcome: {outcome}" + Environment.NewLine);
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {

            string name;
            double length;
            bool outcome;
            try
            {
                using (Stream fs = File.OpenWrite(PATH_NAME))
                {
                    using (BinaryWriter br = new BinaryWriter(fs))
                    {

                      foreach(var race in raceList)
                        {
                            name = race.Name;
                            br.Write(name);
                            length = race.Length;
                            br.Write(length);
                            outcome = race.Outcome;
                            br.Write(outcome);
                           
                        }

                        MessageBox.Show($"File written to {PATH_NAME}");


                    }

                }
            }
            catch (Exception ex)
            {

            }
       }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                raceList.Add(new Races { Name = txtName.Text, Date = new DateTime(2017, 11, 05), Length = int.Parse(txtLength.Text), Outcome = false });
                MessageBox.Show("Race Added");
                grpRace.ResetText();
                clearForm();
                btnWriteFile.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    
        public void clearForm()
        {
            foreach (Control c in grpRace.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void rbSort_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSort.Checked)
            {
                dgvRaces.DataSource = raceList.OrderBy(race => race.Date).ToList();
            }
        }

        private void rbSortPopularity_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSort.Checked)
            {
               // dgvSortPopularity.DataSource = (from race in raceList)
                
                                                

                                                
            }
        }

        public int getCount()
        {
            return 30;
        }
    }
    }

