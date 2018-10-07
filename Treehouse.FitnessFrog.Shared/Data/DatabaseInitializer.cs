using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.Shared.Data
{
    /// <summary>
    /// Custom database initializer class used to populate
    /// the database with seed data.
    /// </summary>
    internal class DatabaseInitializer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            var activityBasketball = new Activity() { Name = "Basketball" };
            var activityBiking = new Activity() { Name = "Biking" };
            var activityHiking = new Activity() { Name = "Hiking" };
            var activityKayaking = new Activity() { Name = "Kayaking" };
            var activityPokemonGo = new Activity() { Name = "Pokemon Go" };
            var activityRunning = new Activity() { Name = "Running" };
            var activitySkiing = new Activity() { Name = "Skiing" };
            var activitySwimming = new Activity() { Name = "Swimming" };
            var activityWalking = new Activity() { Name = "Walking" };
            var activityWeightLifting = new Activity() { Name = "Weight Lifting" };

            var activities = new List<Activity>()
            {
                activityBasketball,
                activityBiking,
                activityHiking,
                activityKayaking,
                activityPokemonGo,
                activityRunning,
                activitySkiing,
                activitySwimming,
                activityWalking,
                activityWeightLifting
            };

            context.Activities.AddRange(activities);

            var entries = new List<Entry>()
            {
                new Entry(2017, 7, 8, activityBiking, 10.0m),
                new Entry(2017, 7, 9, activityBiking, 12.2m),
                new Entry(2017, 7, 10, activityHiking, 123.0m),
                new Entry(2017, 7, 12, activityBiking, 10.0m),
                new Entry(2017, 7, 13, activityWalking, 32.2m),
                new Entry(2017, 7, 13, activityBiking, 13.3m),
                new Entry(2017, 7, 14, activityBiking, 10.0m),
                new Entry(2017, 7, 15, activityWalking, 28.6m),
                new Entry(2017, 7, 16, activityBiking, 12.7m),
                new Entry(2017, 7, 16, activityPokemonGo, 23.4m)
            };

            context.Entries.AddRange(entries);

            context.SaveChanges();
        }
    }
}
