using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CovidDetector.Models;
using CovidDetector.Modules;

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
            patient.sex = this.genderSelector.SelectedItem.ToString() == "man" ? "1" : "2";
            patient.vaccines_binary = this.vaccinesField.Checked ? "1" : "0";
            getSympto(patient);
            getInitialSympto(patient);
            getPathologies(patient);
            getSeroInfo(patient);
            patient.sat_hb_o2_value = float.Parse(this.bloodfield.Text);
            patient.adm_hospital = this.admisionField.Checked ? "1" : "0";
            patient.picu_adm = this.uciField.Checked ? "1" : "0";
            patient.fever = this.feverField.Checked ? "1" : "2";
            if (this.feverField.Checked)
            {
                patient.total_days_fever = int.Parse(this.feverdayField.Text);
                float fevertemp = float.Parse(this.maxfeverField.Text);
                if (fevertemp >= 37.5 && fevertemp < 38)
                    patient.highest_fever = "1";
                else if (fevertemp >= 38 && fevertemp <= 39)
                    patient.highest_fever = "2";
                else if (fevertemp > 39)
                    patient.highest_fever = "3";
            }
            AutoMLModule autoML = new AutoMLModule();
            // GIF CARGA
            int sugested_result = autoML.autoMLAPI.getPredict(new PatientDAO(patient));
            //END GIF CARGA
            showResult(sugested_result);
        }

        private void showResult(int sugested_result)
        {
            string message;
            switch (sugested_result)
            {
                case 1:
                    message = "Por los datos que me has dado, apunta a un posible caso de Covid.";
                    break;
                case 2:
                    message = "Uy, no estoy muy seguro... Mejor hagamos más pruebas antes de tener un diagnóstico.";
                    break;
                case 3:
                    message = "No parece que se trate de un caso de covid... ¿Puedo estar equivocado?";
                    break;
                default:
                    message = "";
                    break;
            }
            MessageBox.Show(message, "Medbot Diagnosis",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void getSeroInfo(NewPatientModel patient)
        {
            if (this.serotypeSelector.SelectedItem == null)
            {
                patient.sero_method = "5";
                patient.sero_response = "3";
                patient.sero_type_response = "5";
                patient.sero_type_response_2 = "5";
            }
            else {
                patient.sero_method = this.seromethodSelector.SelectedIndex.ToString();
                patient.sero_response =  this.sero_positive_field.Checked ? "1" : "2";
                patient.sero_type_response = this.serotypeSelector.SelectedIndex.ToString();
                patient.sero_type_response_2 = this.seromethodSelector2.SelectedIndex.ToString();
            }
        }
        private void getSympto(NewPatientModel patient)
        {
            foreach (var sympton in this.sympthomsSelector.CheckedItems)
            {
                PropertyInfo propertyInfo = patient.GetType().GetProperty(sympton.ToString());
                if (sympton.ToString().Contains("other_symptomatology")) 
                    propertyInfo.SetValue(patient, Convert.ChangeType(true, propertyInfo.PropertyType), null);
                 else
                    propertyInfo.SetValue(patient, Convert.ChangeType("1", propertyInfo.PropertyType), null);
            }
        }
        private void getInitialSympto(NewPatientModel patient)
        {
            foreach (var sympton in this.firstSelector.CheckedItems)
            {
                PropertyInfo propertyInfo = patient.GetType().GetProperty(sympton.ToString());
                propertyInfo.SetValue(patient, Convert.ChangeType("1", propertyInfo.PropertyType), null);
            }
        }
        private void getPathologies(NewPatientModel patient)
        {
            foreach (var sympton in this.pathologiesSelector.CheckedItems)
            {
                PropertyInfo propertyInfo = patient.GetType().GetProperty(sympton.ToString());
                propertyInfo.SetValue(patient, Convert.ChangeType("1", propertyInfo.PropertyType), null);
            }
        }

    }
}
