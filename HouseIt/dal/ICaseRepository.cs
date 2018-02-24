using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseIt.entities;

namespace HouseIt.dal
{
    interface ICaseRepository : IBaseRepository<Case>
    {
        void AddFixDate(int caseNo, string fixDate);
        void MarkCaseAsResolved(int caseNo);
        IEnumerable<Case> GetCasesByFixDate();
        IEnumerable<Case> SortCasesByCategory(string caseType);
        IEnumerable<Case> FindMyCases(int tenantId);
    }
}
