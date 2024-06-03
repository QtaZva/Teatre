using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatre.Classes
{
    internal class Roles
    {
        int id { get; set; }
        string name, piece;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Piece
        {
            get { return piece; }
            set { piece = value; }
        }
        public Roles() { }
        public Roles(string name, string piece)
        {
            this.name = name;
            this.piece = piece;
        }
    }
}
