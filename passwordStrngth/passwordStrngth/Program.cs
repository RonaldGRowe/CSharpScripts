class PasswordStrength
{
    public static void Main()
    {
        List<char> vowel = new() { 'a', 'e', 'i', 'o','u' };
        List<char> consonant = new() { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y','z' };

        string password = "aaaaaaaaaaaa";
        int letter = 0;
        int strength = 0;

        if (password.Length < 2)
        {
            Console.WriteLine(strength);
        }
        else 
        { 
            while (letter < password.Length)
            {
                if (vowel.Contains(password[letter]))
                {
                    while (vowel.Contains(password[letter]))
                    {
                        letter++;
                        if (letter >= password.Length)
                        {
                            break;
                        }
                    }
                    if (letter < password.Length && consonant.Contains(password[letter]))
                    {
                        strength++;
                        letter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (consonant.Contains(password[letter]))
                {
                    while (consonant.Contains(password[letter]))
                    {
                        letter++;
                        if (letter >= password.Length)
                        {
                            break;
                        }
                    }
                    if (letter < password.Length && vowel.Contains(password[letter]))
                    {
                        strength++;
                        letter++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(strength);
        }
    }
}
