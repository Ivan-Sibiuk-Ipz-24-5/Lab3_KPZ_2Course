using Task4_Proxi;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо тестові файли
        System.IO.File.WriteAllText("file1.txt", "Hello\nWorld");
        System.IO.File.WriteAllText("secret.txt", "Top secret data");

        // Проксі з логуванням
        SmartTextReader reader1 = new SmartTextReader("file1.txt");
        SmartTextChecker checker = new SmartTextChecker(reader1);
        var data1 = checker.Read(); // Логування успішного відкриття та stats

        Console.WriteLine();

        // Проксі з обмеженням доступу (доступ до файлів із "secret" заборонений)
        SmartTextReader reader2 = new SmartTextReader("secret.txt");
        SmartTextReaderLocker locker = new SmartTextReaderLocker(reader2, "secret.*");
        var data2 = locker.Read(); // Виведе "Access denied!"

        // Доступ до файлу без обмежень
        SmartTextReader reader3 = new SmartTextReader("file1.txt");
        SmartTextReaderLocker locker2 = new SmartTextReaderLocker(reader3, "secret.*");
        var data3 = locker2.Read(); // Читає файл успішно
    }
}