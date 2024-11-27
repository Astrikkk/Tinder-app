using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Data.Entities.User
{
    public class User : IdentityUser
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(22)]
        public string Name { get; set; }

        [Required]
        public DateTime BirthDay { get; set; }

        public Gender Gender { get; set; }

        public InterestedIn InterestedIn { get; set; }

        public LookingFor LookingFor { get; set; }

        public SexualOrientation SexualOrientation { get; set; }

        public virtual ICollection<Interest> Interests { get; set; } = new List<Interest>();

        public virtual ICollection<ProfilePhoto> ProfilePhotos { get; set; } = new List<ProfilePhoto>();
    }
}
