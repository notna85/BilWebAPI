using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilWebAPI.Interfaces
{
    interface IEIDAL
    {
        void SaveEventInfo(int eventTypeID, double lon, double lat, string userRegistrationNo);
    }
}
