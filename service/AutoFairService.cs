using com.impoauto.model;
using com.impoauto.dao;
using System.Collections.Generic;

namespace com.impoauto.service
{
    public class AutoFairService
    {
        public AutoFairService()
        {
        }

        /// <summary>
        /// @param autoFair
        /// @return
        /// </summary>
        public void createAutoFair(AutoFairEntity autoFair)
        {
            // TODO implement here
            AutoFairDao autoFairDao = new AutoFairDao();
            autoFairDao.createAutoFair(autoFair);
        }

        /// <summary>
        /// @param autoFair
        /// @return
        /// </summary>
        public void updateAutoFair(AutoFairEntity autoFair)
        {
            // TODO implement here
            AutoFairDao autoFairDao = new AutoFairDao();
            autoFairDao.updateAutoFair(autoFair);
        }

        /// <summary>
        /// @param id
        /// @return
        /// </summary>
        public void deleteAutoFair(int id)
        {
            // TODO implement here
            AutoFairDao autoFairDao = new AutoFairDao();
            autoFairDao.deleteAutoFair(id);
        }

        /// <summary>
        /// @return
        /// </summary>
        public List<AutoFairEntity> getAllAutoFair()
        {
            // TODO implement here
            AutoFairDao autoFairDao = new AutoFairDao();
            List<AutoFairEntity> list;
            list = autoFairDao.readAllAutoFair();
            return list;
        }

        /// <summary>
        /// @param id
        /// @return
        /// </summary>
        public AutoFairEntity getByIdAutoFair(int id)
        {
            AutoFairDao autoFairDao = new AutoFairDao();
            AutoFairEntity autoFair = new AutoFairEntity();

            autoFair = autoFairDao.readByIdAutoFair(id);

            return autoFair;
        }
    }
}