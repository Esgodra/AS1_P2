using com.impoauto.model;
using System.Collections.Generic;
using com.impoauto.dao;

namespace com.impoauto.service
{
    public class UserService
    {
        public UserService()
        {
        }

        /// <summary>
        /// @param user
        /// @return
        /// </summary>
        public void createUser(UserEntity user)
        {
            // TODO implement here
            UserDao userDao = new UserDao();
            userDao.createUser(user);
        }

        /// <summary>
        /// @param user
        /// @return
        /// </summary>
        public void updateUser(UserEntity user)
        {
            // TODO implement here
            UserDao userDao = new UserDao();
            userDao.updateUser(user);
        }

        /// <summary>
        /// @param user
        /// @return
        /// </summary>
        public void deleteUser(int id)
        {
            // TODO implement here
            UserDao userDao = new UserDao();
            userDao.deleteUser(id);
        }

        /// <summary>
        /// @return
        /// </summary>
        public List<UserEntity> getAllUsers()
        {
            // TODO implement here
            UserDao userDao = new UserDao();
            List<UserEntity> list;
            list = userDao.readAllUser();
            return list;
        }

        /// <summary>
        /// @param id
        /// @return
        /// </summary>
        public UserEntity getByIdUser(int id)
        {
            // TODO implement here
            UserDao userDao = new UserDao();
            UserEntity list;
            list = userDao.readByIdUser(id);
            return list;
        }
    }
}