using System;
using System.Collections.Generic;
using System.Text;

namespace tv_shows_service.app.Interfaces
{
    public interface ICommand<Request>
    {
        void Execute(Request request);
    }

    public interface ICommand<Request, Response>
    {
        Response Execute(Request request);
    }
}
