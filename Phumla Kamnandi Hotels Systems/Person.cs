using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotels_Systems
{
    public abstract class Person
    {
        // create an abstract base class Person with an Name, lastName and phoneNumber
        #region Field
        private string name;
        private string phoneNumber;
        private string ID;
        #endregion

        #region Property Methods
        // developing property methods associated with the fields
        public string getName
        {
            get { return name; }
            set { name = value; }
        }

        public string getPhoneNum
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string getID
        {
            get { return ID; }
            set { ID = value; }
        }
        #endregion

        #region Constructor
        public Person() // default constructor
        {
            ID = "";
            name = "";
            phoneNumber = "";
        }
        public Person(string id, string Name, string phone) // parameterised constructor
        {
            ID = id;
            name = Name;
            phoneNumber = phone;
        }
        #endregion

    }
}
