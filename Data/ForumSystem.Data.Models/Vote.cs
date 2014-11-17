namespace ForumSystem.Data.Models
{
    public class Vote
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int PostId { get; set; }

        // I'll fix it to enum if I have the time
        public int VoteValue { get; set; }
    }
}
