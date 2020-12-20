using CovidDetector.Models;
using CovidDetector.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMLModule autoML = new AutoMLModule();
            autoML.autoMLAPI.getPredict(new NewPatientModel());
            Console.Read();
        }
    }
}
