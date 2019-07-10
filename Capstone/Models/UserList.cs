using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class UserList
    {
        [Required]
        public int UserListId { get; set; }

        [Required]
        public int GameId { get; set; }

        public Game game { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
