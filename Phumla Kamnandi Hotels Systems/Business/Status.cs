using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotels_Systems.Business
{
   public class Status
    {
        #region Data Members
        public enum accountStatus
        {
            Unconfirmed = 0, // account has just been opened and has not received any money and there are no reservations made
            Confirmed= 1,//an account is active when the guest has made a reservation and the deposit has been made
        }
        protected accountStatus accStatus;
        #endregion

        #region Property Methods
        public accountStatus getStatus
        {
            get { return accStatus; }
            set { value = accStatus; }
        }
        #endregion

        #region Constructor
        public Status() // the constructor initializes the guestAccount to Open
        {
            accStatus = Status.accountStatus.Unconfirmed;
        }
        #endregion
    }
}
