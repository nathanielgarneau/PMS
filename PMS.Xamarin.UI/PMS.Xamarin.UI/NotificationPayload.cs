using System.Collections.Generic;

namespace PMS.Xam.UI
{
    public class NotificationPayload
    {
        public NotificationPayload()
        {
            Payload = new Dictionary<string, string>();
        }

        public string Action { get; set; }

        public Dictionary<string, string> Payload { get; set; }
    }
}