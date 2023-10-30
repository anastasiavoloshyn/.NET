namespace DXApplication1
{
    partial class RoomsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gc_Rooms = new DevExpress.XtraGrid.GridControl();
            this.cv_Rooms = new DevExpress.XtraGrid.Views.Card.CardView();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.se_Adultsf2 = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.de_DepartureDatef2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.de_ArrivalDatef2 = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cv_Rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.se_Adultsf2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_DepartureDatef2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_DepartureDatef2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ArrivalDatef2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ArrivalDatef2.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_Rooms
            // 
            this.gc_Rooms.DataSource = typeof(DXApplication1.Models.Room);
            this.gc_Rooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Rooms.Location = new System.Drawing.Point(0, 0);
            this.gc_Rooms.MainView = this.cv_Rooms;
            this.gc_Rooms.Name = "gc_Rooms";
            this.gc_Rooms.Size = new System.Drawing.Size(959, 440);
            this.gc_Rooms.TabIndex = 0;
            this.gc_Rooms.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cv_Rooms});
            // 
            // cv_Rooms
            // 
            this.cv_Rooms.GridControl = this.gc_Rooms;
            this.cv_Rooms.Name = "cv_Rooms";
            this.cv_Rooms.OptionsView.ShowCardCaption = false;
            this.cv_Rooms.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 36);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gc_Rooms);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(959, 509);
            this.splitContainerControl1.SplitterPosition = 57;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.483837F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.74557F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.962461F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.67329F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.408389F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.67991F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.44592F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.28256F));
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.se_Adultsf2, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.de_DepartureDatef2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.de_ArrivalDatef2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton1, 7, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(906, 60);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(360, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Adults:";
            // 
            // se_Adultsf2
            // 
            this.se_Adultsf2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_Adultsf2.Location = new System.Drawing.Point(408, 3);
            this.se_Adultsf2.Name = "se_Adultsf2";
            this.se_Adultsf2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_Adultsf2.Size = new System.Drawing.Size(125, 24);
            this.se_Adultsf2.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(184, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "To:";
            // 
            // de_DepartureDatef2
            // 
            this.de_DepartureDatef2.EditValue = null;
            this.de_DepartureDatef2.Location = new System.Drawing.Point(219, 3);
            this.de_DepartureDatef2.Name = "de_DepartureDatef2";
            this.de_DepartureDatef2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_DepartureDatef2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_DepartureDatef2.Size = new System.Drawing.Size(125, 22);
            this.de_DepartureDatef2.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "From:";
            // 
            // de_ArrivalDatef2
            // 
            this.de_ArrivalDatef2.EditValue = null;
            this.de_ArrivalDatef2.Location = new System.Drawing.Point(43, 3);
            this.de_ArrivalDatef2.Name = "de_ArrivalDatef2";
            this.de_ArrivalDatef2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ArrivalDatef2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ArrivalDatef2.Size = new System.Drawing.Size(125, 22);
            this.de_ArrivalDatef2.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(687, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(159, 29);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Make a resrvation";
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 575);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "RoomsForm";
            this.Text = "RoomsForm";
            ((System.ComponentModel.ISupportInitialize)(this.gc_Rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cv_Rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.se_Adultsf2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_DepartureDatef2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_DepartureDatef2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ArrivalDatef2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ArrivalDatef2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Rooms;
        private DevExpress.XtraGrid.Views.Card.CardView cv_Rooms;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SpinEdit se_Adultsf2;
        private DevExpress.XtraEditors.DateEdit de_DepartureDatef2;
        private DevExpress.XtraEditors.DateEdit de_ArrivalDatef2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}