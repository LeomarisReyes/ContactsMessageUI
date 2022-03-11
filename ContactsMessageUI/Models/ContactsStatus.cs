using System;
namespace ContactsMessageUI.Models
{
    public class ContactsStatus
    {
        public string Picture       { get; set; }
        public string Name          { get; set; }
        public string StatusComment { get; set; }
        public bool   IsOnline      { get; set; }
    }
}
