using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hubitat.Model;

namespace Hubitat.Repositories
{
    public class UserRepository
    {
        private db_HubitatEntities db;
        public UserRepository() { db = new db_HubitatEntities(); }
        public ErrorCode RegisterTenant()
        {

        }

        public ErrorCode RegisterLandlord()
        {

        }

        public ErrorCode RemoveUser() { 
        
        }

        public ErrorCode EditUserInfo() { 
        
        }
        public List<Users> AllUserRole()
        {
            using (db = new db_HubitatEntities())
            {
                return db.vw_AllUsers.ToList();
            }
        }

        public ErrorCode SearchUserNameOrUserID() { 
        
        }

    }
}
