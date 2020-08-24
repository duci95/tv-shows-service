using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TVShowsService.App.Searchs
{
    public class Pagination<TClass>
    {
        public int PagesCount { get; set; }
        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }
        public IEnumerable<TClass> Intel { get; set; }
    }
}   