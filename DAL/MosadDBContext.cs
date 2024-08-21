using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using MosadAgent.Models;


namespace MosadAgent.DAL
{
    public class MosadDBContext : DbContext
    {
        public DbSet<Agent> agents { get; set; }
        public DbSet<Target> targets { get; set; }
        public DbSet<Missoion> missoions { get; set; }
        public DbSet<Kill> kills { get; set; }

        public MosadDBContext(DbContextOptions<MosadDBContext> options) : base(options)
        {

            Database.EnsureCreated();

            if (agents.Count() == 0 && targets.Count() == 0 && missoions.Count() == 0 && kills.Count() == 0)
            {
                Seed();
            }




        }

        //LibraryName attacks;

        public void Seed()
        {
            Agent agent = new Agent()
            {
                Name = "Eli coen",
                Location = { { "x", 5 }, {"y", 250 } },
                Status = StatusAgent.Dormant
                

            };
            agents.Add(agent);

            Target target = new Target()
            {
                Name = "Batta Zibi",
                Role = "Komodor",
                Location = { { "x", 5 }, { "y", 250 } },
                Status = StatusTarget.free


            };
            targets.Add(target);

            Missoion missoion = new Missoion()
            {
                Agent = agent,
                Target = target,
                timeToDo = 2,
                Status = StatusMissoion.Offer


            };
            missoions.Add(missoion);

            Kill kill = new Kill()
            {
                Agent = null,
                Target = null,
                Executiontime = DateTime.Now

            };
            kills.Add(kill);
            SaveChanges();

        }
    }
}
