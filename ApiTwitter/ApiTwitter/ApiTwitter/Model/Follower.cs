using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTwitter.Model
{
    public class Follower
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("UserFriend")]
        public int UserFriendId { get; set; }
        public virtual User UserFriend { get; set; }

        public DateTime DateCreate { get; set; }
    }
}
