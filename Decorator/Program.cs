using Decorator;

INotifier notifier = new EmailNotify("admin@example.com");
notifier = new SMSDecorator(notifier, "+1234567890");
notifier = new FacebookDecorator(notifier, "facebookLogin");
notifier.Send("Сервер упал!");
