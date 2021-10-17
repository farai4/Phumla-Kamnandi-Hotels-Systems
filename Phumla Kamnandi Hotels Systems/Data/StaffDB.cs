using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kamnandi_Hotels_Systems.Presentation;
using System.Collections.ObjectModel;
using Phumla_Kamnandi_Hotels_Systems.Business;

namespace Phumla_Kamnandi_Hotels_Systems.Data
{
    public class StaffDB:Database // inheriting from the database class
    {
        #region  Data members  
        private string table1 = "Guest";
        private string sqlLocal1 = "SELECT * FROM Guest";
        private string table2 = "Reservation";
        private string sqlLocal2 = "SELECT * FROM Reservation";
        private string table3 = "Room";
        private string sqlLocal3 = "SELECT * FROM Room";
        private string table4 = "Staff";
        private string sqlLocal4 = "SELECT * FROM Staff";
        private Collection<Room> rooms;
        private Collection<Guest> guests;
        private Collection<Staff> staffCollection;
      

        #endregion

        #region Constuctor
        public StaffDB() : base()
        {
            rooms = new Collection<Room>();
            guests = new Collection<Guest>();
            staffCollection = new Collection<Staff>();
            FillDataSet(sqlLocal1, table1);
            AddToCollection(table1);
            FillDataSet(sqlLocal2, table2);
            AddToCollection(table2);
            FillDataSet(sqlLocal3, table3);
            AddToCollection(table3);
        }

        #endregion

        #region Verify Staff Member
        public void CheckStaff(string username, string passWord)
        {
            connection.Open();
            // verifies the staff user password and ID within the Staff table. Staff member needs to be a Receptionist to access the forms.
            adapter = new SqlDataAdapter("SELECT * FROM Staff WHERE StaffId= '" + username + "' AND Password='" + passWord + "' ", connection);

            // create table and fill it based on the command
            DataTable table = new DataTable(); 
            adapter.Fill(table);

            if (table.Rows.Count == 1) // if number of verified users is 1, then there is a user for the given password and ID
            {
                // open the main form and close the login form if details are correct
                HomeForm home = new HomeForm();
                home.Show();
                LogInForm log = new LogInForm();
                log.Hide();
            }
            else
            {
                MessageBox.Show("Wrong ID or Password"); //returning log-in failed message
            }
            connection.Close();
        }
        #endregion

        #region Utility Methods
        private void AddToCollection(string table)
        {
            DataRow myRow = null;
            Room myRoom;
            Guest aGuest;
            Staff staff;
            switch (table)
            {
                case "Guest":
                    foreach (DataRow myRow_loopVariable in dataset.Tables[table].Rows)
                    {
                        myRow = myRow_loopVariable;
                        if (!(myRow.RowState == DataRowState.Deleted))
                        {
                            aGuest = new Guest();
                            //Obtain each employee attribute from the specific field in the row in the table
                            aGuest.getGuestId = Convert.ToString(myRow["GuestId"]).TrimEnd();
                            //Do the same for all other attributes
                            aGuest.getPhoneNum = Convert.ToString(myRow["PhoneNumber"]).TrimEnd();
                            aGuest.getName = Convert.ToString(myRow["Name"]).TrimEnd();
                            aGuest.getEmail = Convert.ToString(myRow["Email"]).TrimEnd();
                            aGuest.getGuestAdd = Convert.ToString(myRow["Role"]);
                            guests.Add(aGuest);
                        }
                        
                    }
                        break;
                case "Room":
                    foreach (DataRow myRow_loopVariable in dataset.Tables[table].Rows)
                    {
                        myRow = myRow_loopVariable;
                        if (!(myRow.RowState == DataRowState.Deleted))
                        {
                            myRoom = new Room();
                            //Obtain each employee attribute from the specific field in the row in the table
                            myRoom.getRoomNumber = (int)myRow["Room Number"];
                            //Do the same for all other attributes
                            myRoom.getSeason = (Room.Season)(myRow["Room Type"]);
                            myRoom.getPrice = (double)(myRow["Name"]);
                            rooms.Add(myRoom);
                        }

                    }

                    break;
                case "Staff":
                    foreach (DataRow myRow_loopVariable in dataset.Tables[table].Rows)
                    {
                        myRow = myRow_loopVariable;
                        if (!(myRow.RowState == DataRowState.Deleted))
                        {
                            staff = new Staff();
                            //Obtain each employee attribute from the specific field in the row in the table
                            staff.getStaffId = Convert.ToString(myRow["StaffId"]).TrimEnd();
                            //Do the same for all other attributes
                            staff.getName = Convert.ToString(myRow["Name"]).TrimEnd();
                            staff.getPhoneNum = Convert.ToString(myRow["PhoneNumber"]).TrimEnd();
                            staff.getRole = Convert.ToString(myRow["PhoneNumber"]).TrimEnd();
                            staffCollection.Add(staff);
                        }

                    }
                    break;
            }
        }
        #endregion
    }
}
