namespace TVShowsService.App.Interfaces
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
