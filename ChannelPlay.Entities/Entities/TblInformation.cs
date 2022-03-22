using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelPlay.Entities.Entities
{
    public class TblInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Body { get; set; }
        public string Filename { get; set; }
        [Required]
        public int Priority { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Minimum value is 1.")]
        public int Duration { get; set; }
        public string Type { get; set; }
        public DateTime? ActiveFrom { get; set; }
        public DateTime? ActiveTo { get; set; }
        public int? ChannelID { get; set; }
        public TblChannel Channel { get; set; }
    }
}
