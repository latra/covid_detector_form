using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CovidDetector.Models;
namespace CovidDetector.Forms
{
    public partial class NewPatientForm : Form
    {
        public NewPatientForm()
        {
            InitializeComponent();
            setColors();
        }
        public void setColors()
        {
            Color menuColor = ColorTranslator.FromHtml("#9ADFFB");
            Color buttonOverColor = ColorTranslator.FromHtml("#12ADD7");
            Color buttonColor = ColorTranslator.FromHtml("#349CC5");
            Color titleColor = Color.FromArgb(100, ColorTranslator.FromHtml("#000000"));

            this.submitButton.BackColor = buttonColor;
            this.submitButton.ForeColor = Color.White;
            this.submitButton.FlatAppearance.MouseOverBackColor = buttonOverColor;
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            NewPatientModel patient = new NewPatientModel();
            setFormData(patient);
        }
        private void setFormData(NewPatientModel patient)
        {
            patient.sex = this.genderSelector.SelectedItem.ToString() == "man" ? true : false;
        }
    }
}
