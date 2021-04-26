using System;

namespace com.impoauto.model
{
    public class AutoFairEntity
    {
        public AutoFairEntity()
        {
        }

        private int id;

        private DateTime date;

        private string address;

        /// <summary>
        /// @return
        /// </summary>
        public int getId()
        {
            // TODO implement here
            return 0;
        }

        /// <summary>
        /// @param id
        /// @return
        /// </summary>
        public void setId(int id)
        {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public DateTime getDate()
        {
            // TODO implement here
            return System.DateTime.Today;
        }

        /// <summary>
        /// @param date
        /// @return
        /// </summary>
        public void setDate(DateTime date)
        {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public DateTime getHour()
        {
            // TODO implement here
            return System.DateTime.Today;
        }

        /// <summary>
        /// @return
        /// </summary>
        public string getAddress()
        {
            // TODO implement here
            return "";
        }

        /// <summary>
        /// @param address
        /// @return
        /// </summary>
        public void setAdrress(string address)
        {
            // TODO implement here
        }
    }
}