using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;

namespace Blood_Bank_Management_System
{
    public static class Data
    {
        //fields
        //Arraylists are used rather than linked lists to make it easier to retrieve data from any parts of the list.
        //Queue is used to allow the admin to accept or refuse donation requests in a first in first out fashion.
        private static List<Donor> _Donors = new List<Donor>(); //Array list to store all Donors.
        private static List<Recepient> _Recepients = new List<Recepient>(); //Array list to store all Receivers.
        private static List<Blood> _BloodBank = new List<Blood>(); //Blood bank that stores all donated blood samples.
        private static Queue<DonationRequest> _DonationRequests = new Queue<DonationRequest>(); //Store donation requests in a queue for the admin to approve of in FIFO sequence.
        private static List<AcceptedDonorRequests> _AcceptedDonationRequests = new List<AcceptedDonorRequests>();
        private static int _LoggedInIndex; //To handle log in related events such as updating and deleting the logged in account (-1 means the admin logged in).
        private static string _AdminMail = "Admin@gmail.com";
        private static string _AdminPassword = "Admin";
        private static int _MarkedByAdminIndex; //Allows the admin to modify a user or a blood sample that they select from a list.

        //properties


        public static List<Donor> Donors
        {
            get { return _Donors; }
            set { _Donors = value; }
        }
        public static List<Recepient> Recepients
        {
            get { return _Recepients; }
            set { _Recepients = value; }
        }
        public static List<Blood> BloodBank
        {
            get { return _BloodBank; }
            set { _BloodBank = value; }
        }

        public static Queue<DonationRequest> DonationRequests
        {
            get { return _DonationRequests; }
            set { _DonationRequests = value; }
        }
        public static List<AcceptedDonorRequests> AcceptedDonationRequests
        {
            get { return _AcceptedDonationRequests; }
            set { _AcceptedDonationRequests = value; }
        }



        public static int LoggedInIndex
        {
            get { return _LoggedInIndex; }
            set { _LoggedInIndex = value; }
        }

        public static string AdminMail{
            get { return _AdminMail; }
            set { _AdminMail = value; }

        }
        public static string AdminPassword
        {
            get { return _AdminPassword; }
            set { _AdminPassword = value; }

        }
        public static int MarkedByAdminIndex {
            get { return _MarkedByAdminIndex; }
            set { _MarkedByAdminIndex = value; }

        }


        //Reading and writing to file methods.

        // This will get the current WORKING directory (i.e. \bin\Debug)
        private static string WorkingDirectory = Environment.CurrentDirectory;
        // or: Directory.GetCurrentDirectory() gives the same result

        // This will get the current PROJECT directory
         private static string ProjectDirectory = Directory.GetParent(WorkingDirectory).Parent.Parent.FullName;

        public static void readDataFromFile() //Imports data from text files to the Data class.
        {
            //Donors
            StreamReader DonorsReader = new StreamReader(ProjectDirectory + @"\Data\Donors.txt");
            string DonorLine = DonorsReader.ReadLine();
            Donor TempDonor;
            while (DonorLine != null)
            {
                
                string[] SplitData = DonorLine.Split('-');
                TempDonor = new Donor(int.Parse(SplitData[0]), int.Parse(SplitData[1]) ,SplitData[2], SplitData[3], SplitData[4], SplitData[5], bool.Parse(SplitData[6]), bool.Parse(SplitData[7]) , bool.Parse(SplitData[8]) , bool.Parse(SplitData[9]), bool.Parse(SplitData[10]), bool.Parse(SplitData[11]) , bool.Parse(SplitData[12]), SplitData[13], DateTime.Parse(SplitData[14]));
                _Donors.Add(TempDonor);
                DonorLine = DonorsReader.ReadLine();
            }
            DonorsReader.Close();


            //Recepients
            StreamReader RecepientsReader = new StreamReader(ProjectDirectory + @"\Data\Recepients.txt");
            string RecepientLine = RecepientsReader.ReadLine(); 
            Recepient TempRecepient;
            while (RecepientLine != null)
            {

                string[] SplitData = RecepientLine.Split('-');
                TempRecepient = new Recepient(int.Parse(SplitData[0]), int.Parse(SplitData[1]), SplitData[2], SplitData[3], SplitData[4], SplitData[5], bool.Parse(SplitData[6]), SplitData[7], SplitData[8]);
                _Recepients.Add(TempRecepient);
                RecepientLine = RecepientsReader.ReadLine();
            }
            RecepientsReader.Close();

            //BloodBank
            StreamReader BloodBankReader = new StreamReader(ProjectDirectory + @"\Data\BloodBank.txt");
            string BloodBankLine = BloodBankReader.ReadLine();
            Blood TempBloodSample;
            while (BloodBankLine!= null)
            {
                string[] SplitData = BloodBankLine.Split('^'); //because - wouldn't work if there is -1 in donor index.
                TempBloodSample = new Blood(int.Parse(SplitData[0]), SplitData[1], DateTime.Parse(SplitData[2]), DateTime.Parse(SplitData[3]), float.Parse(SplitData[4]));
                TempBloodSample.RecepientIndex = int.Parse(SplitData[5]);
                TempBloodSample.RecepientHospital = SplitData[6];
                _BloodBank.Add(TempBloodSample);
                BloodBankLine = BloodBankReader.ReadLine();
            }
            BloodBankReader.Close();

            //Donation Requests

            StreamReader DonationRequestsReader = new StreamReader(ProjectDirectory + @"\Data\DonationRequests.txt");
            string DonationRequestsLine = DonationRequestsReader.ReadLine();
            DonationRequest TempRequest;
            while (DonationRequestsLine != null)
            {
                string[] SplitData = DonationRequestsLine.Split('-');
                TempRequest = new DonationRequest(float.Parse(SplitData[0]), int.Parse(SplitData[1]));
                _DonationRequests.Enqueue(TempRequest);
               DonationRequestsLine = DonationRequestsReader.ReadLine();
            }
            DonationRequestsReader.Close();

            //Accepted Donor Requests

            StreamReader AcceptedDonorRequestsReader = new StreamReader(ProjectDirectory + @"\Data\AcceptedDonorRequests.txt");
            string AcceptedDonorRequestsLine = AcceptedDonorRequestsReader.ReadLine();
            AcceptedDonorRequests TempAcceptedRequest;
            while (AcceptedDonorRequestsLine != null)
            {
               
                string[] SplitData = AcceptedDonorRequestsLine.Split('-');
                TempAcceptedRequest = new AcceptedDonorRequests(DateTime.Parse(SplitData[0]), float.Parse(SplitData[1]), int.Parse(SplitData[2]));
                _AcceptedDonationRequests.Add(TempAcceptedRequest);
                AcceptedDonorRequestsLine = AcceptedDonorRequestsReader.ReadLine();
                
            }
            AcceptedDonorRequestsReader.Close();

            //IDCounter
            StreamReader IDCountersReader = new StreamReader(ProjectDirectory + @"\Data\IDCounters.txt");
            string IDCountersLine = IDCountersReader.ReadLine();
            Person.IDCounter = int.Parse(IDCountersLine);
            IDCountersLine = IDCountersReader.ReadLine();
            Blood.IDCounter = int.Parse(IDCountersLine);
            IDCountersReader.Close();

            //Admin Credentials
            StreamReader AdminReader = new StreamReader(ProjectDirectory + @"\Data\AdminCredentials.txt");
            string AdminLine = AdminReader.ReadLine();
            _AdminMail = AdminLine;
            AdminLine = AdminReader.ReadLine();
            _AdminPassword = AdminLine;
            AdminReader.Close();
              
        }
        public static void writeDataToFile()  //Exports data from the Data class to the text files.
        {
            //Donors
            StreamWriter DonorsWriter = new StreamWriter(ProjectDirectory + @"\Data\Donors.txt");
            DonorsWriter.Flush();
            for (int i = 0; i < _Donors.Count(); i++)
            {
                DonorsWriter.WriteLine(_Donors[i].ID.ToString() + '-' + _Donors[i].Age.ToString() + '-' + _Donors[i].Name + '-' + _Donors[i].Mail + '-' + _Donors[i].Password + '-' + _Donors[i].BloodType + '-' + _Donors[i].Gender + '-' + _Donors[i].BloodPressureDisorders + '-' + _Donors[i].ThyroidDisease + '-' + _Donors[i].Diabetes + '-' + _Donors[i].Cancer + '-' + _Donors[i].HeartDisorders + '-' +_Donors[i].Hepatitis + '-' + _Donors[i].OtherDisease + '-' + _Donors[i].DateOfLastDonation);
            }
            DonorsWriter.Close();

            //Recepients
            StreamWriter RecepientsWriter = new StreamWriter(ProjectDirectory + @"\Data\Recepients.txt");
            RecepientsWriter.Flush();
            for (int i = 0; i < _Recepients.Count(); i++)
            {
                RecepientsWriter.WriteLine(_Recepients[i].ID.ToString() + '-' + _Recepients[i].Age.ToString() + '-' + _Recepients[i].Name + '-' + _Recepients[i].Mail + '-' + _Recepients[i].Password + '-' + _Recepients[i].BloodType + '-' + _Recepients[i].Gender + '-'  + _Recepients[i].Hospital + '-' + _Recepients[i].DoctorOfTheCase);
            }
            RecepientsWriter.Close();

            //BloodBank
            StreamWriter BloodBankWriter = new StreamWriter(ProjectDirectory + @"\Data\BloodBank.txt");
            BloodBankWriter.Flush();
            for (int i = 0; i < _BloodBank.Count(); i++)
            {
                BloodBankWriter.WriteLine(_BloodBank[i].ID.ToString() + '^' +_BloodBank[i].BloodType + '^' + _BloodBank[i].RecievedDate + '^' + _BloodBank[i].ExpireyDate + '^' + _BloodBank[i].BloodQuantity.ToString() + '^' + _BloodBank[i].RecepientIndex.ToString() + '^' + _BloodBank[i].RecepientHospital);
            }
            BloodBankWriter.Close();

            //Donation Requests 
            StreamWriter DonationRequestsWriter = new StreamWriter(ProjectDirectory + @"\Data\DonationRequests.txt");
            DonationRequestsWriter.Flush();
            DonationRequest TempRequest;
            while (_DonationRequests.Count != 0)
            {
                TempRequest = new DonationRequest(_DonationRequests.Dequeue()); //return the front request of the queue and pop it
                DonationRequestsWriter.WriteLine(TempRequest.BloodQuantity.ToString() + '-' + TempRequest.DonorIndex.ToString());
            }
            DonationRequestsWriter.Close();

            //Accepted Donor Requests
            StreamWriter AcceptedDonorRequestsWriter = new StreamWriter(ProjectDirectory + @"\Data\AcceptedDonorRequests.txt");
            AcceptedDonorRequestsWriter.Flush();
            for (int i = 0; i < _AcceptedDonationRequests.Count(); i++)
            {
                AcceptedDonorRequestsWriter.WriteLine(_AcceptedDonationRequests[i].DateOfAcceptance.ToString() + '-' + _AcceptedDonationRequests[i].BloodQuantity.ToString() + '-' + _AcceptedDonationRequests[i].DonorIndex.ToString());
            }
            AcceptedDonorRequestsWriter.Close();

            //IDCounters
            StreamWriter IDCountersWriter = new StreamWriter(ProjectDirectory + @"\Data\IDCounters.txt");
            IDCountersWriter.Flush();
            IDCountersWriter.WriteLine(Person.IDCounter.ToString());
            IDCountersWriter.WriteLine(Blood.IDCounter.ToString());
            IDCountersWriter.Close();

            //Admin Credentials

            StreamWriter AdminWriter = new StreamWriter(ProjectDirectory + @"\Data\AdminCredentials.txt");
            AdminWriter.Flush();
            AdminWriter.WriteLine(_AdminMail);
            AdminWriter.WriteLine(_AdminPassword);
            AdminWriter.Close();



        }

        public static void deleteDonorRequests() //Deletes a specific Donor's requests, this function is called when a donor deletes their account or when an admin deletes it.
        {
            int ToFilterIndex = Data.LoggedInIndex == -1 ? Data.MarkedByAdminIndex : Data.LoggedInIndex;
            //Delete it from DonationRequests queue
            Queue<DonationRequest> Temp = new Queue<DonationRequest>();
            while (_DonationRequests.Count != 0)
            {
                if (_DonationRequests.Peek().DonorIndex == ToFilterIndex) //the front of the queue is the logged in user to delete.
                {
                    _DonationRequests.Dequeue();
                }
                else
                {
                    Temp.Enqueue(_DonationRequests.Dequeue());
                }
            }
            _DonationRequests = Temp;


            //Delete them from AcceptedDonationRequests list.
            for (int i = 0; i < _AcceptedDonationRequests.Count; i++)
            {
                if (_AcceptedDonationRequests[i].DonorIndex == ToFilterIndex)
                {
                    _AcceptedDonationRequests.RemoveAt(i);
                }
            }

        
        }


        public static bool validateEmail (string ToValidate)
        {
            try
            {
                MailAddress Temp = new MailAddress(ToValidate); //This only works if ToValidate is a correct Email address.
                return true;
            }
            catch (FormatException)
            {
                //If ToValidate is not a valid email address, false is returned.
                return false;
            }
        }





    }
}
