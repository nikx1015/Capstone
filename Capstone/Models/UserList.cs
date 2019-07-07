using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class UserList
    {
        public int UserListId { get; set; }

        public int GameId { get; set; }

        public Game game { get; set; }
    }
}
