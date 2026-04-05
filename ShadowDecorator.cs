namespace StructuralPatterns_lab6
{
    public class ShadowDecorator : DrawableDecorator
    {
        public ShadowDecorator(IDrawable wrappee) : base(wrappee) { }

        public override void Draw()
        {
            base.Draw();
            Console.Write(" [Тень]");
        }
    }
}
