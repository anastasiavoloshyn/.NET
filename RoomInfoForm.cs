using DevExpress.XtraEditors;
using DevExpress.XtraTab.Buttons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication1.Models;

namespace DXApplication1
{
    public partial class RoomInfoForm : DevExpress.XtraEditors.XtraForm
    {
        private Room _Room;
        private RoomsForm _ParentForm;
        public RoomInfoForm(Room room, RoomsForm parentForm)
        {
            InitializeComponent();
            _Room = room;
            this._ParentForm = parentForm;
            LoadRoomDetails();
        }

        private void LoadRoomDetails()
        {
            lc_PriceValue.Text = $"{_Room.Price}";
            lc_CapacityValue.Text = $"{_Room.RoomCapacity}";
            lc_WifiValue.Text = $"{_Room.Wifi}";
            lc_ConditioningValue.Text = $"{_Room.AirConditioning}";
            lc_BathroomValue.Text = $"{_Room.Bathroom}";

        }

        private void b_ReservationAdd_Click(object sender, EventArgs e)
        {
            _ParentForm._currentReservation.AddRoom(this._Room);
        }
    }
}