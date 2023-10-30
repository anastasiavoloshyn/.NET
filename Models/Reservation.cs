using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.Xpo;

namespace DXApplication1.Models
{
    [Persistent("Reservations")]
    public class Reservation : XPObject
    {
        public Reservation(Session session): base (session) { }

        private DateTime _StartDate;
        public DateTime StartDate
        {
            get => _StartDate;
            set { SetPropertyValue(nameof(StartDate), ref _StartDate, value); }
        }
        private DateTime _EndDate;
        public DateTime EndDate
        {
            get => _EndDate;
            set { SetPropertyValue(nameof(EndDate), ref _EndDate, value); }
        }

        [Association("Guest-Reservations")]
        public Guest Guest
        {
            get => GetPropertyValue<Guest>(nameof(Guest));
            set { SetPropertyValue(nameof(Guest), value); }
        }
        [Association("Room-Reservations")]
        public Room Room
        {
            get => GetPropertyValue<Room>(nameof(Room));
            set { SetPropertyValue(nameof(Room), value); }
        }
    }
}
