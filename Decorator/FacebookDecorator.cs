using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class FacebookDecorator : NotifyDecorator
    {
        public string _facebookLogin;
        public FacebookDecorator(INotifier Notify, string FacebookLogin) : base(Notify)
        {
            _facebookLogin = FacebookLogin;
        }
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Message: {message}\nTo Facebook: {_facebookLogin}\n\n");
        }
    }
}
