using BDDKIT.SERVICE;
using System;

namespace BDDKIT.BIZ
{
    /// <summary>
    /// Manages the students to whom we present tests.
    /// </summary>
    public class Student
	{
        public int VendorId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// Sends an email to welcome a new student.
        /// </summary>
        /// <returns></returns>
        public string SendWelcomeEmail(string message)
        {
            var emailService = new EmailService();
            var subject = ("Hello " + this.CompanyName).Trim();
            var confirmation = emailService.SendMessage(subject,
                                                        message,
                                                        this.Email);
            return confirmation;
        }

    }
}
