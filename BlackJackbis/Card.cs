namespace BlackJackbis
{
    public class Card
    {
        public Kolory Color { get; }

        public Figury Figure { get; }

        public Card(Figury figure, Kolory color)
        {
            Figure = figure;
            Color = color;
        }
    }
}