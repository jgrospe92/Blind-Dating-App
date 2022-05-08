using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevTeamProject
{
    public class Root
    {
        public List<USER> USER { get; set; }
    }

    public class USER
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public string Bio { get; set; }
        public List<string> Traits { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> Likes { get; set; }
        public string Avatar { get; set; }
    }
}
