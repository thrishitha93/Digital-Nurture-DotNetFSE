using System;

namespace AccountsManagerLib
{
    public class AccountsManager
    {
        public string ValidateUser(string userId, string password)
        {
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(password))
            {
                throw new FormatException("Both user id and password are mandatory");
            }

            if ((userId.Equals("user_11") && password.Equals("secret@user11")) ||
                (userId.Equals("user_22") && password.Equals("secret@user22")))
            {
                return $"Welcome {userId}!!!";
            }

            return "Invalid user id/password";
        }
    }
}