using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroControllerOperation.Communication
{
    interface ICommunication
    {
        void Open(string portName);
        void Close();
        byte[] Send(byte[] buffer, int start, int length);
        byte[] Receive();

    }
}
