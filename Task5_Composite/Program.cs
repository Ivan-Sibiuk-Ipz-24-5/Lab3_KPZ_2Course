using Task5_Composite;

class Program
{
    static void Main(string[] args)
    {
        // Створимо div блочний з класом "container"
        LightElementNode div = new LightElementNode("div", DisplayType.Block, TagClosure.WithClosing);
        div.CssClasses.Add("container");

        // Додаємо заголовок
        LightElementNode h1 = new LightElementNode("h1", DisplayType.Block, TagClosure.WithClosing);
        h1.AddChild(new LightTextNode("Hello LightHTML!"));
        div.AddChild(h1);

        // Додаємо параграф
        LightElementNode p = new LightElementNode("p", DisplayType.Block, TagClosure.WithClosing);
        p.AddChild(new LightTextNode("This is a simple paragraph."));
        div.AddChild(p);

        // Додаємо рядковий елемент (спан)
        LightElementNode span = new LightElementNode("span", DisplayType.Inline, TagClosure.WithClosing);
        span.CssClasses.Add("highlight");
        span.AddChild(new LightTextNode("Highlighted text"));
        p.AddChild(span);

        // Виводимо OuterHTML
        Console.WriteLine(div.OuterHTML);
        Console.WriteLine($"Child count in div: {div.ChildCount}");
    }
}