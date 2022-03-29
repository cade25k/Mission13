using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13.Models
{
    // Bowler repository for data access
    public class EFBowlersRepository : IBowlersRepository
    {
        private BowlersDbContext context { get; set; }
        public EFBowlersRepository (BowlersDbContext bc)
        {
            context = bc;
        }
        public IQueryable<Bowler> Bowlers => context.Bowlers;
        public IQueryable<Team> Teams => context.Teams;

        public void SaveBowler(Bowler b)
        {
            context.Update(b);
            context.SaveChanges();
        }

        public void CreateBowler(Bowler b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBowler(Bowler b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
    }
}
