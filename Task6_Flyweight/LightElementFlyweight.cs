using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_Flyweight
{

    public enum DisplayType { Block, Inline }
    public enum TagClosure { SelfClosing, WithClosing }
    public class LightElementFlyweight
    {
        public string TagName { get; private set; }
        public DisplayType Display { get; private set; }
        public TagClosure Closure { get; private set; }

        public LightElementFlyweight(string tagName, DisplayType display, TagClosure closure)
        {
            TagName = tagName;
            Display = display;
            Closure = closure;
        }
    }

    public class FlyweightFactory
    {
        private Dictionary<string, LightElementFlyweight> _flyweights = new Dictionary<string, LightElementFlyweight>();

        public LightElementFlyweight GetFlyweight(string tagName, DisplayType display, TagClosure closure)
        {
            string key = $"{tagName}|{display}|{closure}";
            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new LightElementFlyweight(tagName, display, closure);
            }
            return _flyweights[key];
        }

        public int Count => _flyweights.Count;
    }
}
