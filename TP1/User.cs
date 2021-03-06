using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class User
    {
        public string username {get; set; }
        public string password { get; set; }

        public User() { }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public int Auth()
        { 
            int a = string.Compare(this.username, "bebas");
            int b = string.Compare(this.password, "pbo123");

            if (a == 0 && b == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
