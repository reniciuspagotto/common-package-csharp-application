using System.Text;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace PackageUtils.SecurityUtils;

public static class SecurityExtension
{
    public static string HashPasswordPbkdf2(this string password, string saltKey)
    {
        byte[] salt = Encoding.ASCII.GetBytes(saltKey);

        string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password!,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));

        return hashed;
    }
}