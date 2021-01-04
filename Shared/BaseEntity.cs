namespace Shared
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public float Amount { get; set; }
        public float Commission { get; set;}
        public string Service { get; set; } 
    }
}