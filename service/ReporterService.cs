using com.impoauto.model;
using System.Collections.Generic;
using com.impoauto.dao;

namespace com.impoauto.service
{
    public class ReporterService
    {
        public ReporterService()
        {
        }

        /// <summary>
        /// @param idImporter
        /// @param reporte
        /// </summary>
        public List<ModelEntity> getReporterModel(int idImporter)
        {
            // TODO implement here
            ReporterDao reportDao = new ReporterDao();
            List<ModelEntity> report = new List<ModelEntity>();
            report = reportDao.generateReporterModel(idImporter);
            return report;
        }

        /// <summary>
        /// @param consolidate
        /// </summary>
        public List<ConsolidateEntity> getReporterConsolidate()
        {
            // TODO implement here
            ReporterDao reportDao = new ReporterDao();
            List<ConsolidateEntity> report = new List<ConsolidateEntity>();
            report = reportDao.generateReporterConsolidate();
            return report;
        }
    }
}