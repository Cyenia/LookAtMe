using System;

namespace LookAtMe.Core;

public static class PlayerSearch
{
    /// <summary>The name contains the query, ignoring case and surrounding spaces; a blank query matches no one.</summary>
    public static bool Matches(string name, string query)
    {
        var trimmed = query.Trim();
        return trimmed.Length > 0 && name.Contains(trimmed, StringComparison.OrdinalIgnoreCase);
    }
}
