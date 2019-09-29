using System;

namespace Lesson_1_1
{
    public abstract class EntityBase
    {
        private readonly IIdGenerator _idGenerator;
        public long Id { get; private set; }

        public EntityBase(IIdGenerator idGenerator)
        {
            if (idGenerator == null)
            {
                throw new ArgumentNullException("idGenerator");
            }
            _idGenerator = idGenerator;
            Id = _idGenerator.CalculateId();
        }

    }
}
