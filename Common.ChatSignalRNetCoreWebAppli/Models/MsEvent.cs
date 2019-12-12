using Common.ChatSignalRNetCoreWebAppli.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ChatSignalRNetCoreWebAppli.Models
{
    public class MsEvent
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public string EventType { get; set; }
    }
}
