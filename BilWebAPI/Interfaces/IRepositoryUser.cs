using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilWebAPI.Interfaces
{
    interface IRepositoryUser<User> : IRepository<User>
    {
        User GetSessionInfo(User user);
        User GetUserBySID(string SID, string username);
        User GetUserByRegNo(string regNo);
    }
}
