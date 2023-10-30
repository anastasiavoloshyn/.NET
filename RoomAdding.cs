using DevExpress.Xpo;
using DevExpress.XtraEditors;
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
using DevExpress.XtraReports.UI;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.Data.Filtering;
using DXApplication1.Controllers;

namespace DXApplication1
{
    public partial class RoomAdding : DevExpress.XtraEditors.XtraForm
    {

        public RoomAdding()
        {
            InitializeComponent();
            InitializeData();
        }
        private void InitializeData()
        {
            using(SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HotelDBConnection"].ConnectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Rooms", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                lbc_Rooms.DataSource = dt;
                lbc_Rooms.DisplayMember = "Number";
                lbc_Rooms.ValueMember = "Number";
            }

        }
        private void b_SelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Filter to select only image files

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }
        private void b_SaveImage_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation != null && lbc_Rooms.SelectedValue != null)
            {
                int selectedRoomNumber = (int)lbc_Rooms.SelectedValue;
                byte[] imageData;
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    Image selectedImage = Image.FromFile(pictureBox1.ImageLocation);
                    selectedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageData = ms.ToArray();
                }

                using (UnitOfWork uow = ConnectionHelper.CreateUnitOfWork())
                {
                    Room selectedRoom = uow.FindObject<Room>(CriteriaOperator.Parse("Number=?", selectedRoomNumber));
                    if (selectedRoom != null)
                    {
                        RoomImage roomImage = new RoomImage(uow)
                        {
                            ImageData = imageData,
                            Room = selectedRoom
                        };

                        uow.CommitChanges();
                        MessageBox.Show("The image was succesfully added");
                    }
                    else
                    {
                        MessageBox.Show("Selected room was not found in the database.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room and an image first.");
            }
        }

    }
}