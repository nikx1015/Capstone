using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models.ViewModels
{
    public class UserListVM
    {
        public UserList userList { get; set; }

        public Game game { get; set; }

        public SelectList Games { get; set; }
    }
}
