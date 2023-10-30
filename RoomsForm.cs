using DevExpress.DataAccess.Wizard.Native;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Layout;
using DXApplication1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication1.Controllers;

namespace DXApplication1
{
    public partial class RoomsForm : DevExpress.XtraEditors.XtraForm
    {
        public Reservation _currentReservation;
        private UnitOfWork uow;
        public RoomsForm(List<Room> rooms, DateTime ArrivalDate, DateTime DepartureDate, int amountOfAdults)
        {
            InitializeComponent();
            de_ArrivalDatef2.DateTime = ArrivalDate;
            de_DepartureDatef2.DateTime= DepartureDate;
            se_Adultsf2.Value = amountOfAdults;
            gc_Rooms.DataSource = new BindingList<Room>(rooms);
            InitializeUnitOfWork();
            InitializeView();
        }
        private void InitializeUnitOfWork() {
            UnitOfWork unitOfWork = new UnitOfWork();
            _currentReservation = new Reservation(unitOfWork);
        }
        private void InitializeView()
        {
            cv_Rooms.Columns["Oid"].Visible = false;
            //cv_Rooms.Columns["Number"].Visible = false;
            cv_Rooms.Columns["RoomCapacity"].Caption = "Adults";
            cv_Rooms.Columns["Wifi"].Visible = false;
            cv_Rooms.Columns["AirConditioning"].Visible = false;
            cv_Rooms.Columns["Bathroom"].Visible = false;
            createButton();
            cv_Rooms.LayoutChanged();
        }
        private void createButton()
        {
            GridColumn unboundColumn = cv_Rooms.Columns.AddField("");
            unboundColumn.VisibleIndex = cv_Rooms.Columns.Count;
            unboundColumn.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            unboundColumn.Width = 150;

            RepositoryItemButtonEdit repoButton = new RepositoryItemButtonEdit();
            repoButton.Buttons.Clear();

            repoButton.TextEditStyle = TextEditStyles.HideTextEditor;
            repoButton.ButtonsStyle = BorderStyles.Style3D;

            EditorButton editorButton = new EditorButton()
            {
                Kind = ButtonPredefines.Glyph,
                Caption = "More"
            };
            repoButton.Buttons.Add(editorButton);

            unboundColumn.ColumnEdit = repoButton;

            repoButton.ButtonClick += RepoButton_ButtonClick;
        }

        private void RepoButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            CardView view = (CardView)gc_Rooms.MainView;
            int handle = view.FocusedRowHandle;
            if (handle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                Room clickedRoom = (Room)view.GetRow(handle);
                if (clickedRoom != null)
                {
                    RoomInfoForm form = new RoomInfoForm(clickedRoom,this);
                    form.ShowDialog();
                }
            }
        }
    }
}