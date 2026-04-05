namespace StructuralPatterns_lab6
{
    public abstract class GraphicObject : IDrawable
    {
        protected readonly IRenderingEngine _engine;

        protected GraphicObject(IRenderingEngine engine)
        {
            _engine = engine;
        }

        public abstract void Draw();
        public abstract void Move(float dx, float dy);
    }
}
