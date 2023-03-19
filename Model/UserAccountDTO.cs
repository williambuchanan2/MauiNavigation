using System;
using System.ComponentModel.DataAnnotations;

namespace MauiApp3;


public class UserAccountDTO
{
    public int Id { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Firstname required")]
    public string FirstName { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Lastname required")]
    public string LastName { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Username required")]
    public string UsernameEmail { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Password required")]
    public string HashedPassword { get; set; }

    public string Mobile { get; set; }
    public string JobTitle { get; set; }
    public string CompanyName { get; set; }
    public string Bio { get; set; }

    public DateTime? MobileVerifiedDateTime { get; set; }

    public string Postcode { get; set; }

    public string UserToken { get; set; }

    public DateTime? UserTokenExpiry { get; set; }

    public DateTime? LastLogin { get; set; }

    public DateTime? LastFailedLogin { get; set; }

    public int FailedLoginCount { get; set; }

    public string GpsLatitude { get; set; }

    public string GpsLongitude { get; set; }

    public string GpsAltitude { get; set; }

    public DateTime? CurrentTermsAcceptedDateTime { get; set; }

    public DateTime? PreviousTermsAcceptedDateTime { get; set; }

    public byte[] ProfileImageThumbnail { get; set; }
    public string ProfileImageThumbnailFileName { get; set; }
    public bool AccountSetupCompleted { get; set; }
    public string LastMoodStatusId { get; set; }

}

