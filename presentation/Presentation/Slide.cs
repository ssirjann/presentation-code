namespace Presentation
{
    public class Slide
    {
        public string Title { get; set; }

        public static implicit operator Slide(string title)
        {
            return new Slide {Title = title};
        }
    }
}