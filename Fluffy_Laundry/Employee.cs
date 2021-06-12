using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluffy_Laundry
{
    class Employee
    {
        //Definisikan Property
        //Pertama definisikan instance variabel
        private int _empID;
        private string _loginName;
        private string _password;
        private int _securitylevel;

        //Kemudian definisikan property
        public int EmployeeID
        {
            get { return _empID; }

        }
        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public int SecurityLevel
        {
            get { return _securitylevel; }
        }
        // Definisikan Method Kelas
        public Boolean Login(string loginName, string password)
        {
            if (loginName == "Admin1" & password == "wkwk")
            {
                _empID = 1;
                _securitylevel = 2;
                return true;
            }
            else if (loginName == "Admin2" & password == "haha")
            {
                _empID = 2;
                _securitylevel = 4;
                return true;
            }
            else
            {
                return false;
            }
        }
        //Definisikan constructor
        public Employee() { }
        public Employee(string loginName, string password)
        {
            LoginName = loginName;
            Password = password;
        }
    }
}

    

