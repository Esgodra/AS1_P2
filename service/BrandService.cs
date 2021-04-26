using com.impoauto.model;
using System.Collections.Generic;
using com.impoauto.dao;

namespace com.impoauto.service
{
    public class BrandService
    {
        public BrandService()
        {
        }

        /// <summary>
        /// @param brand
        /// @return
        /// </summary>
        public void createBrand(BrandEntity brand)
        {
            // TODO implement here
            BrandDao brandDao = new BrandDao();
            brandDao.createBrand(brand);
        }

        /// <summary>
        /// @param brand
        /// @return
        /// </summary>
        public void updateBrand(BrandEntity brand)
        {
            // TODO implement here
            BrandDao brandDao = new BrandDao();
            brandDao.updateBrand(brand);
        }

        /// <summary>
        /// @param id
        /// @return
        /// </summary>
        public void deleteBrand(int id)
        {
            // TODO implement here
            BrandDao brandDao = new BrandDao();
            brandDao.deleteBrand(id);
        }

        /// <summary>
        /// @return
        /// </summary>
        public List<BrandEntity> getAllBrand()
        {
            // TODO implement here
            BrandDao brandDao = new BrandDao();
            List<BrandEntity> list;
            list = brandDao.readAllBrand();
            return list;
        }

        /// <summary>
        /// @param id
        /// @return
        /// </summary>
        public BrandEntity getByIdBrand(int id)
        {
            // TODO implement here
            BrandDao brandDao = new BrandDao();
            BrandEntity list;
            list = brandDao.readByIdBrand(id);
            return list;
        }
    }
}