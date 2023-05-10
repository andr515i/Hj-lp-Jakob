using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hjælp_Jakob
{
	internal class HTMLMessage : IMessage
	{
		string to, from, body, subject, cc;
		public string To { get => to; set => to = value; }
		public string From { get => from; set => from = value; }
		public string Body { get => body; set => body = value; }
		public string Subject { get => subject; set => subject = value; }
		public string Cc { get => cc; set => cc = value; }
		public HTMLMessage(string to, string from, string body, string subject, string cc)
		{
			this.to = to;
			this.from = from;
			this.body = body;
			this.subject = subject;
			this.cc = cc;
		}
		public void sendMessage(MessageCarrier type, VMessage m, bool isHTML)
		{
			//herinde sendes der en email ud til modtageren
			if (type.Equals(MessageCarrier.Smtp)) // man ville sagtens kunne fjerne denne if statement, men på et eller andet led synes jeg at det stadig giver mening at tjekke for om man har har valgt at sende den rigtige besked. igen, man kunne sagtens slette den, og det burde ikke gøre andet end at gøre det lettere for ens bruger. 
			{
				if (isHTML)
					m.Body = ConvertBodyToHTML(m.Body);
				//her implementeres alt koden til at sende via Smtp
			}
		}

		public string ConvertBodyToHTML(string plainText)
		{
			return "" + plainText + "";
		}

		public void sendMessageToAll(MessageCarrier type, string[] to, VMessage m, bool isHTML)
		{
			if (type.Equals(MessageCarrier.Smtp))// man ville sagtens kunne fjerne denne if statement, men på et eller andet led synes jeg at det stadig giver mening at tjekke for om man har har valgt at sende den rigtige besked. igen, man kunne sagtens slette den, og det burde ikke gøre andet end at gøre det lettere for ens bruger. 
			{
				if (isHTML)
					m.Body = ConvertBodyToHTML(m.Body);
				//her implementeres alt koden til at sende via Smtp
			}
		}
	}

}
