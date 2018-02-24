using HouseIt.dal;
using HouseIt.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.controllers
{
    class ControllerT
    {

        User loggedInUser = new User();
        BaseRepository<Tenant> baseRepoTenant = new BaseRepository<Tenant>();
        CaseRepository caseRepo = new CaseRepository();

        // Semi-done
        public void ControllerReportCase(string type, bool key, bool pet, string text)
        {
            string keytxt;
            string pettxt;

            if (key == true)
            { keytxt = "Nyckel: ja. "; }
            else
            { keytxt = "Nyckel: nej. "; }

            if (pet == true)
            { pettxt = "Djur: ja. "; }
            else
            { pettxt = "Djur: nej. "; }

            string caseText = keytxt + pettxt + text;

            Case c = new Case();
            c.CaseDate = DateTime.Today.ToString();
            c.CaseType = type;
            c.CaseText = caseText;
            c.Resolved = "Oåtgärdat";

            // Temporary solution
            int idToGetTenant = 1;
            Tenant t = baseRepoTenant.FindEntityById(idToGetTenant);

            c.Tenant = t;
            caseRepo.CreateEntity(c);

        }

        // Semi-done
        public IEnumerable<Case> ControllerLoadMyCases(int tenantId)
        {
            IEnumerable<Case> myCases = caseRepo.FindMyCases(tenantId);
            return myCases;
        }

    }
}