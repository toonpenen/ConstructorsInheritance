using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsInheritance.Models
{
    public class person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public person(string firstName, string lastName)
        {
            this.FirstName = FirstName;
            this.LastName = lastName;

        }
    }
}
