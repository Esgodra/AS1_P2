using com.impoauto.dao;
using com.impoauto.model;
using System.Collections.Generic;

namespace com.impoauto.service
{
    public class ModelService
    {
        public ModelService()
        {
        }

        /// <summary>
        /// @param model
        /// @return
        /// </summary>
        public void createModel(ModelEntity model)
        {
            // TODO implement here
            ModelDao modelDao = new ModelDao();
            modelDao.createModel(model);
        }

        /// <summary>
        /// @param model
        /// @return
        /// </summary>
        public void updateModel(ModelEntity model)
        {
            // TODO implement here
            ModelDao modelDao = new ModelDao();
            modelDao.updateModel(model);
        }

        /// <summary>
        /// @param id
        /// @return
        /// </summary>
        public void deleteModel(int id)
        {
            // TODO implement here
            ModelDao modelDao = new ModelDao();
            modelDao.deleteModel(id);
        }

        /// <summary>
        /// @return
        /// </summary>
        public List<ModelEntity> getAllModel()
        {
            // TODO implement here
            ModelDao model = new ModelDao();
            List<ModelEntity> list;
            list = model.readAllModel();
            return list;
        }

        /// <summary>
        /// @param id
        /// @return
        /// </summary>
        public ModelEntity getByIdModel(int id)
        {
            // TODO implement here
            ModelDao modelDao = new ModelDao();
            ModelEntity model;
            model = modelDao.readByIdModel(id);
            return model;
        }
    }
}