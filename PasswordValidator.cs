using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordValidatorApp
{
    public static class PasswordValidator
    {
        public static (bool IsValid, List<string> Reasons) Validate(string password)
        {
            var reasons = new List<string>();

            if (string.IsNullOrWhiteSpace(password))
            {
                reasons.Add("Parol bo'sh bo'lishi mumkin emas");
                return (false, reasons);
            }

            if (password.Length < 8)
                reasons.Add("Uzunligi kamida 8 bo'lishi kerak");

            int types = 0;
            if (password.Any(char.IsLower)) types++;
            if (password.Any(char.IsUpper)) types++;
            if (password.Any(char.IsDigit)) types++;
            if (password.Any(ch => !char.IsLetterOrDigit(ch))) types++;

            if (types < 3)
                reasons.Add("Kamida 3 turdagi belgi bo'lishi kerak (katta, kichik, raqam, maxsus)");

            if (CommonPasswords.List.Contains(password.ToLower()))
                reasons.Add("Bu juda ommabop parol — ishlatish mumkin emas");

            bool valid = reasons.Count == 0;
            return (valid, reasons);
        }
    }
}
