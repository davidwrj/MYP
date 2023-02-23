using System.ComponentModel.DataAnnotations;

namespace DataModels
{
    public class Investment
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "Anonymous";
        public DateTimeOffset StartDate { get; set; }
        public InterestTypes InterestType { get; set; }
        public decimal InterestRate { get; set; }
        public decimal Principle { get; set; }
    }
}
