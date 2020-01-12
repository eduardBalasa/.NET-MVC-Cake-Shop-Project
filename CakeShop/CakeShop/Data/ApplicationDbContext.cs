using CakeShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<Cake> Cakes { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // add categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, Name = "Torturi Nunta" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, Name = "Torturi Botez" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, Name = "Candy Bar" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, Name = "Deserturi" });

            // add cakes
            modelBuilder.Entity<Cake>().HasData(new Cake { CakeId = 1, Name = "Ghirlanda de trandafiri", CategoryId = 1, Price = 500, Description = "In nuante pastelate, ghirlanda de trandafiri cu care am decorat acest tort de nunta ii confera o nota de eleganta si rafinament. Perlele si brosa sunt cateva din detaliile mici delicate si elegante.", ImageName = "TortGhirlandaDeTrandafiri.jpg" });
            modelBuilder.Entity<Cake>().HasData(new Cake { CakeId = 2, Name = "Fluturi in Degradee", CategoryId = 1, Price = 700, Description = "Un tort de nunta pe care am ales sa il decoram cu o cascada de fluturi in degradee de mov, iar deasupra au fost asezati cei doi miri realizati manual.", ImageName = "FluturiInDegradee.jpg" });
            modelBuilder.Entity<Cake>().HasData(new Cake { CakeId = 3, Name = "Luna Roz", CategoryId = 2, Price = 400, Description = "Flavia Maria a avut parte de un tort de botez pe masura petrecerii. Decorat cu detalii in nuante de roz pastel si alb, o luna instelata si insertii aurite, tortul cu o compozitie usoara si fructata, a facut deliciul invitatilor aflati la petrecere.", ImageName = "LunaRoz.jpg" });
            modelBuilder.Entity<Cake>().HasData(new Cake { CakeId = 4, Name = "Luna Albastra", CategoryId = 2, Price = 450, Description = "Tort de botez pentru baieti cu doua etaje, realizat in pasteluri bleu si argintii, asemenea celui din imagine. Alege compozitia preferata si lasa-i pe designerii nostri sa transforme tortul intr-o poveste magica!", ImageName = "LunaAlbastra.jpg" });
            modelBuilder.Entity<Cake>().HasData(new Cake { CakeId = 5, Name = "Briose cu Ciocolata", CategoryId = 3, Price = 50, Description = "Iata un desert ciocolatos si pufos ! Briosele au o aroma intensa de ciocolata si fi servite alaturi de o cafea.", ImageName = "BrioseCuCiocolata.jpg" });
            modelBuilder.Entity<Cake>().HasData(new Cake { CakeId = 6, Name = "Macarons Christmas Tree", CategoryId = 3, Price = 80, Description = "Produs de cofetărie de origine franceză, realizat din pudra de migdale, avand la mijloc o cremă deosebită.", ImageName = "MacaronsChristmasTree.jpg" });
            modelBuilder.Entity<Cake>().HasData(new Cake { CakeId = 7, Name = "Mini Amandine", CategoryId = 4, Price = 30, Description = "Prajituri delicioase preparate pe un blat alb pufos, bine insiropat, avand un strat de crema de ciocolata alba si lamaie. Sunt finisate cu fondant, in diverse culori.", ImageName = "MiniAmandine.jpg" });
            modelBuilder.Entity<Cake>().HasData(new Cake { CakeId = 8, Name = "MiniEclere", CategoryId = 4, Price = 40, Description = "Mini eclere –  sunt preparate din aluat oparit si pufos, cu o cremă delicioasa de ciocolata, acoperite cu o crustă bogată de fondant.", ImageName = "MiniEclere.jpg" });
        }
    }
}
