using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidDetector.Models { 
     public class NewPatientModel
    {
        public NewPatientModel()
        {
            this.symptoms_binary = "0";
            this.fever = "2";
            this.tos = "2";
            this.cough_first = "2";
            this.crup = "2";
            this.crup_first = "0";
            this.dysphonia = "2";
            this.disfonia_first = "0";
            this.resp = "2";
            this.dyspnea_first = "0";
            this.tachypnea = "2";
            this.tachypnea_first = "0";
            this.ausc_resp = "2";
            this.auscult_first = "0";
            this.wheezing = "2";
            this.crackles = "2";
            this.odynophagia = "2";
            this.odynophagia_first = "0";
            this.nasal_congestion = "2";
            this.nasal_first = "0";
            this.fatiga = fatiga;
            this.fatigue_first = "0";
            this.headache = "2";
            this.headache_first = "0";
            this.conjuntivitis = "2";
            this.conj_first = "0";
            this.ocular_pain = "2";
            this.ocular_first = "0";
            this.gi_symptoms = "2";
            this.gi_first = "0";
            this.abdominal_pain = "2";
            this.vomiting = "2";
            this.dyarrea = "2";
            this.dermatologic = "2";
            this.skin_first = "0";
            this.rash = "2";
            this.inflam_periferic = "2";
            this.inflam_oral = "2";
            this.adenopathies = "2";
            this.lymph_first = "0";
            this.hepato = hepato;
            this.hepato_first = "0";
            this.splenomegaly = "2";
            this.fatiga = "2";
            this.fatigue_first = "0";
            this.spleno_first = "0";
            this.hemorrhagies = "2";
            this.hemorr_first = "0";
            this.irritability = "2";
            this.irritability_first = "0";
            this.neuro = "2";
            this.neuro_first = "0";
            this.confusion = "2";
            this.seizures = "2";
            this.nuchal_stiffness = "2";
            this.hypotonia = "2";
            this.peripheral_paralysis = "2";
            this.shock = "3";
            this.shock_first = "0";
            this.hepato = "3";
            this.hepato_first = "0";
            this.bacterial_infection = "3";
            this.taste_smell = "2";
            this.taste_first = "0";
            this.smell = smell;
            this.smell_first = "0";
            this.other_symptomatology_mialgies = false;
            this.other_symptomatology_artritis = false;
            this.other_symptomatology_artralgies = false;
            this.other_symptomatology_dolor_toracic = false;
            this.cxr2 = "2";
            this.coviral_binary = "0";
            this.comorbi_binary = "0";
            this.cardiopathy = "2";
            this.hypertension = "2";
            this.pulmonar_disease = "2";
            this.asma = "2";
            this.nephrology = "2";
            this.hepatic = "2";
            this.neurologic = "2";
            this.diabetes = "2";
            this.tuberculosi = "2";
            this.idp = "2";
            this.neoplasia = "2";
            this.kawasaki = "2";
            this.inflammation = "2";
            this.vih_others = "2";
            this.obesity = "2";
            this.flu_binary = "2";
            this.vaccines_binary = "2";
            this.flu_a_result = "2";
            this.flu_b_result = "2";
            this.vrs_result = "3";
            this.adeno_result = "3";
    }
        public string vrs_result { get; set;  }
        public string adeno_result { get; set; }
        public int? final_diagnosis_code { get; set; }

        public string sex { get; set; } // male -> true, woman -> false
        public string symptoms_binary { get; set; } // has symptoms?
        public string fever { get; set; }
        public string highest_fever { get; set; }
        public int? total_days_fever { get; set; }
        public string tos { get; set; }
        public string cough_first { get; set; }
        public string crup { get; set; }
        public string crup_first { get; set; }
        public string dysphonia { get; set; }
        public string disfonia_first { get; set; }
        public string resp { get; set; }
        public string dyspnea_first { get; set; }
        public string tachypnea { get; set; }
        public string tachypnea_first { get; set; }
        public string ausc_resp { get; set; }
        public string auscult_first { get; set; }
        public string wheezing { get; set; }
        public string crackles { get; set; }
        public string odynophagia { get; set; }
        public string odynophagia_first { get; set; }
        public string nasal_congestion { get; set; }
        public string nasal_first { get; set; }
        public string fatiga { get; set; }
        public string fatigue_first { get; set; }
        public string headache { get; set; }
        public string headache_first { get; set; }
        public string conjuntivitis { get; set; }
        public string conj_first { get; set; }
        public string ocular_pain { get; set; }
        public string ocular_first { get; set; }
        public string gi_symptoms { get; set; }
        public string gi_first { get; set; }
        public string abdominal_pain { get; set; }
        public string vomiting { get; set; }
        public string dyarrea { get; set; }
        public string dermatologic { get; set; }
        public string skin_first { get; set; }
        public string rash { get; set; }
        public string inflam_periferic { get; set; }
        public string inflam_oral { get; set; }
        public string adenopathies { get; set; }
        public string lymph_first { get; set; }
        public string hepato { get; set; }
        public string hepato_first { get; set; }
        public string splenomegaly { get; set; }
        public string spleno_first { get; set; }
        public string hemorrhagies { get; set; }
        public string hemorr_first { get; set; }
        public string irritability { get; set; }
        public string irritability_first { get; set; }
        public string neuro { get; set; }
        public string neuro_first { get; set; }
        public string confusion { get; set; }
        public string seizures { get; set; }
        public string nuchal_stiffness { get; set; }
        public string hypotonia { get; set; }
        public string peripheral_paralysis { get; set; }
        public string shock { get; set; }
        public string shock_first { get; set; }
        public string taste_smell { get; set; }
        public string taste_first { get; set; }
        public string smell { get; set; }
        public string smell_first { get; set; }
        public bool other_symptomatology_mialgies { get; set; }
        public bool other_symptomatology_artritis { get; set; }
        public bool other_symptomatology_artralgies { get; set; }
        public bool other_symptomatology_dolor_toracic { get; set; }
        public string sero_type_response { get; set; }
        public string sero_method { get; set; }
        public string sero_response { get; set; }
        public string sero_type_response_2 { get; set; }
        public string cxr2 { get; set; }
        public float sat_hb_o2_value { get; set; }
        public string adm_hospital { get; set; }
        public string picu_adm { get; set; }
        public int? days_in_hospital { get; set; }
        public string final_outcome { get; set; }
        public string coviral_binary { get; set; }
        public string coviral_type { get; set; }
        public string bacterial_infection { get; set; }
        public string comorbi_binary { get; set; }
        public string cardiopathy { get; set; }
        public string hypertension { get; set; }
        public string pulmonar_disease { get; set; }
        public string asma { get; set; }
        public string nephrology { get; set; }
        public string hepatic { get; set; }
        public string neurologic { get; set; }
        public string diabetes { get; set; }
        public string tuberculosi { get; set; }
        public string idp { get; set; }
        public string neoplasia { get; set; }
        public string kawasaki { get; set; }
        public string inflammation { get; set; }
        public string vih_others { get; set; }
        public string obesity { get; set; }
        public string flu_binary { get; set; }
        public string flu_a_result { get; set; }
        public string flu_b_result { get; set; }
        public string vaccines_binary { get; set; }
        public string final_classification_of_th { get; set; }

                                    
    }


}
