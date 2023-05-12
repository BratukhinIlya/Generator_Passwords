using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorPasswords
{
    public class PassGenerator
    {
        public static string GeneratePassword(int length, bool excludeSimilar, bool excludeNonAlphanumeric)
        {
            string validCharacters = GetValidCharacters(excludeSimilar, excludeNonAlphanumeric);

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[length];
                rng.GetBytes(randomBytes);

                StringBuilder passwordBuilder = new StringBuilder(length);
                foreach (byte b in randomBytes)
                {
                    passwordBuilder.Append(validCharacters[b % validCharacters.Length]);
                }

                return passwordBuilder.ToString();
            }
        }

        private static string GetValidCharacters(bool excludeSimilar, bool excludeNonAlphanumeric)
        {
            string validCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890{}[]()/\\'\"`~,;:.<>";

            if (excludeSimilar)
            {
                validCharacters = RemoveCharacters(validCharacters, "iIlLoO");
            }

            if (excludeNonAlphanumeric)
            {
                validCharacters = RemoveCharacters(validCharacters, "{}[]()/\\'\"`~,;:.<>");
            }

            return validCharacters;
        }

        private static string RemoveCharacters(string input, string charactersToRemove)
        {
            StringBuilder outputBuilder = new StringBuilder(input.Length);
            foreach (char c in input)
            {
                if (charactersToRemove.IndexOf(c) == -1)
                {
                    outputBuilder.Append(c);
                }
            }

            return outputBuilder.ToString();
        }
    }
}
