using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public string CellPhoneNumber { get; set; }
        public int Id { get; internal set; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
