using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelStateDemo.ViewModels.Home
{
public class AddUserVM
{
    [Required(ErrorMessage = "Please enter the user's first name.")]
    [StringLength(50, ErrorMessage = "The First Name must be less than {1} characters.")]
    [Display(Name = "First Name:")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Please enter the user's last name.")]
    [StringLength(50, ErrorMessage = "The Last Name must be less than {1} characters.")]
    [Display(Name = "Last Name:")]
    public string LastName { get; set; }

    [EmailAddress(ErrorMessage = "The Email Address is not valid")]
    [Required(ErrorMessage = "Please enter an email address.")]
    [Display(Name = "Email Address:")]
    public string EmailAddress { get; set; }
}
}