using EFCImplementation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TVShowsService.App.DTO.Shows;
using TVShowsService.App.Interfaces.Commands.Show;
using TVShowsService.App.Searchs;
using TVShowsService.EFCDataAccess;

namespace TVShowsService.EFCImplementation.Show
{
    public class EFCGetShowsImplementation : EFCBaseClass, IGetShowsInterface
    {
        public EFCGetShowsImplementation(TVShowsServiceContext context) : base(context)
        {
        }

        public Pagination<ShowGetDTO> Execute(ShowSearch request)
        {
            var data = Context.Shows.AsQueryable();

            return new Pagination<ShowGetDTO>
            {
                Intel = data.Select(s => new ShowGetDTO
                {
                    Title = s.Title,
                    Body = s.Body,
                    About = s.About,
                    Likes = s.Likes,
                    Dislikes = s.Dislikes
                })
            };
        }
    }
}