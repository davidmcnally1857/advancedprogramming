using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingBetSystem
{
    public class Races 
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public bool Outcome { get; set; }

        public Races()
        { }

        public Races(string name, DateTime date, decimal length, bool outcome)
        {
            if(date > DateTime.Now)
            {
                throw new ArgumentOutOfRangeException();

            }

            if (name == null)
            {
                throw new ArgumentNullException();
            }

            if(length <= 0)
            {
                throw new ArgumentException();
            }


            else
            {
                
                Name = name;
                Date = date;
                Amount = length;
                Outcome = outcome;
            }
        }

      }
}
