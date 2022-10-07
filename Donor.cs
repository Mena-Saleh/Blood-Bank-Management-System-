using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public class Donor: Person
    {
        //fields 

        private bool _BloodPressureDisorders;
        private bool _ThyroidDisease;
        private bool _Diabetes;
        private bool _Cancer;
        private bool _HeartDisorders;
        private bool _Hepatitis;
        private string _OtherDisease;
        private DateTime _DateOfLastDonation;

        


        //properties

        public bool BloodPressureDisorders 
        {
            get {return _BloodPressureDisorders;}
            set {_BloodPressureDisorders = value;}
        }
        public bool ThyroidDisease
        {
            get { return _ThyroidDisease; }
            set { _ThyroidDisease = value; }
        }
        public bool Diabetes
        {
            get { return _Diabetes; }
            set { _Diabetes = value; }
        }
        public bool Cancer
        {
            get { return _Cancer; }
            set { _Cancer = value; }
        }
        public bool HeartDisorders
        {
            get { return _HeartDisorders; }
            set { _HeartDisorders = value; }
        }
        public bool Hepatitis
        {
            get { return _Hepatitis; }
            set { _Hepatitis = value; }
        }
        public string OtherDisease
        {
            get { return _OtherDisease; }
            set { _OtherDisease = value; }
        }
        public DateTime DateOfLastDonation
        {
            get { return _DateOfLastDonation; }
            set { _DateOfLastDonation = value; }
        }

   

        //Constructors
        public Donor(int iD, int age, string name, string mail, string password, string bloodType, bool gender,
            bool bloodPressureDisorders, bool thyroidDisease, bool diabetes, bool cancer, bool heartDisorders,
            bool hepatitis, string otherDisease, DateTime dateOfLastDonation) : base(iD, age, name, mail, password, bloodType, gender)
        {
            
            _BloodPressureDisorders = bloodPressureDisorders;
            _ThyroidDisease = thyroidDisease;
            _Diabetes = diabetes;
            _Cancer = cancer;
            _HeartDisorders = heartDisorders;
            _Hepatitis = hepatitis;
            _OtherDisease = otherDisease;
            _DateOfLastDonation = dateOfLastDonation;
        }

        

    }
}
