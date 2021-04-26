using System;

namespace com.impoauto.model
{
    public class DateEntity
    {
        public DateEntity()
        {
        }

        private int id;

        private string notes;

        private DateTime dateTime;

        private int idImporter;

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
        public string getNotes()
        {
            // TODO implement here
            return "";
        }

        /// <summary>
        /// @param notes
        /// @return
        /// </summary>
        public void setNotes(string notes)
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
        public void setDateTime(DateTime dateTime)
        {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public int getIdImporter()
        {
            // TODO implement here
            return 0;
        }

        /// <summary>
        /// @param idImporter
        /// @return
        /// </summary>
        public void setIdImporter(int idImporter)
        {
            // TODO implement here
        }
    }
}