using com.impoauto.dao;
using com.impoauto.model;
using System.Collections.Generic;

namespace com.impoauto.service
{
    public class DateService
    {
        public DateService()
        {
        }

        /// <summary>
        /// @param date
        /// @return
        /// </summary>
        public void createDate(DateEntity date)
        {
            // TODO implement here
            DateDao dateDao = new DateDao();
            dateDao.createDate(date);
        }

        /// <summary>
        /// @param date
        /// @return
        /// </summary>
        public void updateDate(DateEntity date)
        {
            // TODO implement here
            DateDao dateDao = new DateDao();
            dateDao.updateDate(date);
        }

        /// <summary>
        /// @param id
        /// @return
        /// </summary>
        public void deleteDate(int id)
        {
            // TODO implement here
            DateDao dateDao = new DateDao();
            dateDao.deleteDate(id);
        }

        /// <summary>
        /// @return
        /// </summary>
        public List<DateEntity> getAllDate()
        {
            // TODO implement here
            DateDao dateDao = new DateDao();
            List<DateEntity> list;
            list = dateDao.readAllDate();
            return list;
        }

        /// <summary>
        /// @param id
        /// @return
        /// </summary>
        public DateEntity getByIdDate(int id)
        {
            // TODO implement here
            DateDao dateDao = new DateDao();
            DateEntity date = new DateEntity();
            date = dateDao.readByIdDate(id);
            return date;
        }
    }
}