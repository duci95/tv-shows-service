using System;
using System.Collections.Generic;
using System.Text;
using tv_shows_service.efc_data_access;

namespace EFCImplementation
{
    public abstract class EFCBaseClass
    {
        protected TVShowsServiceContext Context { get; }

        protected EFCBaseClass(TVShowsServiceContext context)
        {
            Context = context;
        }
    }
}
