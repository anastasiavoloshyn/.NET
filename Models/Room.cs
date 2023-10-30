using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data;
using System.Drawing;
using DXApplication1.Models;

namespace DXApplication1.Models
{
    [Persistent("Rooms")]
    public class Room : XPObject
    {
        public Room(Session session) : base(session) { }
        private int _Number;
        public int Number
        {
            get => _Number;
            set { SetPropertyValue(nameof(Number), ref _Number, value); }
        }
        private int _RoomCapacity;
        public int RoomCapacity
        {
            get => _RoomCapacity;
            set { SetPropertyValue(nameof(RoomCapacity), ref _RoomCapacity, value); }
        }
        
        [Association("Rooms-Reservations")]
        public XPCollection<Reservation> xpcReservations
        {
            get => GetCollection<Reservation>("xpcReservations");
        }

        private decimal _Price;
        public decimal Price
        {
            get => _Price;
            set { SetPropertyValue(nameof(_Price), ref _Price, value); }
        }
        [Association("Room-RoomImages")]
        public XPCollection<RoomImage> RoomImages
        {
            get => GetCollection<RoomImage>(nameof(RoomImages));
        }
        private bool _IsReserved;
        public bool IsReserved
        {
            get => _IsReserved;
            set { SetPropertyValue(nameof(IsReserved), ref _IsReserved, value); }
        }
        private bool _Wifi;
        public bool Wifi
        {
            get => _Wifi;
            set
            {
                SetPropertyValue(nameof(Wifi), ref _Wifi, value);
            }
        }
        private bool _AirConditioning;
        public bool AirConditioning
        {
            get => _AirConditioning;
            set { SetPropertyValue(nameof(AirConditioning), ref _AirConditioning, value); }
        }
        private bool _Bathroom;
        public bool Bathroom
        {
            get => _Bathroom;
            set { SetPropertyValue(nameof(Bathroom), ref _Bathroom, value); }
        }

    }
}

[Persistent]
public class RoomImage : XPObject
{
    public RoomImage(Session session) : base(session) { }
    [Delayed(true),Size(SizeAttribute.Unlimited)]
    public byte[] ImageData
    {
        get => GetDelayedPropertyValue<byte[]>(nameof(ImageData));
        set { SetDelayedPropertyValue(nameof(ImageData), value); }
    }
    private Room _room;
    [Association("Room-RoomImages")]
    public Room Room
    {
        get => _room;
        set { SetPropertyValue(nameof(Room), ref _room, value); }
    }
}