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
        RaceList raceList;
        //List<Races> raceList;
        public List<Races> historicalData;

        //private const string DIR_NAME = @"C:\Users\David.McNally";
   
        private string PATH_NAME;



        public Form1()
        {

            PATH_NAME = "Races.bin";
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            raceList = new RaceList();
            //raceList = new List<Races>();
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
                            race.Amount = decimal.Parse(entries[2]);
                            race.Outcome = bool.Parse(entries[3]);
                            raceList.Add(race);

                        }
                        br.Close();

                        foreach (var race in raceList)
                        {
                            rtbFile.AppendText($"Venue: {race.Name}, Date: {race.Date.ToShortDateString()} Length: {race.Amount} Outcome: {race.Outcome} " + Environment.NewLine);
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
                                
                using (StreamWriter br = new StreamWriter(PATH_NAME, append: true))
                {
                    Races race = new Races(txtName.Text, DateTime.Parse(dtpRaceDate.Text),int.Parse(txtLength.Text), chkWon.Checked );

                    // br.WriteLine($"{txtName.Text},{DateTime.Parse(dtpRaceDate.Text).ToShortDateString()},{txtLength.Text},{chkWon.Checked}");
                    br.WriteLine($"{race.Name}, {race.Date.ToShortDateString()}, {race.Amount}, {race.Outcome}");
                }
                MessageBox.Show("Race Added");

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
            catch (ArgumentNullException)
            {
                MessageBox.Show(ShowMessage());
            }

            catch (Exception ex)
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

                    dgvRaces.DataSource = raceList.GroupBy(race => race.Name)
                      .OrderByDescending(race => race.Count()).Take(1).ToList(); //all races ordered by date


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
                    dgvRaces.DataSource = raceList.OrderByDescending(race => race.Date.Year).GroupBy(race => new { race.Date.Year })
                   .Select(x => new
                   {
                       x.Key.Year,
                       TotalWon = raceList.Where(race => race.Outcome == true)
                   .Where(race => race.Date.Year == x.Key.Year).Sum(race => race.Amount),
                       TotalLost = raceList.Where(race => race.Outcome == false).Where(race => race.Date.Year == x.Key.Year).Sum(race => race.Amount)
                   }).ToList(); 
                    
                    // Total amount won and lost per year 

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

        private void rbHighestAmountWonLost_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbHighestAmountWonLost.Checked)
                {

                    dgvRaces.DataSource = raceList
                    .Select(x => new { MostWon = raceList.Where(race => race.Outcome == true).Max(y => y.Amount), MostLost = raceList.Where(race => race.Outcome == false).Max(race => race.Amount) }).Take(1).ToList();// == raceList.Max(x => x.Length)).ToList();
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
                var numberOfRaces = raceList.Select(race => race.Name).Count();
                var numberOfRacesWon = raceList.Where(race => race.Outcome == true).Select(race => race.Name).Count();
                var winPercentage = Math.Round(((decimal)numberOfRacesWon / numberOfRaces) * 100, 2);

                MessageBox.Show($"There has been {numberOfRaces} races " +
                    $"and HotTipster has won {numberOfRacesWon} Winrate is: {winPercentage}%");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public List<Races> LoadHistoricalData()
        {
            try
            {

                historicalData = new List<Races>()
            {
              
                 new Races { Name = "Aintree", Date = new DateTime(2017, 05, 12), Amount = 11.58m, Outcome = true },
                 new Races { Name = "Punchestown", Date = new DateTime(2016, 12, 22),Amount = 122.52m, Outcome = true },
                 new Races { Name =  "Sandown", Date = new DateTime (2016, 11, 17), Amount = 20.00m, Outcome = false },
                 new Races { Name = "Ayr", Date = new DateTime(2016, 11, 03), Amount = 25.00m, Outcome = false },
                 new Races { Name = "Fairyhouse", Date = new DateTime (2016, 12, 02), Amount = 65.75m, Outcome =  true },
                 new Races { Name = "Ayr", Date =  new DateTime(2017,03, 11), Amount = 12.05m, Outcome = true },
                 new Races { Name = "Doncaster", Date = new DateTime(2017, 12, 02), Amount = 10.00m, Outcome = false },
                 new Races { Name = "Towcester", Date = new DateTime(2016, 03, 12), Amount =  50.00m, Outcome = false },
                 new Races { Name = "Goodwood" , Date = new DateTime(2017, 10, 07), Amount =  525.74m, Outcome =  true },
                 new Races { Name = "Kelso", Date = new DateTime(2016, 09, 13), Amount = 43.21m, Outcome = true },
                 new Races { Name = "Punchestown", Date = new DateTime(2017, 07, 05), Amount = 35.00m, Outcome = false },
                 new Races { Name = "Ascot", Date = new DateTime(2016, 02, 04), Amount = 23.65m, Outcome = true },
                 new Races { Name = "Kelso",  Date = new DateTime(2017, 08, 02), Amount = 30.00m, Outcome = false },
                 new Races { Name = "Towcester", Date = new DateTime(2017, 05, 01),Amount = 104.33m, Outcome = true },
                 new Races { Name =  "Ascot",  Date=  new DateTime(2017, 06, 21), Amount = 25.00m, Outcome =  false },
                 new Races { Name = "Bangor", Date = new DateTime(2016, 12, 22), Amount = 30.00m, Outcome =  false },
                 new Races { Name = "Ayr", Date = new DateTime(2017, 05, 22), Amount = 11.50m, Outcome = true },
                 new Races { Name = "Ascot", Date = new DateTime(2017, 06, 23), Amount = 30.00m, Outcome = false },
                 new Races { Name = "Ascot", Date = new  DateTime(2017, 06, 23), Amount = 374.27m, Outcome = true },
                 new Races { Name = "Goodwood", Date = new DateTime(2016, 10, 05), Amount = 34.12m, Outcome = true },
                 new Races { Name = "Dundalk", Date = new DateTime(2016, 11, 09), Amount = 20.00m, Outcome = false },
                 new Races { Name = "Haydock", Date = new DateTime(2016, 11, 12), Amount = 87.00m, Outcome = true },
                 new Races { Name = "Perth", Date = new DateTime(2017, 01, 20), Amount = 15.00m, Outcome = false },
                 new Races { Name = "York", Date = new DateTime(2017, 11, 11), Amount = 101.25m, Outcome = true },
                 new Races { Name = "Punchestown", Date = new DateTime(2016, 12, 22), Amount = 11.50m, Outcome = true },
                 new Races { Name = "Chester", Date = new DateTime(2016, 08, 14), Amount =  10.00m, Outcome =  false },
                 new Races { Name = "Kelso", Date = new DateTime(2016, 09, 18),  Amount = 10.00m, Outcome =  false },
                 new Races { Name = "Kilbeggan",  Date = new DateTime(2017, 03, 03), Amount = 20.00m, Outcome = false },
                 new Races { Name = "Fairyhouse", Date = new DateTime(2017, 03, 11), Amount = 55.50m, Outcome = true },
                 new Races { Name = "Punchestown", Date = new DateTime(2016, 11, 15), Amount =  10.00m, Outcome = false },
                 new Races { Name = "Towcester", Date = new DateTime(2016, 05, 08), Amount = 16.55m, Outcome = true },
                 new Races { Name = "Punchestown", Date = new DateTime(2016, 05, 23), Amount = 13.71m, Outcome = true },
                 new Races { Name = "Cork", Date = new DateTime(2016, 11, 30), Amount = 20.00m, Outcome = false },
                 new Races { Name = "Punchestown", Date = new DateTime(2016, 04, 25), Amount = 13.45m, Outcome = true },
                 new Races { Name = "Bangor", Date = new DateTime(2016, 01, 23), Amount = 10.00m, Outcome = false },
                 new Races { Name = "Sandown", Date = new DateTime(2017, 08, 07), Amount = 25.00m, Outcome = false }
                };



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            return historicalData;
        }
       

        private void menuloadRaceDataToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            string message = "Uploading Historical Data will overwrite existing file Proceed?";
            string caption = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {

                historicalData = LoadHistoricalData(); // load historial data into list


                MessageBox.Show("Historial Data Added");

                using (StreamWriter br = new StreamWriter(PATH_NAME))
                {

                    foreach (var race in historicalData)
                    {
                        br.WriteLine($"{race.Name},{race.Date.ToShortDateString()},{race.Amount},{race.Outcome}");

                    }

                }
              }

            else
            {
                MessageBox.Show("Cancelled");
            }
          }
            
        }
    }
    
        

