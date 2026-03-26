namespace EGohd;

internal static class PluginInfo
{
    public const string DisplayName = "Eyes of Gohd";
    public const string InternalName = "EGohd";
    public const string Command = "/egohd";
    public const string Visibility = "Public";
    public const string Summary = "PvP nameplate augmentation scaffold for long-range player visibility.";
    public const string SupportUrl = "https://ko-fi.com/mcvaxius";
    public static readonly string[] Concept = new[]
    {
        "PvP-only long-range player tags.",
        "Start with display-only scaffolding.",
        "Keep the backend swappable if nameplate APIs drift."
    };
    public static readonly string[] Services = new[]
    {
        "PvpContextService",
        "NameplateTagService",
        "RuleEngine"
    };
    public static readonly string[] Phases = new[]
    {
        "Shell and docs",
        "PvP gating",
        "Nameplate backend",
        "Rules and filters",
        "Polish"
    };
    public static readonly string[] Tests = new[]
    {
        "Load plugin and open UI",
        "Check DTR toggle",
        "Check icon and manifest output"
    };
}
