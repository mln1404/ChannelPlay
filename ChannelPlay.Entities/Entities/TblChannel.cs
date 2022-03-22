using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelPlay.Entities.Entities
{
    public class TblChannel
    {
        [Key]
        [Range(1, int.MaxValue, ErrorMessage = "Minimum value is 1.")]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<TblInformation> Information { get; set; }
    }
}
