using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface Socket_Interface
    {
        bool _IsLogin { get; set; }
        bool _IsConnected { get; set; }
        void Send();
        void LogIn();
        void Register();
        void ReceiveCallBack(IAsyncResult iar);
        void SendCallBack(IAsyncResult iar);
    }
}
