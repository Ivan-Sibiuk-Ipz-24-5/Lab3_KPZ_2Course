using Task6_Flyweight;

class Program
{
    static void Main(string[] args)
    {
        string[] bookLines = new string[]
        {
            "The Great Book",       // h1
            "Subtitle Here",        // h2
            "Short line",           // span
            " Another paragraph",   // blockquote
            "This is a longer paragraph in the book." // p
        };

        FlyweightFactory factory = new FlyweightFactory();
        BookParser parser = new BookParser(factory);
        LightElementNodeLW root = parser.ParseBook(bookLines);

        Console.WriteLine(root.OuterHTML);
        Console.WriteLine($"Number of flyweights: {factory.Count}");

        // Оцінка приблизного використання пам'яті
        long nodeCount = CountNodes(root);
        Console.WriteLine($"Total nodes in tree: {nodeCount}");
    }

    static long CountNodes(LightNode node)
    {
        long count = 1;
        if (node is LightElementNodeLW elem)
        {
            foreach (var child in elem.Children)
                count += CountNodes(child);
        }
        return count;
    }
}