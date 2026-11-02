using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.models
{
    internal class Attendee
    {
        public int AttendeeId { get; set; }

        [Required]
        [StringLength(150)]
        public string FullName { get; set; } 

        [Required]
        [EmailAddress]
        [StringLength(200)]
        public string Email { get; set; } 

        public Address HomeAddress { get; set; }

        [NotMapped]
        public string FullAddress => $"{HomeAddress.Street}, {HomeAddress.City}, {HomeAddress.Country} {HomeAddress.PostalCode}".Trim( ' ',' ', ' ');

        
    
        public ICollection<AttendeeBadge> AttendeeBadges { get; set; } = new List<AttendeeBadge>();
    }
}

