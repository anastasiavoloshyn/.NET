using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DXApplication1.Controllers;
using DXApplication1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        List<Room> roomsList;
        public Form1()
        {
            InitializeComponent();
            InitialDefaultValues();
        }

        private void InitialDefaultValues()
        {
            deArrival.DateTime = DateTime.Now;
            deDeparture.DateTime = DateTime.Now.AddDays(2);
        }

        private bool ReservationCheck(UnitOfWork uow, DateTime arrivalDate, DateTime departureDate, Room room)
        {
            CriteriaOperator criteria = CriteriaOperator.Parse("[Room] = ?", room);
            XPCollection<Reservation> reservations = new XPCollection<Reservation>(uow, criteria);

            foreach (Reservation reservation in reservations)
            {
                if ((arrivalDate >= reservation.StartDate && arrivalDate < reservation.EndDate) ||
                    (departureDate > reservation.StartDate && departureDate <= reservation.EndDate))
                {
                    return false;
                }
            }

            return true;
        }
        private List<Room> GetAvailableRooms(UnitOfWork uow, DateTime arrivalDate, DateTime departureDate, int numberOfAdults)
        {
            CriteriaOperator criteria = CriteriaOperator.FromLambda<Room>(room => (room.RoomCapacity <= numberOfAdults || room.RoomCapacity == numberOfAdults + 1));
            XPCollection<Room> rooms = new XPCollection<Room>(uow)
            {
                Criteria = criteria
            };

            List<Room> availableRooms = new List<Room>();

            foreach (Room room in rooms)
            {
                if (ReservationCheck(uow, arrivalDate, departureDate, room))
                {
                    availableRooms.Add(room);
                }
            }

            return availableRooms;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime arrivalDate = deArrival.DateTime;
            DateTime departureDate = deDeparture.DateTime;
            int numberOfAdults = (int)seAmountOfAdults.Value;
            UnitOfWork uow = ConnectionHelper.CreateUnitOfWork();
            List<Room> availableRooms = GetAvailableRooms(uow, arrivalDate, departureDate, numberOfAdults);

            using (RoomsForm form2 = new RoomsForm(availableRooms, arrivalDate, departureDate, numberOfAdults))
            {
                form2.ShowDialog();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            RoomAdding form = new RoomAdding();
            form.ShowDialog();
            this.Close();
        }


    }
}
