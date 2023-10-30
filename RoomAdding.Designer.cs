namespace DXApplication1
{
    partial class RoomAdding
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_SelectImage = new DevExpress.XtraEditors.SimpleButton();
            this.lbc_Rooms = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SaveImage = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbc_Rooms)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 272);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // b_SelectImage
            // 
            this.b_SelectImage.Location = new System.Drawing.Point(12, 151);
            this.b_SelectImage.Name = "b_SelectImage";
            this.b_SelectImage.Size = new System.Drawing.Size(107, 39);
            this.b_SelectImage.TabIndex = 4;
            this.b_SelectImage.Text = "Select Image";
            this.b_SelectImage.Click += new System.EventHandler(this.b_SelectImage_Click);
            // 
            // lbc_Rooms
            // 
            this.lbc_Rooms.DisplayMember = "Number";
            this.lbc_Rooms.Location = new System.Drawing.Point(12, 91);
            this.lbc_Rooms.Name = "lbc_Rooms";
            this.lbc_Rooms.Size = new System.Drawing.Size(237, 42);
            this.lbc_Rooms.TabIndex = 5;
            this.lbc_Rooms.ValueMember = "Number";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(259, 16);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Select room to which you want to add photos";
            // 
            // SaveImage
            // 
            this.SaveImage.Location = new System.Drawing.Point(12, 515);
            this.SaveImage.Name = "SaveImage";
            this.SaveImage.Size = new System.Drawing.Size(94, 29);
            this.SaveImage.TabIndex = 7;
            this.SaveImage.Text = "Save Image";
            this.SaveImage.Click += new System.EventHandler(this.b_SaveImage_Click);
            // 
            // RoomAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 593);
            this.Controls.Add(this.SaveImage);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbc_Rooms);
            this.Controls.Add(this.b_SelectImage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RoomAdding";
            this.Text = "RoomAdding";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbc_Rooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton b_SelectImage;
        private DevExpress.XtraEditors.ListBoxControl lbc_Rooms;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton SaveImage;
    }
}