using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidDetector.Models
{
    public class ResponseModel
    {
        public float prob_A { get; set; }
        public float prob_B { get; set; }
        public float prob_C { get; set; }

    }
}
