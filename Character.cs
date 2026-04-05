namespace StructuralPatterns_lab6
{
    public class Character : IDrawable
    {
        private readonly char _symbol;
        private readonly string _font;
        private readonly int _fontSize;

        public Character(char symbol, string font, int fontSize)
        {
            _symbol = symbol;
            _font = font;
            _fontSize = fontSize;
        }

        public void Draw(int positionX, int positionY)
        {
            Console.WriteLine($"[Flyweight] Символ '{_symbol}' (шрифт: {_font}, размер: {_fontSize}) в позиции ({positionX}, {positionY})");
        }

        void IDrawable.Draw() => Draw(0, 0);
    }
}
