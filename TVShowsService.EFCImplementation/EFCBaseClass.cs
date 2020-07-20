using TVShowsService.EFCDataAccess;

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
