using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;

namespace RacingBetSystem
{
    public partial class Form1 : Form
    {
        public List<Races> raceList;
        

        private const string DIR_NAME = @"C:\Users\David.McNally";
        private const string SRCFile = "Race.txt";
        private string PATH_NAME;
        
        

        public Form1()
        {
            
            PATH_NAME = $@"{DIR_NAME}\{SRCFile}";
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            raceList = new List<Races>();
            
            if (rtbFile != null)
            {
                rtbFile.Clear();
            }
            
           
            try
            {
                              
                using (FileStream fs = File.OpenRead(PATH_NAME))
                {
                    using (StreamReader br = new StreamReader(fs))
                    {
                        List<String> lines = File.ReadAllLines(PATH_NAME).ToList();

                        foreach (var line in lines)
                        {
                            Races race = new Races();
                            string[] entries = line.Split(',');
                            race.Name = entries[0];
                            race.Date = DateTime.Parse(entries[1]);
                            race.Length = decimal.Parse(entries[2]);
                            race.Outcome = bool.Parse(entries[3]);
                            raceList.Add(race);
                           
                        }
                        br.Close();

                        foreach (var race in raceList)
                        {
                            rtbFile.AppendText($"Venue: {race.Name}, Date: {race.Date.ToShortDateString()} Length: {race.Length} Outcome: {race.Outcome} " + Environment.NewLine);
                        }
                                                                                                                                                                  }
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
          
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        
            try
            {

                 MessageBox.Show("Race Added");
                   
                
                
                
                    using (StreamWriter br = new StreamWriter(PATH_NAME, append: true ))
                    {

                        br.WriteLine($"{txtName.Text},{DateTime.Parse(dtpRaceDate.Text)},{txtLength.Text},{chkWon.Checked}");
                           
    

                                             
                        MessageBox.Show($"File written to {PATH_NAME}");
                    br.Close();
                    }

                
                grpRace.ResetText();
                clearForm();
                
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
            try
            {
                if (rbSort.Checked)
                {
                    dgvRaces.DataSource = raceList.OrderByDescending(race => race.Date).ToList();
                   
                }
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show(ShowMessage());
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbSortPopularity_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (rbSortPopularity.Checked)
                {

                    dgvSortPopularity.DataSource = raceList.GroupBy(race => race.Name)
                        .OrderByDescending(race => race.Count()).Take(1).ToList();
                          
                    
                                                         
                }
                                          
               }

            catch (ArgumentNullException)
            {
                MessageBox.Show(ShowMessage());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
        private void rbsSortMoney_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbsSortMoney.Checked)
                {
                    dgvMoney.DataSource = raceList.GroupBy(race => new { race.Date.Year })
                   .Select(x => new
                   {
                       Year = x.Key.Year,
                       TotalWon = raceList.Where(race => race.Outcome == true)
                   .Where(race => race.Date.Year == x.Key.Year).Sum(race => race.Length),
                       TotalLost = raceList.Where(race => race.Outcome == false).Where(race => race.Date.Year == x.Key.Year).Sum(race => race.Length)
                   }).ToList();

                }
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show(ShowMessage());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbHighestAmountWonLost_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbHighestAmountWonLost.Checked)
                {

                    dgvAmountWonLost.DataSource = raceList
                    .Select(x => new { MostWon = raceList.Where(race => race.Outcome == true).Max(y => y.Length), MostLost = raceList.Where(race => race.Outcome == false).Max(race => race.Length) }).Take(1).ToList();// == raceList.Max(x => x.Length)).ToList();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
  
        public string ShowMessage()
            {
                return "Data needs to be added";
            }

        private void btnReport_Click(object sender, EventArgs e)
        {

            try
            {
               // MessageBox.Show($"{raceList.Select}");
                    
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
    }
        
}
