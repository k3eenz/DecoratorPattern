using Decorator;

INotifier notifier = new EmailNotify("123@gmail.com");

notifier = new SMSDecorator(notifier, "+1234567890");

notifier = new FacebookDecorator(notifier, "kenz");

notifier.Send("Hello!!!");