using System.Security.Cryptography;

string GeneratePassword(int passwordLength)
{
    string characterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-+";
    string password = "";

    for (int i = 0; i < passwordLength; i++)
    {
        int randomIndex = RandomNumberGenerator.GetInt32(0, characterSet.Length);
        char randomCharacter = characterSet[randomIndex];

        password += randomCharacter;
    }

    return password;
}

string generatedPassword = GeneratePassword(16);
Console.WriteLine(generatedPassword);