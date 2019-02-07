using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class WaterMeter
    {
        public int MeterId { get; set; }
        public int VolumeUsed { get; set; }

        public bool HasBeenServiced { get; set; }

        public int OwnerAccountId { get; set; }
    }

   
}
