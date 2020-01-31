namespace MoneyTransfer.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public bool Archived { get; set; }
    }
}