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

        public decimal Length { get; set; }
        
        public bool Outcome { get; set; }
    }
}
