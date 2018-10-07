using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Treehouse.FitnessFrog.Shared.Data;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.ViewModels
{
    public class EntriesAddViewModel
        : EntriesBaseViewModel
    {
        public EntriesAddViewModel()
        {
            Entry.Date = DateTime.Today;
        }
    }
}