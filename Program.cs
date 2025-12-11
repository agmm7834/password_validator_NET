using System;

namespace PasswordValidatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Parol kiriting: ");
            string password = Console.ReadLine();

            var result = PasswordValidator.Validate(password);

            Console.WriteLine("\nNatija:");
            Console.WriteLine("Yaroqli: " + result.IsValid);

            if (result.Reasons.Count > 0)
            {
                Console.WriteLine("Sabablar:");
                foreach (var r in result.Reasons)
                    Console.WriteLine(" - " + r);
            }

            Console.ReadKey();
        }
    }
}
