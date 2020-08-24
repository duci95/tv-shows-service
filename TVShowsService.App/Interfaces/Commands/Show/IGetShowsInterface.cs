using System.Collections.Generic;
using System.Threading.Tasks;
using TVShowsService.App.DTO.Shows;
using TVShowsService.App.Searchs;

namespace TVShowsService.App.Interfaces.Commands.Show
{
    public interface IGetShowsInterface : ICommand<ShowSearch, Pagination<ShowGetDTO>>
    {
    }
}
