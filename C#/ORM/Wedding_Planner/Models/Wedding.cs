using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wedding_Planner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId {get;set;}

        [Required]
        [Display(Name = "Wedder One")]
        public string Bride {get;set;}

        [Required]
        [Display(Name = "Wedder Two")]
        public string Groom {get;set;}

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date {get;set;}

        [Required]
        [Display(Name = "Wedding Address")]
        public string Address {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public User Creator {get;set;}
        
        List<RSVP> RSVP {get;set;}
    }
}