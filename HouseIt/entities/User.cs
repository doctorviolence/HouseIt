using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.entities
{
    public class User
    {

        public User()
        {

        }

        public virtual string Username { get; set; }
        public virtual string Password { get; set; }

        [Browsable(false)]
        public virtual Tenant Tenant { get; set; }
        [Browsable(false)]
        public virtual Manager Manager { get; set; }

        public override string ToString()
        {
            return string.Format(
                "User Name: " + Username + " Password: You thought I'd actually give you the password, bruh?" 
                );
        }
    }
}
