using CustomDDD.Domain.Primitives;

namespace Domain
{
    public abstract class Person : Entity
    {
        protected Person(Guid id) : base(id)
        {
        }
        public string? Name { get; private set; }
        public string? PhoneNumber { get; private set; }
        public string? Email { get; private set; }
        public string? Address { get; private set; }
    }
}