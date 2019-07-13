using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Game
    {
        [Required]
        public int GameId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Display(Name = "ESRB Rating")]
        public string EsrbRating { get; set; }

        [Required]
        public string Platform { get; set; }

        [Required]
        [Display(Name = "Number of Players")]
        public string NumberOfPlayers { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Have Played This Game?")]
        public bool HavePlayed { get; set; }

        [Required]
        public string UserId { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Link To Purchase")]
        public string UrlToPurchase { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public List<UserList> UserLists { get; set; }
        [Display(Name = "")]

        public byte[] GameImage { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

    }
}