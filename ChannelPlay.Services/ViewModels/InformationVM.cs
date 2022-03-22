using ChannelPlay.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ChannelPlay.Services.ViewModels
{
    public class InformationVM
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Body { get; set; }
        public string Filename { get; set; }
        [Required]
        public int Priority { get; set; }
        [Required]
        public int Duration { get; set; }
        public string Type { get; set; }
        public DateTime? ActiveFrom { get; set; }
        public DateTime? ActiveTo { get; set; }
        public int? ChannelID { get; set; }
    }
}
