using System;
using System.Collections.Generic;
using System.Text;

namespace TVShowsService.Domain
{
    public class Picture : BaseDomain
    {
        public string PicturePath { get; set; }
        public Show Show { get; set; }
    }
}