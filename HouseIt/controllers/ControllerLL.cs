
using HouseIt.dal;
using HouseIt.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.controllers
{
    class ControllerLL
    {
        CaseRepository caseRepo = new CaseRepository();
        BaseRepository<Case> baseRepoCase = new BaseRepository<Case>();
        BaseRepository<User> baseRepoUser = new BaseRepository<User>();
        BaseRepository<Building> baseRepoBuilding = new BaseRepository<Building>();
        ApartmentRepository baseRepoApartment = new ApartmentRepository();
        BaseRepository<Tenant> baseRepoTenant = new BaseRepository<Tenant>();
        BaseRepository<Manager> baseRepoManager = new BaseRepository<Manager>();

        //ToDo
        public BaseRepository<Case> BaseRepoCase { get => baseRepoCase; set => baseRepoCase = value; }

        public List<Case> ControllerRefresh()
        {
            Case temp = new Case();
            List<Case> cases = (List<Case>)baseRepoCase.GetEntities(temp);
            return cases;
        }

        public IEnumerable<Case> ControllerRefreshType(string type)
        {
            IEnumerable<Case> cases = caseRepo.SortCasesByCategory(type);
            return cases;
        }

        public void ControllerMarkCaseAsResolved(int id)
        {
            caseRepo.MarkCaseAsResolved(id);
        }

        public void ControllerDelete(int id)
        {
            Case c = baseRepoCase.FindEntityById(id);
            baseRepoCase.DeleteEntity(c);
        }

        public void ControllerSetFixDate(int caseNo, string date)
        {
            caseRepo.AddFixDate(caseNo, date);
        }

        public string ControllerCreateAccount(string user, string pass, string name, string last, int aptNo, int house, bool admin)
        {
            Apartment apartment = new Apartment();
            apartment.ApartmentNo = aptNo;

            if (admin == true)
            {
                Manager m = ControllerCreateManager(house);
                ControllerCreateUser(user, pass, m, null);
                return "Administratör skapad!";
            }
            else
            {
                if (!user.Equals("") && !pass.Equals("") && !house.Equals("") && !aptNo.Equals("") && !name.Equals("") && !last.Equals(""))
                {
                    Tenant t = ControllerCreateTenant(name, last, apartment);
                    ControllerCreateUser(user, pass, null, t);
                    return "Hyresgäst skapad!";
                }
                else
                {
                    return "Vänligen kontrollera att användarnamn, lösenord, namn, efternamn och lägenhet har valts korrekt!";
                }
            }
        }

        public void ControllerCreateUser(string user, string password, Manager man, Tenant ten)
        {
            User u = new User();
            u.Username = user;
            u.Password = password;

            baseRepoUser.CreateEntity(u);
        }

        public Manager ControllerCreateManager(int buildingID)
        {
            Manager m = new Manager();
            Building b = baseRepoBuilding.FindEntityById(buildingID);
            m.Building = b;
            baseRepoManager.CreateEntity(m);
            return m;
        }

        public Tenant ControllerCreateTenant(string name, string last, Apartment apt)
        {
            Tenant t = new Tenant();
            t.TenantId = 0;
            t.FirstName = name;
            t.LastName = last;
            t.Apartment = apt;
            baseRepoTenant.CreateEntity(t);
            return t;
        }

        public void ControllerEditUser(string user, string password)
        {
            User u = baseRepoUser.FindEntityById(user);
            u.Username = user;
            u.Password = password;

            baseRepoUser.UpdateEntity(u);
        }

        public void ControllerEditManager(string username, string buildingID)
        {
            User u = baseRepoUser.FindEntityById(username);
            Manager m = u.Manager;
            m.Building = baseRepoBuilding.FindEntityById(buildingID);

            baseRepoManager.UpdateEntity(m);
        }

        public void ControllerEditTenant(string username, string name, string last, string apt)
        {
            User u = baseRepoUser.FindEntityById(username);
            Tenant t = u.Tenant;
            t.FirstName = name;
            t.LastName = last;
            t.Apartment = baseRepoApartment.FindEntityById(apt);

            baseRepoTenant.UpdateEntity(t);
        }

        public void ControllerDeleteUser(string id)
        {
            User u = baseRepoUser.FindEntityById(id);
            baseRepoUser.DeleteEntity(u);
        }

        public void ControllerDeleteTenant(string user)
        {
            User u = baseRepoUser.FindEntityById(user);
            Tenant t = u.Tenant;
            baseRepoTenant.DeleteEntity(t);
        }

        public void ControllerDeleteManager(string user)
        {
            User u = baseRepoUser.FindEntityById(user);
            Manager m = u.Manager;
            baseRepoManager.DeleteEntity(m);
        }

        public List<User> ControllerLoadUsers()
        {
            User u = new User();
            List<User> users = (List<User>)baseRepoUser.GetEntities(u);
            return users;
        }

        public IEnumerable<Tenant> ControllerLoadTenants()
        {
            Tenant t = new Tenant();
            IEnumerable<Tenant> tenants = baseRepoTenant.GetEntities(t);
            return tenants;
        }

        public IEnumerable<Building> ControllerLoadHouses()
        {
            Building b = new Building();
            IEnumerable<Building> buildings = baseRepoBuilding.GetEntities(b);
            return buildings;
        }

        public IEnumerable<Apartment> ControllerLoadApartments(int BuildingId)
        {
            IEnumerable<Apartment> apartments = baseRepoApartment.GetApartmentsBelongingToBuilding(BuildingId);
            return apartments;
        }

    }
}