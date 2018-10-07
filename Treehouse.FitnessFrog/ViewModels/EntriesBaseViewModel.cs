using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Treehouse.FitnessFrog.Shared.Data;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.ViewModels
{
    public abstract class EntriesBaseViewModel
    {
        public Entry Entry { get; set; } = new Entry();

        public SelectList ActivitiesSelectListItems { get; set; }

        /// <summary>
        /// Initializes the view model.
        /// </summary>
        public void Init(ActivitiesRepository activitiesRepository)
        {
            ActivitiesSelectListItems = new SelectList(
                activitiesRepository.GetList(), "Id", "Name");
        }
    }
}