using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistiration
{
   public class User
   { 
        public int Id { get; private set; }

        public string Username { get; set; }

        public string Surname { get; set; }

        public string Password { get; set; }

        public int Age { get; set; }

        public bool Gender { get; set; }

        public User()
        {
            this.Id = LocalStorage.Count;
            LocalStorage.Count++;
        }
    }
}
