using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Class1
    {
        public string username;
        public string location;

        public Class1() : this("Catherine", "Home")
        {
            
        }


        public Class1(string username, string location)
        {
            this.username = username;
            this.location = location;
        }

        public Class1(string username) : this(username, "default")
        {
        }


    }
}
