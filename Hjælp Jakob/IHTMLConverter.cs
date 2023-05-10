using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_Jakob
{
	internal interface IHTMLConverter
	{
		public string convert(string text)  
		{
			//konverter text til HTML
			return "<html><body>" + text + "</body></html>";
		}
	}
}
