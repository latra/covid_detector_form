using System;
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
    public partial class MedicUXForm : Form
    {
        Form currentForm;
        public MedicUXForm(string doctorName)
        {
            InitializeComponent();
            this.usernameLabel.Text = string.Format(usernameLabel.Text, doctorName);
            this.Text= string.Format(this.Text, doctorName);
            setColors();
            setActivePanel(new PatientsList(), "MedBot - Patients");
            
        }
        public void setColors()
        {
            Color menuColor = ColorTranslator.FromHtml("#9ADFFB");
            Color buttonOverColor= ColorTranslator.FromHtml("#12ADD7");
            Color buttonColor = ColorTranslator.FromHtml("#349CC5");
            Color titleColor = Color.FromArgb(100, ColorTranslator.FromHtml("#000000"));
            this.titleLabel.Font = new Font("Roboto", 46F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = Color.FromArgb(100, buttonColor);

            this.menuPanel.BackColor = Color.FromArgb(20, menuColor);
            this.headerPanel.BackColor = Color.FromArgb(20, menuColor);
            this.newPatientButton.BackColor =  buttonColor;
            this.newPatientButton.ForeColor = Color.White;
            this.newPatientButton.FlatAppearance.MouseOverBackColor = buttonOverColor;
            this.patientListButton.BackColor = buttonColor;
            this.patientListButton.ForeColor = Color.White;
            this.patientListButton.FlatAppearance.MouseOverBackColor = buttonOverColor;
            this.logoutButton.BackColor = buttonColor;
            this.logoutButton.ForeColor = Color.White;
            this.logoutButton.FlatAppearance.MouseOverBackColor = buttonOverColor;
            this.helpButton.BackColor = buttonColor;
            this.helpButton.ForeColor = Color.White;
            this.helpButton.FlatAppearance.MouseOverBackColor = buttonOverColor;
        }
        public void setActivePanel(Form childForm, string title)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.activePanel.Controls.Add(childForm);
            this.activePanel.Tag = childForm;
            this.titleLabel.Text = title;
            this.titleLabel.BackColor = Color.FromArgb(0, Color.White);
            childForm.BringToFront();
            childForm.Show();
        }

        private void patientListButton_Click(object sender, EventArgs e)
        {
            setActivePanel(new PatientsList(), "MedBot - Patients");
        }

        private void newPatientButton_Click(object sender, EventArgs e)
        {
            setActivePanel(new NewPatientForm(), "MedBot - New patient");

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var loginForm = new loginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
