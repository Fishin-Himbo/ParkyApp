using System;
using System.ComponentModel.DataAnnotations;

namespace ParkyAPI.Models
{
    public class NationalPark
    {
        [Key] // Key attribute tells that this property should be a primary key
        public int NationalParkId { get; set; }

        [Required] // Required attribute tells that this property cannot be null.  The actual default value can be set in the migration file.
        public string NationalParkName { get; set; }

        [Required]
        public int StateId { get; set; }

        [Required]
        public DateTime CreatedDtim { get; set; }

        [Required]
        public string CreatedUser { get; set; }

        [Required]
        public DateTime ModifiedDtim { get; set; }

        [Required]
        public string ModifiedUser { get; set; }
    }
}
