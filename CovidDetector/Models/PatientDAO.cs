using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CovidDetector.Models
{
    public class PatientDAO
    {

        public class Payload
        {
            public Row row { get; set; }
            public Payload()
            {
                this.row = new Row();
            }
            public class Row
            {
                public List<object> values { get; set;}
                public string[] columnSpecIds { get; set;}
    
                public Row()
                {
                    values = new List<object>();
                    columnSpecIds = new string[]{ "3633740794264813568", "8317484406730129408", "5939583803478507520", "6804274931933642752", "2120531319468326912", "2696992071771750400", "8533657188843913216", "3921971170416525312", "5002835080985444352", "1616128161202831360", "4138143952530309120", "8749829970957697024", "5074892675023372288", "463206656595984384", "3201395230037245952", "2985222447923462144", "3777855982340669440", "6011641397516435456", "1472012973126975488", "5579295833288867840", "6542503203592732672", "8461599594805985280", "319091468520128512", "1327897785051119616", "489665304406786048", "9110117941147336704", "2480819289657966592", "174976280444272640", "8966002753071480832", "7957196436540489728", "1039667408899407872", "3345510418113101824", "7813081248464633856", "6227814179630219264", "247033874482200576", "7380735684237066240", "7596908466350850048", "6732217337895714816", "5291065457137156096", "1066126056710209536", "9038060347109408768", "1255840191013191680", "5867526209440579584", "7020447714047426560", "1399955379089047552", "2408761695620038656", "2795508313620480000", "4498431922719948800", "8245426812692201472", "1642586809013633024", "7741023654426705920", "7695424708199579648", "7092505308085354496", "7983655084351291392", "4786662298871660544", "3273452824075173888", "4354316734644092928", "6660159743857786880", "8848346212806426624", "6155756585592291328", "7308678090199138304", "8821887564995624960", "1544070567164903424", "4236660194379038720", "1904358537354543104", "967609814861479936", "3057280041961390080", "3849913576378597376", "751437032747696128", "3129337635999318016", "5435180645213011968", "1930817185165344768", "7407194332047867904", "5101351322834173952", "3705798388302741504", "3948429818227326976", "6254272827441020928", "2048473725430398976", "4714604704833732608", "102918686406344704", "5507238239250939904", "2192588913506254848", "8389542000768057344", "5651353427326795776", "895552220823552000", "391149062558056448", "7236620496161210368", "2624934477733822464", "6443986961744003072", "4426374328682020864", "7885138842502561792", "1832300943316615168", "823494626785624064", "679379438709768192", "8173369218654273536", "7164562902123282432", "6516044555781931008", "3371969065923903488", "7668966060388777984", "2552876883695894528", "5363123051175084032", "4858719892909588480" };
                }
            }
        }
        public Payload payload { get; set; }

        public PatientDAO(NewPatientModel patient) {
            this.payload = new Payload();
            Dictionary<string, string> dict = new Dictionary<string, string>();
            initDictionary(dict);
            foreach (var column in this.payload.row.columnSpecIds)
            {
                
                var propertyInfo = patient.GetType().GetProperty(dict[column]).GetValue(patient, null);
                this.payload.row.values.Add(propertyInfo == null ? null : propertyInfo);
            }
        }
        private void initDictionary(Dictionary<string, string> dict)
        {
            dict.Add("8533657188843913216", "abdominal_pain");
            dict.Add("7695424708199579648", "adeno_result");
            dict.Add("174976280444272640", "adenopathies");
            dict.Add("4426374328682020864", "asma");
            dict.Add("1327897785051119616", "bacterial_infection");
            dict.Add("7308678090199138304", "cardiopathy");
            dict.Add("319091468520128512", "conjuntivitis");
            dict.Add("1930817185165344768", "coviral_binary");
            dict.Add("679379438709768192", "crup");
            dict.Add("6011641397516435456", "diabetes");
            dict.Add("1399955379089047552", "dyarrea");
            dict.Add("1642586809013633024", "dysphonia");
            dict.Add("7813081248464633856", "fatiga");
            dict.Add("8461599594805985280", "flu_a_result");
            dict.Add("6804274931933642752", "flu_b_result");
            dict.Add("5291065457137156096", "flu_binary");
            dict.Add("6443986961744003072", "headache");
            dict.Add("8173369218654273536", "hemorrhagies");
            dict.Add("1904358537354543104", "hepatic");
            dict.Add("4236660194379038720", "hepato");
            dict.Add("3345510418113101824", "hypertension");
            dict.Add("4786662298871660544", "idp");
            dict.Add("1616128161202831360", "inflammation");
            dict.Add("7741023654426705920", "irritability");
            dict.Add("2696992071771750400", "kawasaki");
            dict.Add("8848346212806426624", "nasal_congestion");
            dict.Add("247033874482200576", "neoplasia");
            dict.Add("1832300943316615168", "nephrology");
            dict.Add("2795508313620480000", "neurologic");
            dict.Add("3849913576378597376", "obesity");
            dict.Add("4714604704833732608", "ocular_pain");
            dict.Add("3633740794264813568", "odynophagia");
            dict.Add("7596908466350850048", "other_symptomatology_artralgies");
            dict.Add("967609814861479936", "other_symptomatology_artritis");
            dict.Add("7668966060388777984", "other_symptomatology_dolor_toracic");
            dict.Add("8389542000768057344", "other_symptomatology_mialgies");
            dict.Add("3201395230037245952", "pulmonar_disease");
            dict.Add("2192588913506254848", "resp");
            dict.Add("3273452824075173888", "sero_method");
            dict.Add("9110117941147336704", "sero_response");
            dict.Add("5101351322834173952", "sero_type_response");
            dict.Add("8966002753071480832", "sero_type_response_2");
            dict.Add("2408761695620038656", "sex");
            dict.Add("1472012973126975488", "splenomegaly");
            dict.Add("6732217337895714816", "tachypnea");
            dict.Add("3777855982340669440", "tos");
            dict.Add("102918686406344704", "tuberculosi");
            dict.Add("5363123051175084032", "vaccines_binary");
            dict.Add("895552220823552000", "vih_others");
            dict.Add("5507238239250939904", "vomiting");
            dict.Add("8245426812692201472", "vrs_result");
            dict.Add("2048473725430398976", "adm_hospital");
            dict.Add("5074892675023372288", "ausc_resp");
            dict.Add("7236620496161210368", "auscult_first");
            dict.Add("3371969065923903488", "comorbi_binary");
            dict.Add("1066126056710209536", "confusion");
            dict.Add("7164562902123282432", "conj_first");
            dict.Add("7885138842502561792", "cough_first");
            dict.Add("7020447714047426560", "coviral_type");
            dict.Add("1255840191013191680", "crackles");
            dict.Add("3057280041961390080", "crup_first");
            dict.Add("8317484406730129408", "cxr2");
            dict.Add("8749829970957697024", "days_in_hospital");
            dict.Add("2985222447923462144", "dermatologic");
            dict.Add("5579295833288867840", "disfonia_first");
            dict.Add("4354316734644092928", "dyspnea_first");
            dict.Add("2120531319468326912", "fatigue_first");
            dict.Add("2552876883695894528", "fever");
            dict.Add("489665304406786048", "gi_first");
            dict.Add("7983655084351291392", "gi_symptoms");
            dict.Add("8821887564995624960", "headache_first");
            dict.Add("751437032747696128", "hemorr_first");
            dict.Add("7380735684237066240", "hepato_first");
            dict.Add("1544070567164903424", "highest_fever");
            dict.Add("2624934477733822464", "hypotonia");
            dict.Add("4498431922719948800", "inflam_oral");
            dict.Add("3705798388302741504", "inflam_periferic");
            dict.Add("6542503203592732672", "irritability_first");
            dict.Add("4858719892909588480", "lymph_first");
            dict.Add("7957196436540489728", "nasal_first");
            dict.Add("5651353427326795776", "neuro");
            dict.Add("6660159743857786880", "neuro_first");
            dict.Add("463206656595984384", "nuchal_stiffness");
            dict.Add("7092505308085354496", "ocular_first");
            dict.Add("3948429818227326976", "odynophagia_first");
            dict.Add("5435180645213011968", "peripheral_paralysis");
            dict.Add("9038060347109408768", "picu_adm");
            dict.Add("7407194332047867904", "rash");
            dict.Add("391149062558056448", "sat_hb_o2_value");
            dict.Add("4138143952530309120", "seizures");
            dict.Add("5867526209440579584", "shock");
            dict.Add("5939583803478507520", "shock_first");
            dict.Add("6516044555781931008", "skin_first");
            dict.Add("1039667408899407872", "smell");
            dict.Add("3921971170416525312", "smell_first");
            dict.Add("823494626785624064", "spleno_first");
            dict.Add("2480819289657966592", "symptoms_binary");
            dict.Add("5002835080985444352", "tachypnea_first");
            dict.Add("6155756585592291328", "taste_first");
            dict.Add("6254272827441020928", "taste_smell");
            dict.Add("6227814179630219264", "total_days_fever");
            dict.Add("3129337635999318016","wheezing");
        }
    }
}
