using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_Flyweight
{
    class BookParser
    {
        private FlyweightFactory _factory;

        public BookParser(FlyweightFactory factory)
        {
            _factory = factory;
        }

        public LightElementNodeLW ParseBook(string[] lines)
        {
            LightElementFlyweight rootFly = _factory.GetFlyweight("div", DisplayType.Block, TagClosure.WithClosing);
            LightElementNodeLW root = new LightElementNodeLW(rootFly);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                LightElementFlyweight flyweight;
                if (i == 0) flyweight = _factory.GetFlyweight("h1", DisplayType.Block, TagClosure.WithClosing);
                else if (i == 1) flyweight = _factory.GetFlyweight("h2", DisplayType.Block, TagClosure.WithClosing);
                else if (line.Length < 20) flyweight = _factory.GetFlyweight("span", DisplayType.Inline, TagClosure.WithClosing);
                else if (!string.IsNullOrEmpty(line) && char.IsWhiteSpace(line[0])) flyweight = _factory.GetFlyweight("blockquote", DisplayType.Block, TagClosure.WithClosing);
                else flyweight = _factory.GetFlyweight("p", DisplayType.Block, TagClosure.WithClosing);

                LightElementNodeLW node = new LightElementNodeLW(flyweight);
                node.AddChild(new LightTextNode(line));
                root.AddChild(node);
            }

            return root;
        }
    }
}
