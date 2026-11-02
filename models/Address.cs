using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.models
{
    [Owned]
    internal class Address
    {
        [Required]
        [StringLength(150)]
        public string Street { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string City { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Country { get; set; } = string.Empty;

        [Required]
        [Column("ZipCode")]
        [StringLength(20)]
        public string PostalCode { get; set; } = string.Empty;

    }
}
