using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Bridge
{
    public abstract class Shape
    {
        protected IRenderer _renderer;

        protected Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public abstract void Draw();
    }
}
