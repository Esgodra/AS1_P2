namespace com.impoauto.model
{
    public class ModelEntity
    {
        public ModelEntity()
        {
        }

        private int id;

        private string modelName;

        private int year;

        private float price;

        private BrandEntity brand;

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
        public string getModelName()
        {
            // TODO implement here
            return "";
        }

        /// <summary>
        /// @param ModelName
        /// @return
        /// </summary>
        public void setModelName(string ModelName)
        {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public int getYear()
        {
            // TODO implement here
            return 0;
        }

        /// <summary>
        /// @param Year
        /// @return
        /// </summary>
        public void setYear(int Year)
        {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public float getPrice()
        {
            // TODO implement here
            return 0.0F;
        }

        /// <summary>
        /// @param Price
        /// @return
        /// </summary>
        public void setPrice(float Price)
        {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public BrandEntity getIdBrand()
        {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @param IdBrand
        /// @return
        /// </summary>
        public void setIdBrand(BrandEntity IdBrand)
        {
            // TODO implement here
        }
    }
}