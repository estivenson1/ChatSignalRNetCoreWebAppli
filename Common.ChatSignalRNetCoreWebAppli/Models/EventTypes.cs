using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ChatSignalRNetCoreWebAppli.Models
{
    public enum EventTypes
    {
        AddCounter=1,
        EnableUser=2,
    }

    public class Menssage
    {
        EventTypes EventType;
    }
}
