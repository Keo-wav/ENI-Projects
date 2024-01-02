using System.Globalization;
using System.Text;

Console.WriteLine("PALINDROME CHECKER");
Console.WriteLine("------------------");
Console.WriteLine("TYPE A WORD OR SENTENCE, I'LL TELL YOU IF IT IS A PALINDROME OR NOT");
Console.Write("> ");

var userInput = Console.ReadLine();
PalindromeTest(userInput);

static void PalindromeTest(string userInput)
{
    string testString;
    userInput = RemoveSpaces(userInput);
    userInput = RemovePunctuation(userInput);
    userInput = RemoveDiacritics(userInput);
    testString = ReverseString(userInput);

    // test the input string vs the processed string
    if (userInput == testString)
        Console.WriteLine("Your sentence is a palindrome");
    else
        Console.WriteLine("Not a palindrome, you piece of shit");
}

static string ReverseString(string text)
{
    text.ToCharArray().Reverse();
    return text;
}

static string RemoveDiacritics(string text)
{
    string normalizedString = text.Normalize(NormalizationForm.FormD);
    var sb = new StringBuilder(normalizedString.Length);

    foreach (char c in normalizedString)
    {
        if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
            sb.Append(c);
    }
    var testString = sb.ToString();
    return testString;
}

static string RemoveSpaces(string text)
{
    string noSpaceString = text.Replace(" ", "");
    return noSpaceString;
}

static string RemovePunctuation(string text)
{
    char[] charArray = text.ToCharArray();
    StringBuilder sb = new StringBuilder();

    for (int i = 0; i < charArray.Length; i++)
    {
        if (!(Char.IsPunctuation(charArray[i])))
            sb.Append(charArray[i]);
    }
    var noPunctString = sb.ToString();
    return noPunctString;
}