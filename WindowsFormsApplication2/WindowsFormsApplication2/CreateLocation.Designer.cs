namespace WindowsFormsApplication2
{
    partial class CreateLocation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textLocationName = new System.Windows.Forms.TextBox();
            this.textLocationAddress = new System.Windows.Forms.TextBox();
            this.textLocationZipCode = new System.Windows.Forms.TextBox();
            this.textLocationCity = new System.Windows.Forms.TextBox();
            this.buttonLocationAdd = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Postnr.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "City:";
            // 
            // textLocationName
            // 
            this.textLocationName.Location = new System.Drawing.Point(126, 37);
            this.textLocationName.Name = "textLocationName";
            this.textLocationName.Size = new System.Drawing.Size(100, 22);
            this.textLocationName.TabIndex = 4;
            // 
            // textLocationAddress
            // 
            this.textLocationAddress.Location = new System.Drawing.Point(126, 77);
            this.textLocationAddress.Name = "textLocationAddress";
            this.textLocationAddress.Size = new System.Drawing.Size(100, 22);
            this.textLocationAddress.TabIndex = 5;
            // 
            // textLocationZipCode
            // 
            this.textLocationZipCode.Location = new System.Drawing.Point(126, 119);
            this.textLocationZipCode.Name = "textLocationZipCode";
            this.textLocationZipCode.Size = new System.Drawing.Size(100, 22);
            this.textLocationZipCode.TabIndex = 6;
            // 
            // textLocationCity
            // 
            this.textLocationCity.Location = new System.Drawing.Point(126, 158);
            this.textLocationCity.Name = "textLocationCity";
            this.textLocationCity.Size = new System.Drawing.Size(100, 22);
            this.textLocationCity.TabIndex = 7;
            // 
            // buttonLocationAdd
            // 
            this.buttonLocationAdd.Location = new System.Drawing.Point(126, 226);
            this.buttonLocationAdd.Name = "buttonLocationAdd";
            this.buttonLocationAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonLocationAdd.TabIndex = 8;
            this.buttonLocationAdd.Text = "Tilføj lokation";
            this.buttonLocationAdd.UseVisualStyleBackColor = true;
            this.buttonLocationAdd.Click += new System.EventHandler(this.buttonLocationAdd_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Location = new System.Drawing.Point(146, 283);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 17);
            this.lblErrorMsg.TabIndex = 9;
            // 
            // CreateLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 334);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.buttonLocationAdd);
            this.Controls.Add(this.textLocationCity);
            this.Controls.Add(this.textLocationZipCode);
            this.Controls.Add(this.textLocationAddress);
            this.Controls.Add(this.textLocationName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateLocation";
            this.Text = "CreateLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLocationName;
        private System.Windows.Forms.TextBox textLocationAddress;
        private System.Windows.Forms.TextBox textLocationZipCode;
        private System.Windows.Forms.TextBox textLocationCity;
        private System.Windows.Forms.Button buttonLocationAdd;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}