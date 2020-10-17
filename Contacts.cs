using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AddressBookProject
{
   public class Contacts
    {

        //// FirstName, LastName,Address, Phone,State,City,Email
        [Required (ErrorMessage = "This is a required field")]
        [StringLength (20,MinimumLength =5, ErrorMessage ="Name should be between 3 to 20 characters")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Name should be between 3 to 20 characters")]

        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [DataType(DataType.Text)]
        public string Address { get; set; }

        [Required (ErrorMessage ="This is a required field")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNuber { get; set; }

        [DataType(DataType.Text)]
        public string State { get; set; }

        [DataType(DataType.Text)]
        public string City { get; set; }

       [DataType(DataType.EmailAddress)]
        public string Email { get; set;  }
    }
}
