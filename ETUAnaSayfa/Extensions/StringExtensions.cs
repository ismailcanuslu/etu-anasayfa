namespace ETUAnaSayfa.Extensions;

using System;
using System.Text.RegularExpressions;

public static class StringExtensions
{
    public static string ToSlug(this string text)
    {
        if (string.IsNullOrEmpty(text)) return "";

        // Türkçe karakterleri değiştir
        var replacements = new Dictionary<string, string>
        {
            {"İ", "I"},
            {"I", "i"},
            {"ı", "i"},
            {"Ğ", "G"},
            {"ğ", "g"},
            {"Ü", "U"},
            {"ü", "u"},
            {"Ş", "S"},
            {"ş", "s"},
            {"Ö", "O"},
            {"ö", "o"},
            {"Ç", "C"},
            {"ç", "c"},
            {" ", "-"},
            {".", ""},
            {",", ""},
            {"!", ""},
            {"?", ""},
            {":", ""},
            {";", ""},
            {"'", ""},
            {"\"", ""},
            {"\\", ""},
            {"/", ""},
            {"|", ""},
            {"(", ""},
            {")", ""},
            {"[", ""},
            {"]", ""},
            {"{", ""},
            {"}", ""},
            {"&", ""},
            {"@", ""},
            {"#", ""},
            {"$", ""},
            {"%", ""},
            {"^", ""},
            {"*", ""},
            {"+", ""},
            {"=", ""},
            {"~", ""},
            {"`", ""}
        };

        // Tüm değişimleri uygula
        foreach (var replacement in replacements)
        {
            text = text.Replace(replacement.Key, replacement.Value);
        }

        // Tüm karakterleri küçük harfe çevir
        text = text.ToLower();

        // Birden fazla tireyi tek tireye çevir
        text = Regex.Replace(text, @"-+", "-");

        // Baştaki ve sondaki tireleri kaldır
        return text.Trim('-');
    }
}