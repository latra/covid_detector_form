using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidDetector.Models { 
     public class NewPatientModel
    {
        public int? final_diagnosis_code { get; set; }

        public bool sex { get; set; } // male -> true, woman -> false
        public bool symptoms_binary { get; set; } // has symptoms?
        public bool? fever { get; set; }
        public int? highest_fever { get; set; }
        public int? total_days_fever { get; set; }
        public bool tos { get; set; }
        public bool? cough_first { get; set; }
        public bool crup { get; set; }
        public bool? crup_first { get; set; }
        public bool dysphonia { get; set; }
        public bool? disfonia_first { get; set; }
        public bool resp { get; set; }
        public bool? dyspnea_first { get; set; }
        public bool tachypnea { get; set; }
        public bool? tachypnea_first { get; set; }
        public bool? ausc_resp { get; set; }
        public bool? auscult_first { get; set; }
        public bool? wheezing { get; set; }
        public bool? crackles { get; set; }
        public bool odynophagia { get; set; }
        public bool? odynophagia_first { get; set; }
        public bool nasal_congestion { get; set; }
        public bool? nasal_first { get; set; }
        public bool fatiga { get; set; }
        public bool? fatigue_first { get; set; }
        public bool headache { get; set; }
        public bool? headache_first { get; set; }
        public bool conjuntivitis { get; set; }
        public bool? conj_first { get; set; }
        public bool ocular_pain { get; set; }
        public bool? ocular_first { get; set; }
        public bool? gi_symptoms { get; set; }
        public bool? gi_first { get; set; }
        public bool abdominal_pain { get; set; }
        public bool? vomiting { get; set; }
        public bool dyarrea { get; set; }
        public bool? dermatologic { get; set; }
        public bool? skin_first { get; set; }
        public bool rash { get; set; }
        public bool? inflam_periferic { get; set; }
        public bool? inflam_oral { get; set; }
        public bool adenopathies { get; set; }
        public bool? lymph_first { get; set; }
        public bool hepato { get; set; }
        public bool? hepato_first { get; set; }
        public bool splenomegaly { get; set; }
        public bool? spleno_first { get; set; }
        public bool hemorrhagies { get; set; }
        public bool? hemorr_first { get; set; }
        public bool irritability { get; set; }
        public bool? irritability_first { get; set; }
        public bool? neuro { get; set; }
        public bool? neuro_first { get; set; }
        public bool? confusion { get; set; }
        public bool? seizures { get; set; }
        public bool? nuchal_stiffness { get; set; }
        public bool? hypotonia { get; set; }
        public bool? peripheral_paralysis { get; set; }
        public bool? shock { get; set; }
        public bool? shock_first { get; set; }
        public bool? taste_smell { get; set; }
        public bool? taste_first { get; set; }
        public bool? smell { get; set; }
        public bool? smell_first { get; set; }
        public bool other_symptomatology_mialgies { get; set; }
        public bool other_symptomatology_artritis { get; set; }
        public bool other_symptomatology_artralgies { get; set; }
        public bool other_symptomatology_dolor_toracic { get; set; }
        public bool sero_type_response { get; set; }
        public bool sero_method { get; set; }
        public bool sero_response { get; set; }
        public bool sero_type_response_2 { get; set; }
        public bool? cxr2 { get; set; }
        public bool? sat_hb_o2_value { get; set; }
        public bool? adm_hospital { get; set; }
        public bool? picu_adm { get; set; }
        public bool? days_in_hospital { get; set; }
        public bool final_outcome { get; set; }
        public bool coviral_binary { get; set; }
        public bool? coviral_type { get; set; }
        public bool bacterial_infection { get; set; }
        public bool comorbi_binary { get; set; }
        public bool cardiopathy { get; set; }
        public bool hypertension { get; set; }
        public bool pulmonar_disease { get; set; }
        public bool asma { get; set; }
        public bool nephrology { get; set; }
        public bool hepatic { get; set; }
        public bool neurologic { get; set; }
        public bool diabetes { get; set; }
        public bool? tuberculosi { get; set; }
        public bool idp { get; set; }
        public bool neoplasia { get; set; }
        public bool kawasaki { get; set; }
        public bool inflammation { get; set; }
        public bool? vih_others { get; set; }
        public bool obesity { get; set; }
        public bool flu_binary { get; set; }
        public bool? vaccines_binary { get; set; }
        public bool? final_classification_of_th { get; set; }

                                    
    }


}
