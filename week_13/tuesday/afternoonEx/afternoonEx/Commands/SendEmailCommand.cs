using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace afternoonEx.Commands
{
    class SendEmailCommand : Command
    {
        string EAdress;

        public SendEmailCommand(string adress, string content) : base(content)
        {
            EAdress = adress;
            if (EAdress == "")
            {
                throw new ArgumentException("no adress fuond");
            }
        }
        public override bool execute()
        {
            if (! EAdress.StartsWith("_") ||  EAdress.Contains("@"))
            {
                Console.WriteLine($"Email sent to {EAdress}");
                return true;
            }
            Console.WriteLine($"failed to send Email to {EAdress}");
            return false;

        }
    }
}
