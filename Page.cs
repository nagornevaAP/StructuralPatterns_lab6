namespace StructuralPatterns_lab6
{
    public class Page
    {
        private readonly List<IDrawable> _drawables = new();

        public void Add(IDrawable drawable) => _drawables.Add(drawable);

        public void Render()
        {
            foreach (var d in _drawables)
            {
                d.Draw();
                Console.WriteLine();
            }
        }
    }
}
