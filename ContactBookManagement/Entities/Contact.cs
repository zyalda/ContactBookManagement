using System.ComponentModel.DataAnnotations;

namespace ContactBookManagement.Entities
{
    public class Contact
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "EmailIsRequired")]
        public string EmailAddress { get; set; }
    }
}
