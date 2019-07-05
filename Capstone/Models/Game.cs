using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string EsrbRating { get; set; }

        [Required]
        public string Platform { get; set; }

        [Required]
        public string NumberOfPlayers { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool HavePlayed { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}