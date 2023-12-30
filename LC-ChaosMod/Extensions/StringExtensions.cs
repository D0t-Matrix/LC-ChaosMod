using System.Diagnostics.CodeAnalysis;

namespace LC_ChaosMod.Extensions
{
    internal static partial class StringExtensions
    {
        internal static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string? str)
            => string.IsNullOrWhiteSpace(str);

        internal static bool IsNullOrEmpty([NotNullWhen(false)] this string? str)
            => string.IsNullOrEmpty(str);
    }
}
