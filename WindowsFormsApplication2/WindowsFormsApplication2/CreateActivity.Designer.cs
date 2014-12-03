namespace WindowsFormsApplication2
{
    partial class CreateActivity
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
            this.labelCreate = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTags = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textTag = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbMotor = new System.Windows.Forms.CheckBox();
            this.cbFood = new System.Windows.Forms.CheckBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCreate
            // 
            this.labelCreate.Location = new System.Drawing.Point(775, 533);
            this.labelCreate.Margin = new System.Windows.Forms.Padding(4);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(100, 28);
            this.labelCreate.TabIndex = 0;
            this.labelCreate.Text = "Opret";
            this.labelCreate.UseVisualStyleBackColor = true;
            this.labelCreate.Click += new System.EventHandler(this.SaveActivity);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(20, 42);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 17);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Titel:";
            // 
            // labelTags
            // 
            this.labelTags.AutoSize = true;
            this.labelTags.Location = new System.Drawing.Point(20, 73);
            this.labelTags.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(44, 17);
            this.labelTags.TabIndex = 2;
            this.labelTags.Text = "Tags:";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(115, 39);
            this.textTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(132, 22);
            this.textTitle.TabIndex = 7;
            // 
            // textTag
            // 
            this.textTag.Location = new System.Drawing.Point(115, 70);
            this.textTag.Margin = new System.Windows.Forms.Padding(4);
            this.textTag.Name = "textTag";
            this.textTag.Size = new System.Drawing.Size(132, 22);
            this.textTag.TabIndex = 8;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(16, 151);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(84, 17);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "Beskrivelse:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(20, 171);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(853, 354);
            this.richTextBoxDescription.TabIndex = 12;
            this.richTextBoxDescription.Text = "";
            // 
            // cbMotor
            // 
            this.cbMotor.AutoSize = true;
            this.cbMotor.Location = new System.Drawing.Point(149, 127);
            this.cbMotor.Name = "cbMotor";
            this.cbMotor.Size = new System.Drawing.Size(66, 21);
            this.cbMotor.TabIndex = 13;
            this.cbMotor.Text = "Motor";
            this.cbMotor.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            this.cbFood.AutoSize = true;
            this.cbFood.Location = new System.Drawing.Point(319, 127);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(57, 21);
            this.cbFood.TabIndex = 14;
            this.cbFood.Text = "Mad";
            this.cbFood.UseVisualStyleBackColor = true;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Location = new System.Drawing.Point(552, 533);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 17);
            this.lblErrorMsg.TabIndex = 15;
            // 
            // CreateActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 576);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.cbFood);
            this.Controls.Add(this.cbMotor);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textTag);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.labelTags);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelCreate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateActivity";
            this.Text = "Opret aktivitet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button labelCreate;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTags;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textTag;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cbMotor;
        private System.Windows.Forms.CheckBox cbFood;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}

