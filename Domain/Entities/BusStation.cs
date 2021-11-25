using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class BusStation
    {
        [Key] public int StationId { get; set; }
        public string CityName { get; set; }
    }
}