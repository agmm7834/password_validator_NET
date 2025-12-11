using System.Collections.Generic;

namespace PasswordValidatorApp
{
    public static class CommonPasswords
    {
        public static readonly HashSet<string> List = new HashSet<string>()
        {
            "123456", "password", "qwerty", "111111", "abc123",
            "123123", "letmein", "dragon", "monkey", "iloveyou"
        };
    }
}
