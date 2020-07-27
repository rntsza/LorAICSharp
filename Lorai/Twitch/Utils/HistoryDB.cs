using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Lorai.Twitch.Utils
{
    class HistoryDB : DbContext
    {
        public DbSet<TwitchUsers> TwitchUsers { get; set; }

        public HistoryDB() : base("name=ContextDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
