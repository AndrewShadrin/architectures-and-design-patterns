using System;

namespace Lesson_1_1
{
    public class DefaultIdGenerator : IIdGenerator
    {
        public long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }

    public class DefaultIdGenerator2 : IIdGenerator
    {
        public long CalculateId()
        {
            long id = DateTime.Now.Ticks/2;
            return id;
        }
    }

    public class Customer : EntityBase
    {
        public string Description { get; set; }

        public Customer(IIdGenerator idGenerator) : base(idGenerator)
        {
            
        }
    }

    public class Store : EntityBase
    {
        public Store(IIdGenerator idGenerator) : base(idGenerator)
        { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(new DefaultIdGenerator());
            Store store = new Store(new DefaultIdGenerator2());
            Console.WriteLine(customer.Id);
            Console.WriteLine(store.Id);
            Console.ReadKey();
        }
    }
}
