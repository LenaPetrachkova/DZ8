using DZ8;

class Program
{
    // Task2
    static void Main(string[] args)
    {
        Email e1 = new Email()
        {
            From = "Me",
            To = "Vasya",
            Theme = "Who are you?"
        };
        Email e2 = new Email()
        {
            From = "Vasya",
            To = "Me",
            Theme = "vacuum cleaners!"
        };
        Email e3 = new Email()
        {
            From = "Kolya",
            To = "Vasya",
            Theme = "No! Thanks!"
        };
        Email e4 = new Email()
        {
            From = "Vasya",
            To = "Me",
            Theme = "washing machines!"
        };
        Email e5 = new Email()
        {
            From = "Me",
            To = "Vasya",
            Theme = "Yes"
        };
        Email e6 = new Email()
        {
            From = "Vasya",
            To = "Petya",
            Theme = "+2"
        };
        EmailSender es = new EmailSender();
        LogFormatter logFormatter = new LogFormatter();
        Logger logger = new Logger(logFormatter);

        es.Send(e1);
        logger.Log(e1);
        es.Send(e2);
        logger.Log(e2);
        es.Send(e3);
        logger.Log(e3);
        es.Send(e4);
        logger.Log(e4);
        es.Send(e5);
        logger.Log(e5);
        es.Send(e6);
        logger.Log(e6);


        // Task3
        IShape rectangle = new Rectangle() { Width = 5, Height = 10 };
        IShape square = new Square() { Side = 5 };

        Console.WriteLine(rectangle.GetArea()); // виведе 50
        Console.WriteLine(square.GetArea()); // виведе 25
    }
}


