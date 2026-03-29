using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_Flyweight
{
    public class LightElementNodeLW : LightNode
    {
        private LightElementFlyweight _flyweight;
        public List<LightNode> Children { get; set; } = new List<LightNode>();
        public List<string> CssClasses { get; set; } = new List<string>();

        public LightElementNodeLW(LightElementFlyweight flyweight)
        {
            _flyweight = flyweight;
        }

        public void AddChild(LightNode child) => Children.Add(child);

        public override string InnerHTML
        {
            get
            {
                string inner = "";
                foreach (var child in Children)
                    inner += child.OuterHTML;
                return inner;
            }
        }

        public override string OuterHTML
        {
            get
            {
                string classAttr = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
                if (_flyweight.Closure == TagClosure.SelfClosing)
                    return $"<{_flyweight.TagName}{classAttr}/>";
                else
                    return $"<{_flyweight.TagName}{classAttr}>{InnerHTML}</{_flyweight.TagName}>";
            }
        }
    }
}
