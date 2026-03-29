using Task1_Adapter;

class Program
{
    static void Main(string[] args)
    {
        // Консольний логер
        ILogger consoleLogger = new Logger();

        consoleLogger.Log("Це звичайне повідомлення");
        consoleLogger.Warn("Це попередження");
        consoleLogger.Error("Це помилка");

        // Файловий логер через адаптер
        FileWriter writer = new FileWriter("log.txt");
        ILogger fileLogger = new FileLoggerAdapter(writer);

        fileLogger.Log("Запис у файл: лог");
        fileLogger.Warn("Запис у файл: попередження");
        fileLogger.Error("Запис у файл: помилка");

        Console.WriteLine("Перевір файл log.txt 😉");
    }
}