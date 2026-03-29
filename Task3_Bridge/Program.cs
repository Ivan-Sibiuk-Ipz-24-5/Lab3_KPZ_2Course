using Task3_Bridge;

class Program
{
    static void Main(string[] args)
    {
        IRenderer vector = new VectorRenderer();
        IRenderer raster = new RasterRenderer();

        Shape circleVector = new Circle(vector);
        Shape squareRaster = new Square(raster);
        Shape triangleVector = new Triangle(vector);
        Shape triangleRaster = new Triangle(raster);

        circleVector.Draw();       // Drawing Circle as vector
        squareRaster.Draw();       // Drawing Square as pixels
        triangleVector.Draw();     // Drawing Triangle as vector
        triangleRaster.Draw();     // Drawing Triangle as pixels
    }
}