using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum MessageCode
    {
        Failed = 0,
        Success =1,
        Error = 2
        
    }
    public class Message
    {
        public MessageCode Code { get; set; }
        public string MessageText { get; set; }
    }
}
