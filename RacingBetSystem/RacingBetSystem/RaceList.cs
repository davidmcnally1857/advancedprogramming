using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingBetSystem
{
    class RaceList
    {
        public List<Races> raceList;
        public Races Race;
        public RaceList()
        { }
        public RaceList(Races race)
        {
            raceList = new List<Races>();
            Race = race;
            
        }

        public void Add(Races race)
        {
            raceList.Add(race);
        }

        public void Remove(Races race)
        {
            if(raceList !=null)
            {
                raceList.Remove(race);
            }

            
        }

    }
}
