using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Rastgele Şifre Oluşturucu");
        Console.WriteLine("------------------------");

        Console.Write("Şifre Uzunluğu: ");
        int passwordLength = Convert.ToInt32(Console.ReadLine());

        string randomPassword = GenerateRandomPassword(passwordLength);

        Console.WriteLine($"Oluşturulan Şifre: {randomPassword}");

        Console.ReadLine(); // Konsol penceresini kapatmak için bekletme
    }

    static string GenerateRandomPassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+-=[]{}|;:,.<>?";

        Random random = new Random();
        StringBuilder password = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            int index = random.Next(chars.Length);
            password.Append(chars[index]);
        }

        return password.ToString();
    }
}

