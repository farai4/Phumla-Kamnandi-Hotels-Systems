using System;
//namespaces to allow for use of certain properties
using System.Data;
using System.Data.SqlClient; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kamnandi_Hotels_Systems.Properties; // enables to use the Settings properties


namespace Phumla_Kamnandi_Hotels_Systems.Data
{
   public class Database
    {
        #region Data Members
        private string con = Settings.Default.PKHotelDatatBaseConnectionString;
        protected SqlConnection connection;
        protected DataSet dataset;
        protected SqlDataAdapter adapter;
        #endregion

        #region Constructor
        public Database()
        {
            try
            {
                //Open the connection & create a new dataset object
                connection = new SqlConnection(con);
                dataset = new DataSet();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }
        #endregion

        #region Update DateSet
        public void FillDataSet(string aSQLstring, string aTable)
        {
            //fills dataset fresh from the database for a specific table and with a specific Query
            try
            {
                adapter = new SqlDataAdapter(aSQLstring, connection);
                connection.Open(); // opens the connection string and clears dataset
                adapter.Fill(dataset, aTable);
                connection.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }

        #endregion

        #region Update the data source 
        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try
            {
                //open the connection
                connection.Open();
                //update the specific table via the data adapter
                adapter.Update(dataset, table);
                //close the connection
                connection.Close();
                //refresh the dataset
                FillDataSet(sqlLocal, table);
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
            }
            finally
            {
            }
            return success;
        }
        #endregion
    }
}
