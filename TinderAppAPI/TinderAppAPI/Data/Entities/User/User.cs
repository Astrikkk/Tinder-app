using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Data.Entities.User
{
    public class User : IdentityUser
    {
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime? BirthDay { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public InterestedIn InterestedIn { get; set; }

        [Required]
        public LookingFor LookingFor { get; set; }

        [Required]
        public SexualOrientation SexualOrientation { get; set; }

        [Display(Name = "Interests")]
        public virtual ICollection<Interest>? Interests { get; set; } = new List<Interest>();

        [Display(Name = "Profile Photos")]
        public virtual ICollection<ProfilePhoto>? ProfilePhotos { get; set; } = new List<ProfilePhoto>();


    }
}
