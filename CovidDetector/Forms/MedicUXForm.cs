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
        public MedicUXForm()
        {
            InitializeComponent();
            setColors();
        }
        public void setColors()
        {
            Color menuColor = ColorTranslator.FromHtml("#9ADFFB");
            Color buttonColor = ColorTranslator.FromHtml("#126AA2");
            Color buttonOverColor = ColorTranslator.FromHtml("#349CC5");
            this.menuPanel.BackColor = Color.FromArgb(20, menuColor);
            this.headerPanel.BackColor = Color.FromArgb(20, menuColor);
            this.newPatientButton.BackColor = buttonColor;
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
    }
}
