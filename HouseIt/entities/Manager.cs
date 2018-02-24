using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.entities
{
    [DataContract]
    public class Manager
    {
        public Manager(int ManagerId, Building Building)
        {
            this.ManagerId = ManagerId;
            this.Building = Building;
        }

        public Manager()
        {

        }

        [DataMember]
        public virtual int ManagerId { get; set; }
    
        public virtual Building Building { get; set; }
        public virtual Case Case { get; set; }
        public virtual User User { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Manager Id: " + ManagerId 
                );
        }
    }
}
