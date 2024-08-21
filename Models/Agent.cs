using System.ComponentModel.DataAnnotations;

namespace MosadAgent.Models
{
    public class Agent
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Dictionary<string, int> Location { get; set; }
        public StatusAgent Status { get; set; }
    }
}
