using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatre.Classes
{
    internal class Actors
    {
        int id;
        string full_name, gender, rank;

        public string Full_name
        {
            get { return full_name; }
            set { full_name = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        public Actors() { }

        public Actors(string full_name, string gender, string rank) 
        { 
            this.full_name = full_name;
            this.gender = gender;
            this.rank = rank;
        }
    }
}
