using Decorator;

INotifier notifier = new Decorator.EmailNotify("admin@example.com");
notifier = new Decorator.SMSDecorator(notifier, "+1234567890");
notifier = new Decorator.FacebookDecorator(notifier, "admin_facebook");
notifier.Send("Сервер упал!");
