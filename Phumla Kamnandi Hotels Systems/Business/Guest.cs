using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotels_Systems.Business
{
    public class Guest : Person // derived class
    {
        #region Field
        private string guestID;
        private string guestAddress;
        private string guestEmail;
        #endregion

        #region Property Methods
        public string getGuestId
        {
            get { return getGuestId; }
            set { guestID = value; }
        }

        public string getGuestAdd
        {
            get { return guestAddress; }
            set { guestAddress = value; }
        }

        public string getEmail
        {
            get { return guestEmail; }
            set { guestEmail = value; }
        }

        
        #endregion

        #region Constructor
        public Guest() :base()
        {
            guestID = "";
            guestAddress = "";
            guestEmail = "";
        }
        #endregion
    }
}
