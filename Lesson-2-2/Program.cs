
/// <summary>
/// Принцип разделения интерфейсов.
/// Товары в магазине могут иметь промокод, скидку, у них есть цена, состояние и т.д.
/// Если этот товар – одежда, для нее устанавливается материал, из которого она сделана, 
/// ее цвет и размер.
/// Какие изменения нужно внести в код, чтобы описать произвольные товары (книги, автомобили и т. п.), соблюдая принципы SOLID?
/// Выполнил Шадрин Андрей
/// </summary>
namespace Lesson_2_2
{
    class Program
    {
        static double DefaultDiscount = 10;
        static double DefaultPrice = 100;
        static void Main(string[] args)
        {
            Clothes tshirt = new Clothes();
            tshirt.SetPrice(DefaultPrice);
            Book book = new Book();
            book.SetAuthor("Moorkock");
            Item[] items = new Item[] { tshirt,  };
            foreach (Item item in items)
            {
                item.SetDiscount(DefaultDiscount);
            }
        }
    }
}
