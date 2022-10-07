using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public class Recepient: Person
    {
        //fields
        private string _Hospital;
        private string _DoctorOfTheCase;
        private List<Blood> _RequestedSamples;

        //properties

        public string Hospital 
        { 
            get { return _Hospital; }
            set { _Hospital = value; }
        }

        public string DoctorOfTheCase
        {
            get { return _DoctorOfTheCase; }
            set { _DoctorOfTheCase = value; }
        }
        public List<Blood> RequestedSamples
        {
            get { return _RequestedSamples; }
            set { _RequestedSamples = value; }
        
        }


        //Constructors

        public Recepient(int iD, int age, string name, string mail, string password, string bloodType, bool gender, string hospital, string doctorOfTheCase) :base (iD, age, name, mail, password, bloodType, gender)
        {
            _Hospital = hospital;
            _DoctorOfTheCase = doctorOfTheCase;
        }

       

    }
}
