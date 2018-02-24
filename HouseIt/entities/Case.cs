using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.entities
{
    [DataContract]
    public class Case
    {
        /** 
         * Such lazy. Much wow 
        **/
        public Case(int CaseNo, string CaseType, string CaseText, string CaseStatus, string Resolved, string CaseDate, Tenant Tenant, string FixDate = null)
        {
            this.CaseNo = CaseNo;
            this.CaseType = CaseType;
            this.CaseText = CaseText;
            this.CaseStatus = CaseStatus;
            this.Resolved = Resolved;
            this.CaseDate = CaseDate;
            this.Tenant = Tenant;
            this.FixDate = FixDate;
        }

        public Case(int CaseNo)
        {
            this.CaseNo = CaseNo;
        }

        public Case()
        {

        }

        [DataMember]
        public virtual int CaseNo { get; set; }
        [DataMember]
        public virtual string CaseType { get; set; }
        [DataMember]
        public virtual string CaseText { get; set; }
        [DataMember]
        public virtual string CaseStatus { get; set; }
        [DataMember]
        public virtual string Resolved { get; set; }
        [DataMember]
        public virtual string CaseDate { get; set; }
        [DataMember]
        public virtual string FixDate { get; set; }
        
        public virtual Tenant Tenant { get; set; }
        public virtual IList<CaseMessage> CaseMessages { get; set; }


        public override string ToString()
        {
            return string.Format(
            "Case No: " + CaseNo + " Type: " + CaseType + " Text: " + CaseText + " Date: " + CaseDate + " Fix date: " + FixDate
            );
        }
    }
}
