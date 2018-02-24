using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseIt.entities;

namespace HouseIt.dal
{
    interface ICaseMessageRepository : IBaseRepository<CaseMessage>
    {
        IEnumerable<CaseMessage> ReadAllCaseMessagesByCase(int caseNo);
        void WriteMessage(string messageText, int caseNo);
        IEnumerable<CaseMessage> ReadMyCaseMessages(int tenantId, int caseNo);
        void ReplyToMessage(int tenantId, string messageText, int caseNo);
    }
}
