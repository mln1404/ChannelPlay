using System.ComponentModel.DataAnnotations;

namespace ChannelPlay.Services.ViewModels
{
    public class ChannelVM
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Minimum value is 1.")]
        public int Number { get; set; }
        public ICollection<InformationVM> Informations { get; set; }
    }
}
