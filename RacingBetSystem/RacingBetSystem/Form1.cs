using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingBetSystem
{
    public partial class Form1 : Form
    {
        public List<Races> raceList;
        private const string DIR_NAME = @"C:\Users\david\Documents";
        private const string SRCFile = "RaceBet.bin";
        private readonly string PATH_NAME;

        public Form1()
        {
            PATH_NAME = $@"{DIR_NAME}\{SRCFile}";
            InitializeComponent();
            raceList = new List<Races>
            {
                new Races{Name = "Ascot", Date = new DateTime(2017, 05, 12), Length = 11.58, Outcome = true  },
                 new Races{Name = "Punchestown", Date = new DateTime(2016, 12, 22), Length = 122.52, Outcome = true  },
                  new Races{Name = "Sandown", Date = new DateTime(2016, 11, 17), Length = 20.00, Outcome = false },
                   new Races{Name = "Ayr", Date = new DateTime(2016, 03, 11), Length = 25.00, Outcome = false  }
                   

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
            btnWriteFIle.Enabled = false;
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

        private void btnWriteFIle_Click(object sender, EventArgs e)
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

                        MessageBox.Show("File written to");


                    }

                }
            }
            catch (Exception ex)
            {

            }
       }
    }
}
