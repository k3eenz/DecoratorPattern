using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class EmailNotify : INotifier
    {
        public string email;
        public EmailNotify(string Email)
        {
            email = Email;
        }
        public void Send(string message)
        {
            Console.WriteLine($"Message: {message}\nTo email: {email}\n\n");
        }
    }
}
