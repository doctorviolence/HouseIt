using FormLandlord;
using HouseIt.dal;
using HouseIt.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseIt.controllers
{
    class ControllerLog
    {
        BaseRepository<User> baseRepUser = new BaseRepository<User>();

        public string ControllerLogin(string user, string pass)
        {
            User u = null;
            u = baseRepUser.FindEntityById(user);
            string pw = u.Password;
            if (u.Password.Equals(pass))
            {
                if (u.Manager != null)
                {
                    Form1 fManager = new Form1();
                    fManager.Show();
                    return "Loggar in...";
                }
                else if (u.Tenant != null)
                {
                    FormTenant.Form1 fTenant = new FormTenant.Form1();
                    fTenant.Show();
                    return "Loggar in...";
                }
                else
                {
                    return "ERROR: Anändaren är ogiltig!";
                }

            }
            else
            {
                return "Användarnamnet eller lösenordet är ogiltigt";
            }
        }
    }
}