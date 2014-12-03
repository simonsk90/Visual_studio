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
            this.SuspendLayout();
            // 
            // buttonAdminCreateLocation
            // 
            this.buttonAdminCreateLocation.Location = new System.Drawing.Point(47, 103);
            this.buttonAdminCreateLocation.Name = "buttonAdminCreateLocation";
            this.buttonAdminCreateLocation.Size = new System.Drawing.Size(108, 23);
            this.buttonAdminCreateLocation.TabIndex = 1;
            this.buttonAdminCreateLocation.Text = "Opret lokation";
            this.buttonAdminCreateLocation.UseVisualStyleBackColor = true;
            this.buttonAdminCreateLocation.Click += new System.EventHandler(this.buttonAdminCreateLocation_Click);
            // 
            // buttonEventCreateEvent
            // 
            this.buttonEventCreateEvent.Location = new System.Drawing.Point(47, 154);
            this.buttonEventCreateEvent.Name = "buttonEventCreateEvent";
            this.buttonEventCreateEvent.Size = new System.Drawing.Size(108, 23);
            this.buttonEventCreateEvent.TabIndex = 2;
            this.buttonEventCreateEvent.Text = "Opret event";
            this.buttonEventCreateEvent.UseVisualStyleBackColor = true;
            this.buttonEventCreateEvent.Click += new System.EventHandler(this.buttonEventCreateEvent_Click);
            // 
            // buttonActivityCreate
            // 
            this.buttonActivityCreate.Location = new System.Drawing.Point(47, 47);
            this.buttonActivityCreate.Name = "buttonActivityCreate";
            this.buttonActivityCreate.Size = new System.Drawing.Size(108, 23);
            this.buttonActivityCreate.TabIndex = 3;
            this.buttonActivityCreate.Text = "Opret aktivitet\r\n";
            this.buttonActivityCreate.UseVisualStyleBackColor = true;
            this.buttonActivityCreate.Click += new System.EventHandler(this.buttonActivityCreate_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 342);
            this.Controls.Add(this.buttonActivityCreate);
            this.Controls.Add(this.buttonEventCreateEvent);
            this.Controls.Add(this.buttonAdminCreateLocation);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdminCreateLocation;
        private System.Windows.Forms.Button buttonEventCreateEvent;
        private System.Windows.Forms.Button buttonActivityCreate;
    }
}