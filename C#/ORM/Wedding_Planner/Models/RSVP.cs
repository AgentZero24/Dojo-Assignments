using System.ComponentModel.DataAnnotations;

namespace Wedding_Planner.Models
{
    public class RSVP
    {
        [Key]
        public int RSPId {get;set;}

        public int UserId {get;set;}

        public int WeddingId {get;set;}

        public User User {get;set;}

        public Wedding Wedding {get;set;}
    }
}