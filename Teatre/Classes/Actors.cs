using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatre.Classes
{
    internal class Actors // Таблица актёров
    {
        public int id { get; set; }
        public string fullName, gender, rank;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
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

        public Actors(string fullName, string gender, string rank) 
        { 
            this.fullName = fullName;
            this.gender = gender;
            this.rank = rank;
        }
    }
}
