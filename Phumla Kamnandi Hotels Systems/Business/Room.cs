using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotels_Systems.Business
{
    public class Room
    {
        private int roomNumber;
        private double price;
        private Season season;

        public enum Season
        {
            Low,
            Medium,
            High
        }
        #region Property methods
        public int getRoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
        public double getPrice
        {
            get { return price; }
            set { price = value; }
        }

        public Season getSeason
        {
            get{ return season; }
            set { season = value; }
        }
        #endregion
        #region Consructor
        public Room()
        {
            getPrice = 0.0;
            getRoomNumber = 0;
            getSeason = Season.High;
        }
        #endregion
    }
}
