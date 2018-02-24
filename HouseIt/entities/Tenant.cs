using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.entities
{
    [DataContract]
    public class Tenant
    {
        public Tenant(int TenantId, string FirstName, string LastName, Apartment Apartment)
        {
            this.TenantId = TenantId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Apartment = Apartment;
        }

        public Tenant(int TenantId)
        {
            this.TenantId = TenantId;
        }

        public Tenant()
        {

        }

        [DataMember]
        public virtual int TenantId { get; set; }
        [DataMember]
        public virtual string FirstName { get; set; }
        [DataMember]
        public virtual string LastName { get; set; }
        
        public virtual Apartment Apartment { get; set; }
        public virtual IList<Case> Cases { get; set; }
        public virtual User User { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Tenant Id: " + TenantId + " " + LastName + ", " + FirstName 
                );
        }
    }
}
