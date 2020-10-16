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

            if(request.ShowTitle != null)
            {
                data = data.Where(s => s.Title.ToLower().Contains(request.ShowTitle.ToLower()) 
                && !s.IsDeleted);
            }

            var totalCount = data.Count();

            data = data.Skip(request.PageNumber * request.PerPage - request.PerPage).Take(request.PerPage);

            // offset = pageNumber * perPage - perPage
            // limit = perPage

            var totalPages = (int)Math.Ceiling((double)totalCount / request.PerPage);


            return new Pagination<ShowGetDTO>
            {
                CurrentPage = request.PageNumber,
                PagesCount = totalPages,
                TotalCount = totalCount,
                Intel = data.Select(s => new ShowGetDTO
                {
                    Body = s.Body,
                    About = s.About,
                    Dislikes = s.Dislikes,
                    Likes = s.Likes,
                    Title = s.Title
                })
            };
        }
    }
}