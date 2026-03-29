using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Bridge
{
    public class VectorRenderer : IRenderer
    {
        public void Render(string shapeName)
        {
            Console.WriteLine($"Drawing {shapeName} as vector");
        }
    }

    public class RasterRenderer : IRenderer
    {
        public void Render(string shapeName)
        {
            Console.WriteLine($"Drawing {shapeName} as pixels");
        }
    }
}

