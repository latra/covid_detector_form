using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidDetector.Modules
{
    public class NewPatientModule
    {
        public string patient { get; set; }
        public string cardiopathy___yes { get; set; }
        public string cardiopathy___no { get; set; }
        public string cardiopathy___null { get; set; }

        public string hypertension___yes { get; set; }
        public string hypertension___no { get; set; }
        public string hypertension___null { get; set; }

        public string hypertension___yes { get; set; }
        public string hypertension___no { get; set; }
        public string hypertension___null { get; set; }

        public string hypertension___yes { get; set; }
        public string hypertension___no { get; set; }
        public string hypertension___null { get; set; }

        public NewPatientModule(string patient, string cardiopathy___yes, string cardiopathy___no, string cardiopathy___null)
        {
            this.patient = patient;
            this.cardiopathy___yes = cardiopathy___yes;
            this.cardiopathy___no = cardiopathy___no;
            this.cardiopathy___null = cardiopathy___null;


        }
        public bool validate()
        {
            return this.user == "medic1" && this.password == "12345";
        }
    }
}
