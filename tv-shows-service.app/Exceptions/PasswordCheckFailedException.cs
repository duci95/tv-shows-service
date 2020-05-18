using System;


namespace tv_shows_service.app.Exceptions
{
    public class PasswordCheckFailedException : Exception
    {
        private string _message;

        public PasswordCheckFailedException(string message="Passwords do not match!")
        {
            _message = message;
        }
    }
}
