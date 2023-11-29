// було порушено принцип заміщення Лісков

namespace DZ8
{
    interface IShape
    {
        int Side { get; set; }
        int GetArea();
    }

    class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int Side
        {
            get { return Width; }
            set
            {
                Width = value;
                Height = value;
            }
        }

        public int GetArea()
        {
            return Width * Height;
        }
    }

    class Square : IShape
    {
        public int Side { get; set; }

        public int GetArea()
        {
            return Side * Side;
        }
    }

}
