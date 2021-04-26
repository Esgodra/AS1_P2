using com.impoauto.model;
using System.Collections.Generic;
using com.impoauto.dao;

namespace com.impoauto.service
{
    public class RolService
    {
        public RolService()
        {
        }

        /// <summary>
        /// @param rol
        /// @return
        /// </summary>
        public void createRol(RolEntity rol)
        {
            // TODO implement here
            RolDao rolDao = new RolDao();
            rolDao.createRol(rol);
        }

        /// <summary>
        /// @param rol
        /// @return
        /// </summary>
        public void updateRol(RolEntity rol)
        {
            // TODO implement here
            RolDao rolDao = new RolDao();
            rolDao.updateRol(rol);
        }

        /// <summary>
        /// @param id
        /// @return
        /// </summary>
        public void deleteRol(int id)
        {
            // TODO implement here
            RolDao rolDao = new RolDao();
            rolDao.deleteRol(id);
        }

        /// <summary>
        /// @return
        /// </summary>
        public List<RolEntity> getAllRol()
        {
            // TODO implement here
            RolDao rolDao = new RolDao();
            List<RolEntity> list;
            list = rolDao.readAllRol();
            return list;
        }

        /// <summary>
        /// @param id
        /// @return
        /// </summary>
        public RolEntity getByIdRol(int id)
        {
            // TODO implement here
            RolDao rolDao = new RolDao();
            RolEntity rol;
            rol = rolDao.readByIdRol(id);
            return rol;
        }
    }
}