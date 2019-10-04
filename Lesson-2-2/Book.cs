
namespace Lesson_2_2
{
    class Book : Item, IAuthor
    {
        private string author;
        public string GetAuthor()
        {
            return author;
        }

        public void SetAuthor(string author)
        {
            this.author = author;
        }
    }
}
