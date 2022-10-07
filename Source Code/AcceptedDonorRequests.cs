using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System
{
    public class AcceptedDonorRequests
    {
        private DateTime _DateOfAcceptance; //Date in which the admin accepted
        private float _BloodQuantity;
        private int _DonorIndex;
        public DateTime DateOfAcceptance {
            get { return _DateOfAcceptance; }
            set { _DateOfAcceptance = value; }
        }

        public float BloodQuantity {

            get { return _BloodQuantity; }
            set { _BloodQuantity = value; }

        }
        public int DonorIndex
        {

            get { return _DonorIndex; }
            set { _DonorIndex = value; }
        }

        public AcceptedDonorRequests(DateTime dateOfAcceptance, float bloodQuantity, int donorIndex)
        {
            _DateOfAcceptance = dateOfAcceptance;
            _BloodQuantity = bloodQuantity;
            _DonorIndex = donorIndex;
        }
    }
}
