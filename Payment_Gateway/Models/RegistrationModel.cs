namespace Payment_Gateway.Models
{
    public class RegistrationModel
    {
        public string? Name { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public decimal Amount { get; set; }
    }
}