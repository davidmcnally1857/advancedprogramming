using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingBetSystem
{
    public class RaceList: ICollection<Races>
    {
        public List<Races> RacesList { get; }

        public int Count
        {
            get
            {
                return RacesList.Count();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }

        }


        public RaceList()
        {
            RacesList = new List<Races>();
        }
               
        public void Add(Races race)
        {
            RacesList.Add(race);
        }

        public void Remove(Races race)
        {
            if(RacesList !=null)
            {
                RacesList.Remove(race);
            }

            else
            {
                throw new ArgumentNullException();
            }

            
        }

        public void Clear()
        {
            RacesList.Clear();
        }

        public bool Contains(Races item)
        {
            return RacesList.Contains(item);
        }

        public void CopyTo(Races[] array, int arrayIndex)
        {
           RacesList.CopyTo(array, arrayIndex);
        }

        bool ICollection<Races>.Remove(Races item)
        {
           return RacesList.Remove(item);
        }

        public IEnumerator<Races> GetEnumerator()
        {
            return RacesList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        
        public void Sort()
        {
            RacesList.Sort();
            
        }

        
    }
}
