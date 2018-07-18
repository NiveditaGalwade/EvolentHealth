using System.ComponentModel.DataAnnotations;

namespace OnlineDirectory.DomainEntites
{
    public class Contact
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only alphabets allowed")]
        public string First_Name { get; set; }

        [StringLength(50)]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only alphabets allowed")]
        public string Last_Name { get; set; }

        [StringLength(50)]
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [StringLength(10)]
        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Mobile Number is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid mobile number")]
        public string Mobile_Number { get; set; }
        public Contact()
        {

        }
        public Contact(int id,string firstName,string lastName,string email,string mobileNumber)
        {
            Id = id;
            First_Name = firstName;
            Last_Name = lastName;
            Email = email;
            Mobile_Number = mobileNumber;
        }
    }
}
