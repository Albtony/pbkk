using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Database.Models
{
    [Table("contactList")]
    public class Contact
    {
        [PrimaryKey]
        public int Id { get; set; }

        public String ContactName { get; set; }

        public String InstituteName { get; set; }
        public String Email { get; set; }
        public String InstitutePhoneNo { get; set; }
        public String PrivatePhoneNo { get; set; }
    }
}
