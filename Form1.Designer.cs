namespace DXApplication1
{
    partial class Form1
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
            this.deDeparture = new DevExpress.XtraEditors.DateEdit();
            this.deArrival = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.seAmountOfAdults = new DevExpress.XtraEditors.SpinEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.deDeparture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDeparture.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deArrival.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deArrival.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAmountOfAdults.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // deDeparture
            // 
            this.deDeparture.EditValue = null;
            this.deDeparture.Location = new System.Drawing.Point(466, 115);
            this.deDeparture.Name = "deDeparture";
            this.deDeparture.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDeparture.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDeparture.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deDeparture.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deDeparture.Size = new System.Drawing.Size(125, 22);
            this.deDeparture.TabIndex = 0;
            // 
            // deArrival
            // 
            this.deArrival.EditValue = null;
            this.deArrival.Location = new System.Drawing.Point(146, 115);
            this.deArrival.Name = "deArrival";
            this.deArrival.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deArrival.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deArrival.Size = new System.Drawing.Size(125, 22);
            this.deArrival.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(229, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(283, 36);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Fill in the information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(40, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(399, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(194, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adults";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton1.Location = new System.Drawing.Point(272, 280);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(167, 50);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Find";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // seAmountOfAdults
            // 
            this.seAmountOfAdults.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seAmountOfAdults.Location = new System.Drawing.Point(299, 199);
            this.seAmountOfAdults.Name = "seAmountOfAdults";
            this.seAmountOfAdults.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAmountOfAdults.Properties.IsFloatValue = false;
            this.seAmountOfAdults.Properties.MaskSettings.Set("mask", "d");
            this.seAmountOfAdults.Properties.MaxValue = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.seAmountOfAdults.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seAmountOfAdults.Size = new System.Drawing.Size(125, 24);
            this.seAmountOfAdults.TabIndex = 16;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(631, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 29);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "I\'m admin";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 342);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.seAmountOfAdults);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.deArrival);
            this.Controls.Add(this.deDeparture);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.deDeparture.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDeparture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deArrival.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deArrival.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAmountOfAdults.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit deDeparture;
        private DevExpress.XtraEditors.DateEdit deArrival;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SpinEdit seAmountOfAdults;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}

