using System.Collections.Generic;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.ViewModels
{
    public class EntriesIndexViewModel
    {
        public IList<Entry> Entries { get; set; }
        public decimal TotalActivity { get; set; }
        public decimal AverageDailyActivity { get; set; }
    }
}