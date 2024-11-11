using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class NotifyDecorator : INotifier
    {
        public INotifier notify;
        public NotifyDecorator(INotifier Notify) 
        { 
            notify = Notify;
        }
        public virtual void Send(string message)
        {
            notify.Send(message);
        }
    }
}
