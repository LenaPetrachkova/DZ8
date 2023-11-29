// було порушено принцип єдиної відповідальності

namespace DZ8
{
    class Email
    {
        public String Theme { get; set; }
        public String From { get; set; }
        public String To { get; set; }
    }
    class EmailSender
    {
        public void Send(Email email)
        {
            // ... sending...
        }
    }
    class LogFormatter
    {
        public string FormatEmailLog(Email email)
        {
            return "Email from '" + email.From + "' to '" + email.To + "' was sent";
        }
    }

    class Logger
    {
        private LogFormatter logFormatter;

        public Logger(LogFormatter logFormatter)
        {
            this.logFormatter = logFormatter;
        }

        public void Log(Email email)
        {
            Console.WriteLine(logFormatter.FormatEmailLog(email));
        }
    }
  
}
