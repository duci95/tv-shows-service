using System;
using System.Collections.Generic;
using System.Text;

namespace TVShowsService.App.Searchs
{
    public abstract class BaseSerach
    {
        public bool? OnlyActive { get; set; }
        public int PerPage { get; set; } 
        public int PageNumber { get; set; } 
    }
}
