using System.Linq;
using tv_shows_service.app.DTO;
using tv_shows_service.app.Exceptions;
using tv_shows_service.app.Interfaces.Commands;
using tv_shows_service.efc_data_access;
using domain = tv_shows_service.domain;

namespace EFCImplementation.User
{
    public class EFCAddUserImplementation : EFCBaseClass, IAddUserInterface
    {
        public EFCAddUserImplementation(TVShowsServiceContext context) : base(context)
        {
        }

        public void Execute(UserInsertDTO request)
        {
            if(Context.Users.Any(u => u.Username == request.Username))
            {
                throw new UniqueConstraintFailedException();
            }

            if (Context.Users.Any(u => u.Email == request.Email))
            {
                throw new UniqueConstraintFailedException();
            }

            Context.Users.Add(new domain.User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Username = request.Username,
                Password = BCrypt.Net.BCrypt.EnhancedHashPassword(request.Password),
                Token = BCrypt.Net.BCrypt.EnhancedHashPassword(request.Email + request.Password)
            });

            Context.SaveChanges();
        }
    }
}