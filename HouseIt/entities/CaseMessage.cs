using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.entities
{
    [DataContract]
    public class CaseMessage
    {
        public CaseMessage(int MessageNo, string MessageText, Case Case)
        {
            this.MessageNo = MessageNo;
            this.MessageText = MessageText;
            this.Case = Case;
        }

        public CaseMessage()
        {

        }

        [DataMember]
        public virtual int MessageNo { get; set; }
        [DataMember]
        public virtual string MessageText { get; set; }
     
        public virtual Case Case { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Message No: " + MessageNo + " Message Text: " + MessageText + " Case: " + Case.CaseNo
                );
        }
    }
}
