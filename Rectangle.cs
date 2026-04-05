namespace StructuralPatterns_lab6
{
    public class Rectangle : GraphicObject
    {
        private readonly float _x, _y, _width, _height;

        public Rectangle(IRenderingEngine engine, float x, float y, float width, float height)
        : base(engine)
        {
            _x = x; _y = y; _width = width; _height = height;
        }

        public override void Draw() => _engine.RenderRectangle(_x, _y, _width, _height);
        public override void Move(float dx, float dy) => Console.WriteLine($"[Move] Прямоугольник сдвинут");
    }
}
