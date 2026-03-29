using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Composite
{
    public enum DisplayType { Block, Inline }
    public enum TagClosure { SelfClosing, WithClosing }
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public DisplayType Display { get; set; }
        public TagClosure Closure { get; set; }
        public List<string> CssClasses { get; set; } = new List<string>();
        public List<LightNode> Children { get; set; } = new List<LightNode>();

        public LightElementNode(string tagName, DisplayType display, TagClosure closure)
        {
            TagName = tagName;
            Display = display;
            Closure = closure;
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public int ChildCount => Children.Count;

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
                if (Closure == TagClosure.SelfClosing)
                    return $"<{TagName}{classAttr}/>";
                else
                    return $"<{TagName}{classAttr}>{InnerHTML}</{TagName}>";
            }
        }
    }
}
