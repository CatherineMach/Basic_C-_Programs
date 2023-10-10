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

        public Class1() : this("")
        {
            const int num = 123;
            var name = "Catherine";
        }


        public Class1(string username, string location)
        {
            this.username = username;
            this.location = location;
        }

        public Class1(string username) : this(username, "")
        {

        }

        public Class1(string location) : this(location, "")
        {   

        }
    }
}
