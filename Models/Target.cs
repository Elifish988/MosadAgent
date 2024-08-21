using System.ComponentModel.DataAnnotations;

namespace MosadAgent.Models
{
    public class Target
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public Dictionary<string, int> Location { get; set; }
        public StatusTarget Status { get; set; }
    }
}
