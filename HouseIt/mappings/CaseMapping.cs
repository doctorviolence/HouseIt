using FluentNHibernate.Mapping;
using HouseIt.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.mappings
{
    public class CaseMapping : ClassMap<Case>
    {
        public CaseMapping()
        {
            Id(x => x.CaseNo).Column("case_no");
            Map(x => x.CaseType).Column("case_type");
            Map(x => x.CaseText).Column("case_text");
            Map(x => x.CaseStatus).Column("case_status");
            Map(x => x.Resolved).Column("resolved");
            Map(x => x.CaseDate).Column("case_date");
            Map(x => x.FixDate).Column("fix_date");
            HasMany(x => x.CaseMessages).KeyColumn("case_no").Inverse().Cascade.All();
            References(x => x.Tenant, "tenant_id");
            Table("Cases");
        }
    }
}
