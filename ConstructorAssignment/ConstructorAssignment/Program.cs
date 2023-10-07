using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            public string username;
            public string location;

            public Program(string username)
            {
                this.username = username;
                location = "Online";
            }

            public Program(string username, string location)
            {
                this.username = username;
                this.location = location;
            }
        }
    }
}
