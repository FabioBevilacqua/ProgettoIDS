using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Ordine
    {
        [Key]
        public int Id { get; set; }
        
        public List<OrdineProdotto> OrdineProdotto { get; set; }

        public double Totale { get; set; }

        [Required]
        public DateTime Created_At { get; set; }

        public DateTime? Deleted_At { get; set; }
    }
}
