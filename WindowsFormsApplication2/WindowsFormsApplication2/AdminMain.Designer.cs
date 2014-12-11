namespace WindowsFormsApplication2
{
    partial class AdminMain
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
            this.buttonAdminCreateLocation = new System.Windows.Forms.Button();
            this.buttonEventCreateEvent = new System.Windows.Forms.Button();
            this.buttonActivityCreate = new System.Windows.Forms.Button();
            this.buttonViewEvents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdminCreateLocation
            // 
            this.buttonAdminCreateLocation.Location = new System.Drawing.Point(35, 84);
            this.buttonAdminCreateLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdminCreateLocation.Name = "buttonAdminCreateLocation";
            this.buttonAdminCreateLocation.Size = new System.Drawing.Size(81, 19);
            this.buttonAdminCreateLocation.TabIndex = 1;
            this.buttonAdminCreateLocation.Text = "Opret lokation";
            this.buttonAdminCreateLocation.UseVisualStyleBackColor = true;
            this.buttonAdminCreateLocation.Click += new System.EventHandler(this.buttonAdminCreateLocation_Click);
            // 
            // buttonEventCreateEvent
            // 
            this.buttonEventCreateEvent.Location = new System.Drawing.Point(35, 125);
            this.buttonEventCreateEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEventCreateEvent.Name = "buttonEventCreateEvent";
            this.buttonEventCreateEvent.Size = new System.Drawing.Size(81, 19);
            this.buttonEventCreateEvent.TabIndex = 2;
            this.buttonEventCreateEvent.Text = "Opret event";
            this.buttonEventCreateEvent.UseVisualStyleBackColor = true;
            this.buttonEventCreateEvent.Click += new System.EventHandler(this.buttonEventCreateEvent_Click);
            // 
            // buttonActivityCreate
            // 
            this.buttonActivityCreate.Location = new System.Drawing.Point(35, 38);
            this.buttonActivityCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonActivityCreate.Name = "buttonActivityCreate";
            this.buttonActivityCreate.Size = new System.Drawing.Size(81, 19);
            this.buttonActivityCreate.TabIndex = 3;
            this.buttonActivityCreate.Text = "Opret aktivitet\r\n";
            this.buttonActivityCreate.UseVisualStyleBackColor = true;
            this.buttonActivityCreate.Click += new System.EventHandler(this.buttonActivityCreate_Click);
            // 
            // buttonViewEvents
            // 
            this.buttonViewEvents.Location = new System.Drawing.Point(35, 164);
            this.buttonViewEvents.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewEvents.Name = "buttonViewEvents";
            this.buttonViewEvents.Size = new System.Drawing.Size(81, 19);
            this.buttonViewEvents.TabIndex = 4;
            this.buttonViewEvents.Text = "Se events";
            this.buttonViewEvents.UseVisualStyleBackColor = true;
            this.buttonViewEvents.Click += new System.EventHandler(this.buttonViewEvents_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 278);
            this.Controls.Add(this.buttonViewEvents);
            this.Controls.Add(this.buttonActivityCreate);
            this.Controls.Add(this.buttonEventCreateEvent);
            this.Controls.Add(this.buttonAdminCreateLocation);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdminCreateLocation;
        private System.Windows.Forms.Button buttonEventCreateEvent;
        private System.Windows.Forms.Button buttonActivityCreate;
        private System.Windows.Forms.Button buttonViewEvents;
    }
}