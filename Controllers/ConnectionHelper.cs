using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo.DB;
using DXApplication1.Models;
using DevExpress.Data.Filtering;
using System.IO;

namespace DXApplication1.Controllers
{
    internal class ConnectionHelper
    {
        public static UnitOfWork CreateUnitOfWork()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HotelDBConnection"].ConnectionString;
            IDataLayer dataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);
            UnitOfWork uow = new UnitOfWork(dataLayer);
            return uow;
        }
        public static Room GetRoomByNumber(UnitOfWork uow, int roomNumber)
        {
            XPCollection<Room> rooms = new XPCollection<Room>(uow);
            CriteriaOperator criteria = new BinaryOperator("Number", roomNumber, BinaryOperatorType.Equal);
            rooms.Criteria = criteria;

            Room room = rooms.FirstOrDefault(); // Отримати перший об'єкт, який задовольняє критерії

            return room;
        }
        public static void createReservation(UnitOfWork uow,int roomNumber)
        {
            Reservation newReservation = new Reservation(uow);
            newReservation.StartDate = new DateTime(2023, 11, 12);
            newReservation.EndDate = new DateTime(2023, 11, 16);
            Room room=GetRoomByNumber(uow, roomNumber);
            newReservation.Room = room;
            uow.CommitChanges();
            
        }
        public List<byte[]> LoadImagesFromFolder(string folderPath)
        {
            List<byte[]> imageDatas = new List<byte[]>();
            string[] imagePaths = Directory.GetFiles(folderPath);
            
            foreach (var imagePath in imagePaths)
            {
                byte[] imageData = File.ReadAllBytes(imagePath);
                imageDatas.Add(imageData);
            }

            return imageDatas;
        }
        public void AddRoomImages(UnitOfWork uow, int roomId, List<byte[]> imageDatas)
        {
            Room room = uow.GetObjectByKey<Room>(roomId);
            if (room == null) throw new Exception($"Room with ID {roomId} not found.");

            // Create RoomImage instances and associate them with the Room
            foreach (byte[] imageData in imageDatas)
            {
                RoomImage roomImage = new RoomImage(uow)
                {
                    ImageData = imageData,
                    Room = room
                };
                room.RoomImages.Add(roomImage);
            }

            // Save changes to the database
            uow.CommitChanges();
        }

    }
}
