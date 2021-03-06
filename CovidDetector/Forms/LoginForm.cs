﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CovidDetector.Modules;
using CovidDetector.Forms;
namespace CovidDetector
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            setColors();
        }
        public void setColors()
        {
            var etimage = new Bitmap(pictureBox2.BackgroundImage, new System.Drawing.Size(pictureBox2.Width, pictureBox2.Height));
            pictureBox2.BackgroundImage = etimage;
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
            LoginModule login = new LoginModule(this.userInput.Text, this.PasswordInput.Text);
            if (login.validate())
            {

                var medicPanelForm = new MedicUXForm(login.getName());
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
