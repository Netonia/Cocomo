namespace Cocomo.Extensions;

public static class StringExtensions
{
    public static string FirstLetterToLower(this string source)
    {
        if (string.IsNullOrEmpty(source))
        {
            return String.Empty;
        }

        return source?[..1].ToLower() + (source?.Length > 1 ? source[1..] : "");
    }

    public static string Truncate(this string value, int maxLength)
    {
        if (string.IsNullOrEmpty(value)) return value;
        return value.Length <= maxLength ? value : value.Substring(0, maxLength);
    }
}
