using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace ClassicComedians.Models.ViewModels
{
    public class ComedianCreateViewModel
    {
        public Comedian Comedian { get; set; }
        public IEnumerable<Group> AllGroups { get; set; }
        public IEnumerable<SelectListItem> GroupOptions
        {
            get
            {
                if (AllGroups == null)
                {
                    return null;
                }

                return AllGroups.Select(g => 
                    new SelectListItem {
                        Text = g.Name,
                        Value = g.Id.ToString()
                    }
                );
            }
        }
    }
}
