using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.Shared.Data
{
    /// <summary>
    /// The repository for entries.
    /// </summary>
    public class EntriesRepository : BaseRepository<Entry>
    {
        public EntriesRepository(Context context) 
            : base(context)
        {
        }

        /// <summary>
        /// Returns a single entry for the provided ID.
        /// </summary>
        /// <param name="id">The ID for the entry to return.</param>
        /// <param name="includeRelatedEntities">Indicates whether or not to include related entities.</param>
        /// <returns>An entry.</returns>
        public override Entry Get(int id, bool includeRelatedEntities = true)
        {
            var entries = Context.Entries.AsQueryable();

            if (includeRelatedEntities)
            {
                entries = entries
                    .Include(e => e.Activity);
            }

            return entries
                .Where(e => e.Id == id)
                .SingleOrDefault();
        }

        /// <summary>
        /// Returns a collection of entries.
        /// </summary>
        /// <returns>A list of entries.</returns>
        public override IList<Entry> GetList()
        {
            return Context.Entries
                .Include(e => e.Activity)
                .OrderByDescending(e => e.Date)
                .ThenByDescending(e => e.Id)
                .ToList();
        }
    }
}