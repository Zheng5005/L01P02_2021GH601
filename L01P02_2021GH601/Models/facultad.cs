using System.ComponentModel.DataAnnotations;

namespace L01P02_2021GH601.Models
{
    public class facultad
    {
        [Key]
        public int id { get; set; }
        public string? facultades { get; set; }
    }
}
