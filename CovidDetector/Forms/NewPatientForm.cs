﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidDetector.Forms
{
    public partial class NewPatientForm : Form
    {
        public NewPatientForm()
        {
            InitializeComponent();
        }

                public void setColors()
                {
                    Color buttonColor = ColorTranslator.FromHtml("#56BEE7");
                    Color buttonOverColor = ColorTranslator.FromHtml("#349CC5");
                    this.button1.BackColor = buttonColor;
                    this.button1.ForeColor = Color.White;
                    this.button2.BackColor = buttonColor;
                    this.button2.ForeColor = Color.White;
                    button1.FlatAppearance.MouseOverBackColor = buttonOverColor;
                    button2.FlatAppearance.MouseOverBackColor = buttonOverColor;


                }

                private void button1_Click(object sender, EventArgs e)
                {
                    LoginModule login = new LoginModule(this.patientInput.Text, this.cardiopathy___yesInput.Text);
                    if (login.validate())
                    {
                        var medicPanelForm = new MedicUXForm();
                        this.Hide();
                        medicPanelForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Check the password and try again", "Invalid Password",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

    }
}
