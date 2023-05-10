using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_Jakob
{
	internal interface IMessage
	{
		void sendMessage(MessageCarrier type, VMessage m, bool isHTML);

		string ConvertBodyToHTML(string plainText);

		void sendMessageToAll(MessageCarrier type, string[] to, VMessage m, bool isHTML);


	}
}
