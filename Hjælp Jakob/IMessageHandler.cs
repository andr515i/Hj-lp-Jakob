using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_Jakob
{
	internal interface IMessageHandler
	{
		void SendMessage(Message m);
		void SendMessageToAll(string[] to, Message m);


	}
}
