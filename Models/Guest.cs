using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.Xpo;

namespace DXApplication1.Models
{
    [Persistent("Guest")]
    public class Guest : XPObject
    {
        public Guest(Session session) : base(session) { }
        private string _FirstName;
        [Size(50)]
        public string FirstName
        {
            get => _FirstName;
            set { SetPropertyValue(nameof(FirstName), ref _FirstName, value); }
        }
        private string _LastName;
        [Size(50)]
        public string LastName
        {
            get => _LastName;
            set { SetPropertyValue(nameof(_LastName), ref _LastName, value); }
        }

        [Association("Guest-Reservations")]
        public XPCollection<Reservation> xpcReservations
        {
            get => GetCollection<Reservation>("xpcReservations");
        }
    }
}
