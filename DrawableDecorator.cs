namespace StructuralPatterns_lab6
{
    public abstract class DrawableDecorator : IDrawable
    {
        protected readonly IDrawable _wrappee;

        protected DrawableDecorator(IDrawable wrappee)
        {
            _wrappee = wrappee;
        }

        public virtual void Draw()
        {
            _wrappee.Draw();
        }
    }
}
