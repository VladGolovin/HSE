using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExample
{
    public class QuestionContext : DbContext
    {
        public QuestionContext() : base("DefaultConnection")
        {

        }

        public DbSet<Question> Questions { get; set; }
    }
}
