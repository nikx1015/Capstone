using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models.ViewModels
{
    public class PlayerCountVM
    {
        public UserList userList { get; set; }

        public int NumberOfSavedGames { get; set; }

        public Game game { get; set; }

        public PlayerCountVM(int id)
        {

        }
    }
}
