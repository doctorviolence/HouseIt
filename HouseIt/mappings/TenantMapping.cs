using FluentNHibernate.Mapping;
using HouseIt.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.mappings
{
    class TenantMapping : ClassMap<Tenant>
    {
        public TenantMapping()
        {
            Id(x => x.TenantId).Column("tenant_id").GeneratedBy.Native(); ;
            Map(x => x.FirstName).Column("fname");
            Map(x => x.LastName).Column("lname");
            References(x => x.Apartment).Column("apartment_no").Cascade.None();
            //HasOne(x => x.User).Constrained().ForeignKey().Cascade.All();
            HasMany(x => x.Cases).KeyColumn("tenant_id").Inverse().Cascade.All();
            Table("Tenants");
        }
    }
}
