using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinder.Models
{
    public class SendMessageViewModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(30, ErrorMessage = "Please enter at least 30 characters")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Please enter your Email")]
        [StringLength(50, ErrorMessage = "Please enter maximum 50 characters")]
        [EmailAddress(ErrorMessage = "Not a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your Subject")]
        [StringLength(50, ErrorMessage = "Please enter maximum 50 characters")]
        [MinLength(5, ErrorMessage ="Please enter at least 5 characters")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please enter your Message")]
        [StringLength(1000, ErrorMessage = "Message length too long")]
        public string Message { get; set; }

    }
}