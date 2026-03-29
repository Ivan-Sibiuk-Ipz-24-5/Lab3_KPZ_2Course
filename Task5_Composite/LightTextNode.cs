using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Composite
{
    public class LightTextNode : LightNode
    {
        public string Text { get; set; }

        public LightTextNode(string text)
        {
            Text = text;
        }

        public override string InnerHTML => Text;
        public override string OuterHTML => Text;
    }
}
