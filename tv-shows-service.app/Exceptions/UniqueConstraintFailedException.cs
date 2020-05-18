using System;

namespace tv_shows_service.app.Exceptions
{
    public class UniqueConstraintFailedException : Exception
    {
        private string _message;

        public UniqueConstraintFailedException(string message = "Value already exists!") => _message = message;
    }
}