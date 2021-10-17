using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotels_Systems.Business
{
    public class Staff : Person
    {
        #region Fields
        private string staffID;
        public string role;
        #endregion

        #region Property Methods
        public string getStaffId
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string getRole
        {
            get { return role; }
            set { role = value; }
        }
        #endregion

        #region Constructor
        public Staff()
        {
              
        }
        #endregion
    }
}
