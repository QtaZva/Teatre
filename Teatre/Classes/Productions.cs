using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatre.Classes
{
    internal class Productions
    {
        int id;
        int role_id, actor_id;
        string appointment_date, withdrawal_date;
        public int Role_id
        {
            get { return id; }
            set { id = value; }
        }
        public int Actor_id
        {
            set { id = value; }
            get { return actor_id; }
        }
        public string Appointment_date
        {
            set {  appointment_date = value; }
            get { return appointment_date; }
        }
        public string Withdrawal_date
        {
            set { withdrawal_date = value; }
            get { return withdrawal_date; }
        }
        public Productions() { }
        public Productions(int role_id, int actor_id, string appointment_date, string withdrawal_date)
        {
            this.role_id = role_id;
            this.actor_id = actor_id;
            this.appointment_date = appointment_date;
            this.withdrawal_date = withdrawal_date;
        }
    }
}
