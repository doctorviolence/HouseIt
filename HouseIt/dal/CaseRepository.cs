
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using HouseIt.util;
using HouseIt.entities;
using System.Windows.Forms;

namespace HouseIt.dal
{
    public class CaseRepository : BaseRepository<Case>, ICaseRepository
    {

        /**
         * Add fix date to specific case (landlord)
         **/
        public void AddFixDate(int caseNo, string fixDate)
        {
            try
            {
                Case caseById = FindEntityById(caseNo);
                caseById.FixDate = fixDate;
                UpdateEntity(caseById);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }

        /**
         * Mark case as resolved (landlord)
         **/
        public void MarkCaseAsResolved(int caseNo)
        {
            try
            {
                Case selectedCase = FindEntityById(caseNo);
                selectedCase.Resolved = "Yes";
                UpdateEntity(selectedCase);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }

        public IEnumerable<Case> GetCasesByFixDate()
        {
            try
            {
                var sql = "SELECT c.* FROM Cases c WHERE c.fix_date IS NOT NULL ORDER BY c.fix_date;";

                IList<Case> Cases = session.CreateSQLQuery(sql).AddEntity(typeof(Case)).List<Case>();
                return Cases;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }

        /**
         * Retrieves list of cases by case type and orders them by case date (landlord)
         **/
        public IEnumerable<Case> SortCasesByCategory(string caseType)
        {
            try
            {
                var sql = "SELECT c.* FROM Cases c " +
                    "WHERE c.case_type = :caseType " +
                    "ORDER BY c.case_date;";

                IList<Case> Cases = session.CreateSQLQuery(sql)
                    .AddEntity(typeof(Case))
                    .SetString("caseType", caseType)
                    .List<Case>();
                return Cases;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }

        /**
         * Retrieve cases pertaining to tenant id (tenant)
         */
        public IEnumerable<Case> FindMyCases(int tenantId)
        {
            try
            {
                var sql = "SELECT c.* " +
                    "FROM Cases c, Tenants t WHERE t.tenant_id = c.tenant_id " +
                    "AND t.tenant_id = :id";

                IList<Case> MyCases = session.CreateSQLQuery(sql)
                    .AddEntity(typeof(Case))
                    .SetInt32("id", tenantId)
                    .List<Case>();
                return MyCases;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }


    }
}