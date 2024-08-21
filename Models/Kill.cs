using System.ComponentModel.DataAnnotations;

namespace MosadAgent.Models
{
    public class Kill
    {
        [Key]
        public Guid Id { get; set; }
        public Agent Agent { get; set; }
        public Target Target { get; set; }
        public DateTime Executiontime { get; set; }

    }
}
