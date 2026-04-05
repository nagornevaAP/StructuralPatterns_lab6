namespace StructuralPatterns_lab6
{
    public class TransparencyDecorator : DrawableDecorator
    {
        private readonly float _opacity;

        public TransparencyDecorator(IDrawable wrappee, float opacity) : base(wrappee)
        {
            _opacity = opacity;
        }

        public override void Draw()
        {
            base.Draw();
            Console.Write($" [Прозрачность {_opacity * 100}%]");
        }
    }
}
