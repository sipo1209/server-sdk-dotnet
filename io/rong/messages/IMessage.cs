using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace donet.io.rong.messages
{
    public interface IMessage
    {
        String TYPE { get; set; }

        string toString();
    }
}
