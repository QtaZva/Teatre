using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatre.Classes
{
    internal class Productions // Таблица постановок
    {
        public int id { get; set; }
        public int roleId, actorId;
        public string appointmentDate, withdrawalDate;
        public int RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }
        public int ActorId
        {
            set { actorId = value; }
            get { return actorId; }
        }
        public string AppointmentDate
        {
            set {  appointmentDate = value; }
            get { return appointmentDate; }
        }
        public string WithdrawalDate
        {
            set { withdrawalDate = value; }
            get { return withdrawalDate; }
        }
        public Productions() { }
        public Productions(int roleId, int actorId, string appointmentDate, string withdrawalDate)
        {
            this.roleId = roleId;
            this.actorId = actorId;
            this.appointmentDate = appointmentDate;
            this.withdrawalDate = withdrawalDate;
        }
    }
}
