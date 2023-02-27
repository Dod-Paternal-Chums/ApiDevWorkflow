using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestProject.Models
{
    class UserToUserContext
    {
        public bool isFollowing { get; set; }
        public IgnoreResponse ignoreStatus { get; set; }
    }
}
