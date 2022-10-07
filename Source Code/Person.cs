using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Blood_Bank_Management_System
{
    public class Person
    {
        //fields 
        private int _ID, _Age;
        private string _Name, _Mail, _Password, _BloodType;
        private bool _Gender; // 0 for male and 1 for female.
        public static int IDCounter = 0;

        //Properties (getters and setters)
        public int ID 
        {
            get { return _ID;}
            set { _ID = value; }
        }
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string BloodType
        {
            get { return _BloodType; }
            set { _BloodType = value; }
        }
        public bool Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

        //Constructors

        public Person(int iD, int age, string name, string mail, string password, string bloodType, bool gender)
        {
            _ID = iD;
            _Age = age;
            _Name = name;
            _Mail = mail;
            _Password = password;
            _BloodType = bloodType;
            _Gender = gender;
            _ID = iD;
            _Age = age;
            _Name = name;
            _Mail = mail;
            _Password = password;
            _BloodType = bloodType;
            _Gender = gender;
        }


    }
}
