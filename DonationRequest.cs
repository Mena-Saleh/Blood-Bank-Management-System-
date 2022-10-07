using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System
{
    public class DonationRequest
    {
        
        private float _BloodQuantity;
        private int _DonorIndex; //For the admin to see the donor details.
        
        

        public float BloodQuantity {

            get { return _BloodQuantity; }
            set { _BloodQuantity = value; }
        }
        public int DonorIndex
        {

            get { return _DonorIndex; }
            set { _DonorIndex = value; }
        }

    

        //Parameterized Constructor
        public DonationRequest(float quantity, int donorIndex)
        {
            _BloodQuantity = quantity;
            _DonorIndex = donorIndex;
        }


        //Copy Constructor
        public DonationRequest(DonationRequest D) {

            _BloodQuantity = D.BloodQuantity;
            _DonorIndex = D.DonorIndex;
        
        }

    }
}
