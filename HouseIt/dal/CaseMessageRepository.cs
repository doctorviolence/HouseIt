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
    public class CaseMessageRepository : BaseRepository<CaseMessage>, ICaseMessageRepository
    {

        /**
         * Retrieves a list of case messages pertaining to case no (landlord)
         */
        public IEnumerable<CaseMessage> ReadAllCaseMessagesByCase(int caseNo)
        {
            try
            {
                var sql = "SELECT cm.* FROM CaseMessages cm, Cases c " +
                    "WHERE c.case_no = cm.case_no " +
                    "AND c.case_no = :caseNo " +
                    "ORDER BY cm.message_no;";

                IList<CaseMessage> CaseMessages = session.CreateSQLQuery(sql)
                    .AddEntity(typeof(CaseMessage))
                    .SetInt32("caseNo", caseNo)
                    .List<CaseMessage>();
                return CaseMessages;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }

        }

        /**
         * Write message to specific case, store in case message table (landlord)
         **/
        public void WriteMessage(string messageText, int caseNo)
        {
            try
            {
                Case cases = new Case(caseNo);
                CaseMessage newCaseMessage = new CaseMessage(0, messageText, cases);
                CreateEntity(newCaseMessage);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }


        /**
         * Retrieve case messages pertaining to case no, tenant id (tenant)
         */
        public IEnumerable<CaseMessage> ReadMyCaseMessages(int tenantId, int caseNo)
        {
            try
            {
                var sql = "SELECT cm.* FROM Case_Messages cm, Cases c, Tenants t " +
                    "WHERE (t.tenant_id = c.tenant_id AND t.tenant_id = :tenantId) " +
                    "AND (c.case_no = cm.case_no AND c.case_no = :caseNo) " +
                    "ORDER BY cm.message_no;";

                IList<CaseMessage> CaseMessages = session.CreateSQLQuery(sql)
                    .AddEntity(typeof(CaseMessage))
                    .SetInt32("tenantId", tenantId)
                    .SetInt32("caseNo", caseNo)
                    .List<CaseMessage>();
                return CaseMessages;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }

        /**
         * Write message to specific case, store in case message table (tenant)
         **/
        public void ReplyToMessage(int tenantId, string messageText, int caseNo)
        {
            try
            {
                IEnumerable<CaseMessage> CaseMessages = ReadMyCaseMessages(tenantId, caseNo);
                if (CaseMessages != null)
                {
                    Case cases = new Case(caseNo);
                    CaseMessage newCaseMessage = new CaseMessage(0, messageText, cases);
                    CreateEntity(newCaseMessage);
                }
                else
                {
                    Console.WriteLine("No messages.");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }

        }
    }


}
