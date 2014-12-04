﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class CreateActivity : Form
    {
        public CreateActivity()
        {
            InitializeComponent();
            //dateTimePicker.Format = DateTimePickerFormat.Custom;
            //dateTimePicker.CustomFormat = "MMMM dd " + " kl: " + "HH:mm";
        }

        private void SaveActivity(object sender, EventArgs e)
        {
            if (
                textTitle.Text != "" &&
                textTag.Text != "" &&
                richTextBoxDescription.Text != ""
                )
            {
                string title = textTitle.Text;
                string tags = textTag.Text;
                string description = richTextBoxDescription.Text;
                List<string> choice = new List<string>();

                if (cbMotor.Checked && !cbFood.Checked)
                {
                    choice.Add(cbMotor.Text);

                }

                if (!cbMotor.Checked && cbFood.Checked)
                {
                    choice.Add(cbFood.Text);
                }

                string tagString = "";
                foreach (string s in choice)
                {
                    tagString = tagString + "," + s;
                }
                lblErrorMsg.Text = "Aktivitet oprettet";
            }
            else
            {
                lblErrorMsg.Text = "Du skal sikre dig, at alle felter er udfyldt";
            }
        }
        private bool checkIfNumber(string txt) //Check to see if string only contains digits
        {
            bool pass = true;
            foreach (var ch in txt)
            {
                if (!char.IsDigit(ch))
                {
                    pass = false;
                }
            }
            return pass;
        }
    
    }

}