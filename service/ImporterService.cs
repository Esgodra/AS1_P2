using com.impoauto.dao;
using com.impoauto.model;
using System.Collections.Generic;
using com.impoauto.util;

namespace com.impoauto.service
{
    public class ImporterService
    {
        public ImporterService()
        {
        }

        /// <summary>
        /// @param importer
        /// @return
        /// </summary>
        public void createImporter(ImporterEntity importer)
        {
            // TODO implement here
            ImporterDao importerDao = new ImporterDao();
            importerDao.createImporter(importer);
        }

        /// <summary>
        /// @param importer
        /// @return
        /// </summary>
        public void updateImporter(ImporterEntity importer)
        {
            // TODO implement here
            ImporterDao importerDao = new ImporterDao();
            importerDao.updateImporter(importer);
        }

        /// <summary>
        /// @param id
        /// @return
        /// </summary>
        public void deleteImporter(int id)
        {
            // TODO implement here
            ImporterDao importerDao = new ImporterDao();
            importerDao.deleteImporter(id);
        }

        /// <summary>
        /// @return
        /// </summary>
        public List<ImporterEntity> getAllImporter()
        {
            ImporterDao importerDao = new ImporterDao();
            List<ImporterEntity> list;
            list = importerDao.readAllImporter();
            return list;
        }

        /// <summary>
        /// @param id
        /// @return
        /// </summary>
        public ImporterEntity getByIdImporter(int id)
        {
            // TODO implement here
            ImporterDao importerDao = new ImporterDao();
            ImporterEntity importer;
            importer = importerDao.readByIdImporter(id);
            return importer;
        }

        /// <summary>
        /// @return
        /// </summary>
        public string getImporterCode(int id)
        {
            // TODO implement here
            Functions functions = new Functions();
            functions.generateCodeImporter(id);
            return "";
        }

        /// <summary>
        /// @param importer
        /// @return
        /// </summary>
        public bool postImporter(string importer)
        {
            // TODO implement here

            return false;
        }
    }
}