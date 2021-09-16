using System;

namespace BDDKIT.SERVICE
{
	public interface IMessageService
	{
		public string SendMessage(string subject, string message, string recipient);
	}
}
