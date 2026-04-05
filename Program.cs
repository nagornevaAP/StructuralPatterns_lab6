namespace StructuralPatterns_lab6
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("=== Flyweight ===");
            var factory = new CharacterFactory();
            var c1 = factory.GetCharacter('A', "Arial", 12);
            var c2 = factory.GetCharacter('B', "Arial", 12);
            var c3 = factory.GetCharacter('A', "Arial", 12);

            c1.Draw(10, 20);
            c2.Draw(30, 40);
            c3.Draw(50, 60);
            Console.WriteLine($"Уникальных символов: {factory.GetCount()}\n");

            Console.WriteLine("=== Bridge + Proxy + Decorator ===");
            var engine = new ScreenRenderer();
            var document = new Document(engine);

            var page = document.CreatePage();

            page.Add(new Rectangle(engine, 100, 100, 300, 200));

            var image = new ImageProxy("photo_highres.jpg");
            var decorated = new BorderDecorator(
            new ShadowDecorator(
            new TransparencyDecorator(image, 0.75f)
            ), 5);

            page.Add(decorated);
            page.Add(new Ellipse(engine, 400, 150, 80, 50));

            document.RenderAll();

            Console.ReadKey();
        }
    }
}
