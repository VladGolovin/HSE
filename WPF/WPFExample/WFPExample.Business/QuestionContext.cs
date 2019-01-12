namespace WPFExample
{
    using System.Data.Entity;

    public class QuestionContext : DbContext
    {
        public QuestionContext() : base("DefaultConnection")
        {

        }

        public DbSet<Question> Questions { get; set; }
    }
}
