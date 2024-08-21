using System.ComponentModel.DataAnnotations;

namespace MosadAgent.Models
{
    public class Missoion
    {
        [Key]
        public Guid Id { get; set; }
        public Agent Agent { get; set; }
        public Target Target { get; set; }
        public Double timeToDo { get; set; }
        public StatusMissoion Status { get; set; }
    }
}
