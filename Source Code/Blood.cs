using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System
{
    public class Blood
    {
        //fields
        private int _ID;
        private string _BloodType;
        private DateTime _RecievedDate, _ExpireyDate;
        private float _BloodQuantity; // in milligrams
        private static int _IDCounter = 0; //So that it has a unique identifer so that we can manipulate blood data.
        //To map the blood sample to a recepienct if a recepient requests it sucessfully.
        private int _RecepientIndex; // -1 by default because the sample is not assigened to anyone.
        private string _RecepientHospital; // None by default because the sample is not assigened to anyone.


        //properties
        public int ID
        {
            get { return _ID;  }
            set { _ID = value; }
        }
        public string BloodType
        {
            get { return _BloodType; }
            set { _BloodType = value; }
        
        }

        public DateTime RecievedDate
        {
            get { return _RecievedDate; }
            set { _RecievedDate = value; }

        }

        public DateTime ExpireyDate
        {
            get { return _ExpireyDate; }
            set { _ExpireyDate = value; }

        }

        public float BloodQuantity
        {
            get { return _BloodQuantity; }
            set { _BloodQuantity = value; }

        }
        public static int IDCounter
        {
            get {return _IDCounter;}
            set {_IDCounter = value;}
        }

        public int RecepientIndex
        {
            get { return _RecepientIndex; }
            set { _RecepientIndex = value; }
        }

        public string RecepientHospital
        {
            get { return _RecepientHospital; }
            set { _RecepientHospital = value; }

        }


        //Constructors

        public Blood(int iD, string bloodType, DateTime recievedDate, DateTime expireyDate, float bloodQuantity)
        {
            _RecepientIndex = -1;
            _RecepientHospital = "None";
            _ID = iD;
            _BloodType = bloodType;
            _RecievedDate = recievedDate;
            _ExpireyDate = expireyDate;
            _BloodQuantity = bloodQuantity;
        }

        //Copy Constructor:
        public Blood(Blood B)
        {
            _BloodType = B.BloodType;
            _RecievedDate = B.RecievedDate;
            _ExpireyDate = B.ExpireyDate;
            _BloodQuantity = B.BloodQuantity;
        }

       

        




    }
}
