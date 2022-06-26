namespace Core.Entities.Concrete
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SSN { get; set; }
    }
}
