using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SMSDecorator : NotifyDecorator
    {
        public string _phoneNumber;
        public SMSDecorator(INotifier Notify, string PhoneNumber) : base(Notify)
        {
            _phoneNumber = PhoneNumber;
        }
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Message: {message}\nTo PhoneNumber: {_phoneNumber}\n\n");
        }
    }
}
