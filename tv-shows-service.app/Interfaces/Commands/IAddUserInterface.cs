using System;
using System.Collections.Generic;
using System.Text;
using tv_shows_service.app.DTO;

namespace tv_shows_service.app.Interfaces.Commands
{
    public interface IAddUserInterface : ICommand<UserInsertDTO>
    {

    }
}
