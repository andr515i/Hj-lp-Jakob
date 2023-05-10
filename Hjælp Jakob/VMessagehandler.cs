using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_Jakob
{
	internal class VMessagehandler : IMessageHandler
	{
		public void SendMessage(Message m)
		{
			//her implementeres alt koden til at sende via Smtp
		}
		public void SendMessageToAll(string[] to, Message m)
		{
			//her implementeres alt koden til at sende via VMessage
		}
	}
}
