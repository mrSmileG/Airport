using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public interface IServiceRemote
    {
        Task SynchronizeRemoteData(int count);
    }
}
