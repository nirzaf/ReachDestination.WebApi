using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class BusRoute
    {
        [Key] public int RouteNumber { get; set; }
        public int? TrueValue { get; set; }
        public int? FalseValue { get; set; }
        public string? Question { get; set; }
        public string? CurrentCity { get; set; }
    }
}