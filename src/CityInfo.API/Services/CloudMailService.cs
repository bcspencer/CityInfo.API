using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public class CloudMailService : IMailService
    {
        private string _mailTo = Startup.Configuration["mailSettings:mailToAddress"];
        private string _mailFrom = Startup.Configuration["mailSettings:mailFromAddress"];

        public void Send(string subject, string message)
        {
            Debug.WriteLine("Sending message from " + _mailFrom + " to " + _mailTo + " WITH CLOUD");
            Debug.WriteLine("Subject: " + subject);
            Debug.WriteLine("Message: " + message);
        }
    }
}
