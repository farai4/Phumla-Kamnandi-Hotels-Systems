using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotels_Systems.Business
{
    public class guestAccount
    {
        #region Fields
        private string accountID; 
        private Status status;
        private string bankName;
        private int bankAccountNumber;
        private Staff staffID;
        #endregion

        #region Property Methods
        public string getAccountID
        {
            get { return accountID; }
            set { value = accountID; }
        }

        public string getBankName
        {
            get { return bankName; }
            set { value = bankName; }
        }
        
        public int getBankAccountNumber
        {
            get { return bankAccountNumber; }
            set { value = bankAccountNumber; }
        }
        #endregion

        #region Constructor
        public guestAccount() // need to get back to code
        {
            /*switch (accStatus)
            {
                case Status.accountStatus.Open;
            }*/
        }
#endregion
    }
}
