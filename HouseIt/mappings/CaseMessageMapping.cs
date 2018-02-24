using FluentNHibernate.Mapping;
using HouseIt.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.mappings
{
   public  class CaseMessageMapping : ClassMap<CaseMessage>
    {
        public CaseMessageMapping()
        {
            Id(x => x.MessageNo).Column("message_no");
            Map(x => x.MessageText).Column("message_text");
            References(x => x.Case).Column("case_no").Cascade.None();
            Table("case_messages");
        }
    }
}
