// принцип розділення інтерфейсу

namespace DZ8
{
    interface IDiscount
    {
        void ApplyDiscount(string discount);
    }

    interface IPromocode
    {
        void ApplyPromocode(string promocode);
    }

    interface IColor
    {
        void SetColor(byte color);
    }

    interface ISize
    {
        void SetSize(byte size);
    }

    interface IPrice
    {
        void SetPrice(double price);
    }

    class Book : IDiscount, IPrice
    {
        public void ApplyDiscount(string discount)
        {
            // знижка на книгу
        }

        public void SetPrice(double price)
        {
            // встановлення ціни
        }
    }

    class Clothing : IDiscount, IPromocode, IColor, ISize, IPrice
    {
        public void ApplyDiscount(string discount)
        {
            // знижка на одяг
        }

        public void ApplyPromocode(string promocode)
        {
            // промокод на одяг
        }

        public void SetColor(byte color)
        {
            // встановлення кольору
        }

        public void SetSize(byte size)
        {
            // встановлення розміру
        }

        public void SetPrice(double price)
        {
            // встановлення ціни
        }
    }
}
