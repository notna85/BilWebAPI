using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilWebAPI.Models;


namespace BilWebAPI.Interfaces
{
    public interface IRepositoryEventInfo<EventInfoConfirm> : IRepository<EventInfoConfirm>
    {
        List<EventInfoConfirm> GetAllEventInfo(User user);
        EventInfoConfirm GetEventInfoByID(int eventInfoID, User user);
    }
}
