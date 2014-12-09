namespace WindowsFormsApplication2
{
    partial class CreateEvent
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
            this.dateTimePickerEvent = new System.Windows.Forms.DateTimePicker();
            this.eventLecture = new System.Windows.Forms.Label();
            this.eventDate = new System.Windows.Forms.Label();
            this.textEventLecture = new System.Windows.Forms.TextBox();
            this.eventAttendants = new System.Windows.Forms.Label();
            this.textEventAttendants = new System.Windows.Forms.TextBox();
            this.eventAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEventLocation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEventActivity = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerEvent
            // 
            this.dateTimePickerEvent.Location = new System.Drawing.Point(114, 87);
            this.dateTimePickerEvent.Name = "dateTimePickerEvent";
            this.dateTimePickerEvent.Size = new System.Drawing.Size(231, 22);
            this.dateTimePickerEvent.TabIndex = 0;
            // 
            // eventLecture
            // 
            this.eventLecture.AutoSize = true;
            this.eventLecture.Location = new System.Drawing.Point(33, 48);
            this.eventLecture.Name = "eventLecture";
            this.eventLecture.Size = new System.Drawing.Size(65, 17);
            this.eventLecture.TabIndex = 1;
            this.eventLecture.Text = "Afholder:";
            // 
            // eventDate
            // 
            this.eventDate.AutoSize = true;
            this.eventDate.Location = new System.Drawing.Point(33, 87);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(42, 17);
            this.eventDate.TabIndex = 2;
            this.eventDate.Text = "Dato:";
            // 
            // textEventLecture
            // 
            this.textEventLecture.Location = new System.Drawing.Point(114, 48);
            this.textEventLecture.Name = "textEventLecture";
            this.textEventLecture.Size = new System.Drawing.Size(100, 22);
            this.textEventLecture.TabIndex = 3;
            // 
            // eventAttendants
            // 
            this.eventAttendants.AutoSize = true;
            this.eventAttendants.Location = new System.Drawing.Point(33, 126);
            this.eventAttendants.Name = "eventAttendants";
            this.eventAttendants.Size = new System.Drawing.Size(60, 17);
            this.eventAttendants.TabIndex = 4;
            this.eventAttendants.Text = "Pladser:";
            // 
            // textEventAttendants
            // 
            this.textEventAttendants.Location = new System.Drawing.Point(114, 126);
            this.textEventAttendants.Name = "textEventAttendants";
            this.textEventAttendants.Size = new System.Drawing.Size(100, 22);
            this.textEventAttendants.TabIndex = 5;
            // 
            // eventAdd
            // 
            this.eventAdd.Location = new System.Drawing.Point(139, 258);
            this.eventAdd.Name = "eventAdd";
            this.eventAdd.Size = new System.Drawing.Size(75, 23);
            this.eventAdd.TabIndex = 6;
            this.eventAdd.Text = "Tilføj";
            this.eventAdd.UseVisualStyleBackColor = true;
            this.eventAdd.Click += new System.EventHandler(this.eventAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lokation:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxEventLocation
            // 
            this.comboBoxEventLocation.FormattingEnabled = true;
            this.comboBoxEventLocation.Location = new System.Drawing.Point(114, 163);
            this.comboBoxEventLocation.Name = "comboBoxEventLocation";
            this.comboBoxEventLocation.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEventLocation.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Aktivitet:";
            // 
            // comboBoxEventActivity
            // 
            this.comboBoxEventActivity.FormattingEnabled = true;
            this.comboBoxEventActivity.Location = new System.Drawing.Point(114, 201);
            this.comboBoxEventActivity.Name = "comboBoxEventActivity";
            this.comboBoxEventActivity.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEventActivity.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Tilføj ny adresse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Location = new System.Drawing.Point(145, 294);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 17);
            this.lblErrorMsg.TabIndex = 12;
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 334);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxEventActivity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEventLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventAdd);
            this.Controls.Add(this.textEventAttendants);
            this.Controls.Add(this.eventAttendants);
            this.Controls.Add(this.textEventLecture);
            this.Controls.Add(this.eventDate);
            this.Controls.Add(this.eventLecture);
            this.Controls.Add(this.dateTimePickerEvent);
            this.Name = "Event";
            this.Text = "Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerEvent;
        private System.Windows.Forms.Label eventLecture;
        private System.Windows.Forms.Label eventDate;
        private System.Windows.Forms.TextBox textEventLecture;
        private System.Windows.Forms.Label eventAttendants;
        private System.Windows.Forms.TextBox textEventAttendants;
        private System.Windows.Forms.Button eventAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEventLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEventActivity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}