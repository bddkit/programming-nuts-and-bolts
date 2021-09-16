using System;
using System.Collections.Generic;
using System.Text;

namespace BDDKIT.SERVICE
{
    /// <summary>
    /// Provides services to send email.
    /// </summary>
    public class EmailService : IMessageService
	{
        /// <summary>
        /// Sends email message
        /// </summary>
        /// <param name="subject">Subject of the message.</param>
        /// <param name="message">Message text</param>
        /// <param name="recipient">Email address of the message recipient.</param>
        /// <returns></returns>
        public string SendMessage(string subject, string message,
                                    string recipient)
        {
            // This is just dummy implementation of mail sending service
            var confirmation = "Message sent to: " + recipient + ", about "+ subject + ", Message: " + message ;
            Console.WriteLine(confirmation);
            return confirmation;
        }        
	}
}
